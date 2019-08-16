using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab18CoffeeShop.Controllers
{
    public class RegisterUserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Register newRegister)
        {
            return RedirectToAction("Welcome", newRegister);
        }

        public IActionResult Welcome(Register register)
        {
            return View(register);
        }
    }
}