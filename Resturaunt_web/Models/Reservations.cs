using System.ComponentModel.DataAnnotations;

namespace Resturaunt_web.Models
{
    public class Reservations
    {
        [Key]
        public int ?Id { get; set; }
        public string Name { get; set; }
        public int ?NumPeople { get; set; }
        public int Time { get; set; }
        public System.DateTime Date { get; set; }
        public int Cost { get; set; }
        public int OrderId { get; set; }
        public Reservations()
        {

        }
    }
}
