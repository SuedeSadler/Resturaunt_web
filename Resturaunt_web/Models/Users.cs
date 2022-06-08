using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Resturaunt_web.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string FName { get; set; }

        public string LName { get; set; }
        public System.DateTime Date { get; set; }
        public int Time { get; set; }
        public int? NumPeople { get; set; }
        

        public string Email { get; set; }
        public int Phone { get; set; }
        public Users()
        {

        }

    }
}
