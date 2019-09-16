using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;

namespace Jessica_Rules.Controllers
{
    public class AngelsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(FormPost form)
        {
            
            //
            return RedirectToAction("Edit", form);
        }

        public IActionResult Edit(FormPost form)
        {
            ViewData["Name"] = form.Name;
            ViewData["Email"] = form.Email;
            ViewData["Subject"] = form.Subject;
            ViewData["Body"] = form.Body;

            return View();
        }
    }

    public class FormPost
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}