using System.ComponentModel.DataAnnotations;

namespace web_test_app.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A Field 'Name' must be filled")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
