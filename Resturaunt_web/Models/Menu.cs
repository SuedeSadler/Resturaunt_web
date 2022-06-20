using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace Resturaunt_web.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string FoodType { get; set; }
        public int Price { get; set; }

        [NotMapped]
        [DisplayName("Upload an Image of Item")]
        public IFormFile ImageFile { get; set; }
    }
}
