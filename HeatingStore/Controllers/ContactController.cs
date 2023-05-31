using HeatingStore.Data;
using HeatingStore.Domain;
using HeatingStore.Models.Contact;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult ContactUs()
        {
            var message = new ContactMessageVM();
            return View(message);
        }
        [HttpPost]
        public ActionResult ContactUs(ContactMessageVM model)
        {
            if (ModelState.IsValid)
            {
                var sentMessage = new ContactMessageVM
                {
                    Comment = model.Comment,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                };
                _context.ContactMessages.Add(sentMessage);
                _context.SaveChanges();

                return this.RedirectToAction("ThankYou");
            }
            return View();
        }
        public async Task<IActionResult> Index()
        {
            var messages = await _context.ContactMessages.ToListAsync();
            return View(messages);
        }
    }
}
