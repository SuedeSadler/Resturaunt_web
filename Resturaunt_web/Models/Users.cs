﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Resturaunt_web.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int? Phone { get; set; }
        public string? Password { get; set; }
        public Users()
        {

        }

    }
}
