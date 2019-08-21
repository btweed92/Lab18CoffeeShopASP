using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab18CoffeeShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab18CoffeeShop.Controllers
{
    public class RegisterUserController : Controller
    {
        List<RegisterUser> newUser = new List<RegisterUser>();

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(RegisterUser newRegister)
        {

            if (ModelState.IsValid)
            {
                string registerUserJson = HttpContext.Session.GetString("UserSession");
                if (registerUserJson != null)
                {
                    newUser = JsonConvert.DeserializeObject<List<RegisterUser>>(registerUserJson);
                }
                newUser.Add(newRegister);
                HttpContext.Session.SetString("UserSession", JsonConvert.SerializeObject(newUser));
                return RedirectToAction("Welcome", newRegister);
                
            }
            else
            {
                return View("ListofUsers");
            }
        }
        public IActionResult ListOfUsers()
        {
            string registerUserJson = HttpContext.Session.GetString("UserSession");
            newUser = JsonConvert.DeserializeObject<List<RegisterUser>>(registerUserJson);

            return View("ListOfUsers", newUser);
        }

        public IActionResult Welcome(RegisterUser user)
        {
                      
                return View(user);
        }
    }
}