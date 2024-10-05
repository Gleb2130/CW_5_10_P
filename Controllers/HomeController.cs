using CW_5_10_P.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CW_5_10_P.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
