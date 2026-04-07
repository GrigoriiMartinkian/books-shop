using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        [Display(Name = "Title")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Please enter an author")]
        [Display(Name = "Author")]
        public string Author { get; set; } = "";

        [Required]
        [Display(Name = "Price")]
        [Range(0, 100000)]
        public decimal Price { get; set; }

        [Display(Name = "Genre")]
        public string Genre { get; set; } = "";

        [Display(Name = "Description")]
        public string Description { get; set; } = "";

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = "";

        [Display(Name = "In Stock")]
        public int Stock { get; set; } = 0;
    }
}