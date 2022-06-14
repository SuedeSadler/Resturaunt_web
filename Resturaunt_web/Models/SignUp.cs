using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Resturaunt_web.Models
{
    public class SignUp
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name..")]
        [Display(Name = "Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter a Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pwd { get; set; }

        [Required(ErrorMessage = "Please Confirm Your Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Pwd")]
        public string Confirmpwd { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email...")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNO { get; set; }
    }
}
