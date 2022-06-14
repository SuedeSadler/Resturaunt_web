using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace Resturaunt_web.Models
{

    public class Login
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
