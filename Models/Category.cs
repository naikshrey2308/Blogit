using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogIt.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string type { get; set; }
    }
}
