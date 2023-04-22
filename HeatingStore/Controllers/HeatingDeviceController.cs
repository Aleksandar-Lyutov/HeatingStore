using HeatingStore.Abstraction;
using HeatingStore.Domain;
using HeatingStore.Models.Category;
using HeatingStore.Models.HeatingDevice;
using HeatingStore.Models.Manufacturer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Controllers
{

    [Authorize(Roles = "Administrator")]
    public class HeatingDeviceController : Controller
    {
        private readonly IHeatingDeviceService _heatingDeviceService;
        private readonly ICategoryService _categoryService;
        private readonly IManufacturerService _manufacturerService;
        public HeatingDeviceController(IHeatingDeviceService heatingDeviceService, ICategoryService categoryService, IManufacturerService manufacturerService)
        {
            this._heatingDeviceService = heatingDeviceService;
            this._categoryService = categoryService;
            this._manufacturerService = manufacturerService;
        }
        public ActionResult Create()
        {
            var heatingDevice = new HeatingDeviceCreateVM();
            heatingDevice.Manufacturers = _manufacturerService.GetManufacturers()
                .Select(x => new ManufacturerPairVM()
                {
                    Id = x.Id,
                    Name = x.ManufacturerName
                }).ToList();
            heatingDevice.Categories = _categoryService.GetCategories()
                .Select(x => new CategoryPairVM()
                {
                    Id = x.Id,
                    Name = x.CategoryName
                }).ToList();
            return View(heatingDevice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] HeatingDeviceCreateVM heatingDevice)
        {
            if (ModelState.IsValid)
            {
                var createdId = _heatingDeviceService.Create(heatingDevice.HeatingDeviceName, heatingDevice.ManufacturerId, heatingDevice.CategoryId, heatingDevice.Picture, heatingDevice.Quantity, heatingDevice.Description, heatingDevice.Price, heatingDevice.Discount);
                if (createdId)
                {
                    return this.RedirectToAction("CreateSuccess");
                }
            }
            return View();

        }
        [AllowAnonymous]
        public ActionResult Index(string searchStringCategoryName, string searchStringManufacturerName, string searchStringHeatingDeviceName)
        {
            List<HeatingDeviceIndexVM> heatingDevices = _heatingDeviceService.GetHeatingDevices(searchStringCategoryName, searchStringManufacturerName, searchStringHeatingDeviceName)
            .Select(heatingDevice => new HeatingDeviceIndexVM
            {
                Id = heatingDevice.Id,
                HeatingDeviceName = heatingDevice.HeatingDeviceName,
                ManufacturerId = heatingDevice.ManufacturerId,
                ManufacturerName = heatingDevice.Manufacturer.ManufacturerName,
                CategoryId = heatingDevice.CategoryId,
                CategoryName = heatingDevice.Category.CategoryName,
                Picture = heatingDevice.Picture,
                Quantity = heatingDevice.Quantity,
                Description = heatingDevice.Description,
                Price = heatingDevice.Price,
                Discount = heatingDevice.Discount
            }).ToList();
            return this.View(heatingDevices);
        }
        public ActionResult Edit(int id)
        {
            HeatingDevice heatingDevice = _heatingDeviceService.GetHeatingDeviceById(id);
            if (heatingDevice == null)
            { return NotFound(); }

            HeatingDeviceEditVM updatedHeatingDevice = new HeatingDeviceEditVM()
            {
                Id = heatingDevice.Id,
                HeatingDeviceName = heatingDevice.HeatingDeviceName,
                ManufacturerId = heatingDevice.ManufacturerId,
                CategoryId = heatingDevice.CategoryId,
                Picture = heatingDevice.Picture,
                Quantity = heatingDevice.Quantity,
                Description = heatingDevice.Description,
                Price = heatingDevice.Price,
                Discount = heatingDevice.Discount
            };

            updatedHeatingDevice.Manufacturers = _manufacturerService.GetManufacturers()
                .Select(b => new ManufacturerPairVM()
                {
                    Id = b.Id,
                    Name = b.ManufacturerName
                }).ToList();

            updatedHeatingDevice.Categories = _categoryService.GetCategories()
                .Select(c => new CategoryPairVM()
                {
                    Id = c.Id,
                    Name = c.CategoryName
                }).ToList();
            return View(updatedHeatingDevice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, HeatingDeviceEditVM heatingDevice)
        {
            if (ModelState.IsValid)
            {
                var updated = _heatingDeviceService.Update(id, heatingDevice.HeatingDeviceName, heatingDevice.ManufacturerId,
                    heatingDevice.CategoryId, heatingDevice.Picture, heatingDevice.Quantity, heatingDevice.Description,
                    heatingDevice.Price, heatingDevice.Discount);

                if (updated)
                {
                    return this.RedirectToAction("Index");
                }
            }
            return View(heatingDevice);
        }
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            HeatingDevice item = _heatingDeviceService.GetHeatingDeviceById(id);
            if (item == null)
            {
                return NotFound();
            }
            HeatingDeviceDetailsVM heatingDevice = new HeatingDeviceDetailsVM()
            {
                Id = item.Id,
                HeatingDeviceName = item.HeatingDeviceName,
                ManufacturerId = item.ManufacturerId,
                ManufacturerName = item.Manufacturer.ManufacturerName,
                CategoryId = item.CategoryId,
                CategoryName = item.Category.CategoryName,
                Picture = item.Picture,
                Quantity = item.Quantity,
                Description = item.Description,
                Price = item.Price,
                Discount = item.Discount
            };
            return View(heatingDevice);
        }
        public ActionResult Delete(int id)
        {
            HeatingDevice heatingDevice = _heatingDeviceService.GetHeatingDeviceById(id);
            if (heatingDevice == null)
            { return NotFound(); }

            HeatingDeviceDeleteVM heatingDeviceDelete = new HeatingDeviceDeleteVM()
            {
                Id = heatingDevice.Id,
                HeatingDeviceName = heatingDevice.HeatingDeviceName,
                ManufacturerId = heatingDevice.ManufacturerId,
                ManufacturerName = heatingDevice.Manufacturer.ManufacturerName,
                CategoryId = heatingDevice.CategoryId,
                CategoryName = heatingDevice.Category.CategoryName,
                Picture = heatingDevice.Picture,
                Quantity = heatingDevice.Quantity,
                Description = heatingDevice.Description,
                Price = heatingDevice.Price,
                Discount = heatingDevice.Discount
            };
            return View(heatingDeviceDelete);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleted = _heatingDeviceService.RemoveById(id);
            if (deleted)
            {
                return this.RedirectToAction("DeleteSuccess");
            }
            else { return View(); }
        }
        public IActionResult CreateSuccess()
        { return this.View(); }
        public IActionResult DeleteSuccess()
        { return this.View(); }
    }
}
