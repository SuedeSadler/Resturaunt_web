﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturaunt_web.Models
{
    public class SignUp
    {
        public int ID { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public int PhoneNO { get; set; }
        public string Password { get; set; }
    }
}