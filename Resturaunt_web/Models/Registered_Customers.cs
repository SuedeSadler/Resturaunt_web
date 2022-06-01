using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resturaunt_web.Models
{
    public class Registered_Customers
    {
        [Key]
        public int ?CustomerID { get; set; }
        [StringLength(100)]
        [Column(TypeName ="varchar(100)")]
        public string CustomerName { get; set; }
        [StringLength (50)]
        [Column(TypeName ="varchar(50)")]
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
