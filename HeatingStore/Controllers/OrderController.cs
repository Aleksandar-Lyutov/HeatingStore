using HeatingStore.Data;
using HeatingStore.Domain;
using HeatingStore.Models.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HeatingStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);
            List<OrderIndexVM> orders = _context.Orders.Select(x => new OrderIndexVM
            {
                Id = x.Id,
                OrderDate = x.OrderDate.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture),
                UserId = x.UserId,
                User = x.User.UserName,
                HeatingDeviceId = x.HeatingDeviceId,
                HeatingDevice = x.HeatingDevice.HeatingDeviceName,
                Picture = x.HeatingDevice.Picture,
                Quantity = x.Quantity,
                Description = x.HeatingDevice.Description,
                Price = x.Price,
                Discount = x.Discount,
                TotalPrice = x.TotalPrice,
            }).ToList();
            return View(orders);
        }
        public IActionResult MyOrders(string searchString)
        {
            string currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == currentUserId);
            if (user == null)
            {
                return null;
            }
            List<OrderIndexVM> orders = _context.Orders.Where(x => x.UserId == user.Id).Select(x => new OrderIndexVM
            {
                Id = x.Id,
                OrderDate = x.OrderDate.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture),
                UserId = x.UserId,
                User = x.User.UserName,
                HeatingDeviceId = x.HeatingDeviceId,
                HeatingDevice = x.HeatingDevice.HeatingDeviceName,
                Picture = x.HeatingDevice.Picture,
                Quantity = x.Quantity,
                Description = x.HeatingDevice.Description,
                Price = x.Price,
                Discount = x.Discount,
                TotalPrice = x.TotalPrice,
            }).ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                orders = orders.Where(o => o.HeatingDevice.ToLower().Contains(searchString.ToLower())).ToList();
            }
            return this.View(orders);
        }
        public ActionResult Create(int heatingDeviceId, int quantity)
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = this._context.Users.SingleOrDefault(u => u.Id == userId);
            var heatingDevice = this._context.HeatingDevices.SingleOrDefault(x => x.Id == heatingDeviceId);

            if (user == null || heatingDevice == null || heatingDevice.Quantity < quantity)
            {
                return this.RedirectToAction("Index", "Heating Device");
            }
            OrderConfirmVM orderForDb = new OrderConfirmVM
            {
                UserId = userId,
                User = user.UserName,
                HeatingDeviceId = heatingDeviceId,
                HeatingDeviceName = heatingDevice.HeatingDeviceName,
                Picture = heatingDevice.Picture,
                Quantity = quantity,
                Description = heatingDevice.Description,
                Price = heatingDevice.Price,
                Discount = heatingDevice.Discount,
                TotalPrice = quantity * heatingDevice.Price - quantity * heatingDevice.Price * heatingDevice.Discount / 100
            };
            return View(orderForDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderConfirmVM bindingModel)
        {
            if (ModelState.IsValid)
            {
                string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = this._context.Users.SingleOrDefault(u => u.Id == userId);
                var heatingDevice = this._context.HeatingDevices.SingleOrDefault(x => x.Id == bindingModel.HeatingDeviceId);

                if (user == null || heatingDevice == null || heatingDevice.Quantity < bindingModel.Quantity || bindingModel.Quantity == 0)
                {
                    return this.RedirectToAction("Index", "Heating Device");
                }
                Order orderForDb = new Order
                {
                    OrderDate = DateTime.UtcNow,
                    HeatingDeviceId = bindingModel.HeatingDeviceId,
                    UserId = userId,
                    Quantity = bindingModel.Quantity,
                    Price = heatingDevice.Price,
                    Discount = heatingDevice.Discount,
                };
                heatingDevice.Quantity -= bindingModel.Quantity;
                this._context.HeatingDevices.Update(heatingDevice);
                this._context.Orders.Add(orderForDb);
                this._context.SaveChanges();
            }
                return RedirectToAction("OrderSuccess");
        }
        public ActionResult OrderSuccess()
        { return View(); }
    }
}
