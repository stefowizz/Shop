using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shop.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Full Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters only")]
        public string? Name { get; set; }


        [DisplayName("Brand Name")]
        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only")]
        public string? Brand { get; set; }

        
    }
}
