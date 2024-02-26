using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models{
    public class Product {

        [Display(Name="Urun Id")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name="Urun Adi")]

        public string? Name { get; set; } 

        [Required(ErrorMessage = "You have to write price bigger than 0")]
        [Range(0, 100000)]
        [Display(Name="Price")]

        public decimal? Price { get; set; }


        [Display(Name="Image")]

        public string? Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [Display(Name="Category")]
        [Required]

        public int? CategoryId { get; set; }

    }
}