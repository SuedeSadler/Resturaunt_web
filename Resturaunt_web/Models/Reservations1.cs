using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Resturaunt_web.Models
{
    public class Reservations1
    {
        [Key]
        public int ?Reservation_Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        [DisplayName("Party size?")]
        public int ?NumPeople { get; set; }
        [DisplayName("Reservation Date")]
        [BindProperty, DataType(DataType.Date)]
        public System.DateTime Booked_time { get; set; }
        public Reservations1()
        {
          
        }
    }
}
