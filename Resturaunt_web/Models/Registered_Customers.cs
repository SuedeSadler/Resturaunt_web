using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resturaunt_web.Models
{
    public class Registered_Customers
    {
        [Key]
        public int ?CustomerID { get; set; }
        
        public string CustomerName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int CustomerPhone { get; set; }
        [DataType(DataType.Password)]
        public string CustomerPassword { get; set; }

        public Registered_Customers()
        {

        }

    }
}
