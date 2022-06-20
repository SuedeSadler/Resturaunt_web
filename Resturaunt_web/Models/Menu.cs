using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace Resturaunt_web.Models
{
    public class Menu
    {
        [Key]
        [Required]
        public int MenuId { get; set; }
        
        public string Image { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string FoodType { get; set; }
        [Required]
        public int Price { get; set; }

        [NotMapped]
        [DisplayName("Upload an Image of Item")]
        public IFormFile ImageFile { get; set; }
    }
}
