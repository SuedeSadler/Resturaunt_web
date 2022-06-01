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
        public int ?NumPeople { get; set; }
        public System.DateTime Booked_time { get; set; }
        public Reservations1()
        {

        }
    }
}
