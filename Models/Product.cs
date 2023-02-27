using System.ComponentModel.DataAnnotations;

namespace MVCHOT2.Models
{
    public class Product
    {

        public int ProductID { get; set; }

        [Required (ErrorMessage = "Please enter a name")]
        public string ProductName { get; set; } = string.Empty;

        public string? ProductDescShort { get; set; } = string.Empty;

        public string? ProductDescLong { get; set; } = string.Empty;

        [Required (ErrorMessage ="Please enter an image")]
        public string ProductImage { get; set; } = string.Empty;

        [Required (ErrorMessage ="Please enter a price")]
        [Range(1, 100000, ErrorMessage = "Price must be between 1 and 100000")]
        public decimal ProductPrice { get; set; }
		[Required(ErrorMessage = "Please enter a quantity")]
		[Range(1, 1000, ErrorMessage = "Price must be between 1 and 100000")]
		public int ProductQty { get; set; }

        public int? CategoryID { get; set; }
    
    }
}
