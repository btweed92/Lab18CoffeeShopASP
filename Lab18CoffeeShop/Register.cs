using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18CoffeeShop
{
    public class Register
    {
        [Required(ErrorMessage = "Please enter a valid username!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter a valid email!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a valid password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter a first name!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please select a favorite drink!")]
        public string FavoriteDrink { get; set; }
    }
    public enum FavoriteDrink
    {
        Coffee,
        Latte,
        Tea        
    }
}
