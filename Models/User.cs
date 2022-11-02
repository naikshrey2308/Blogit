using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public String Name { get; set; }

        [Required][EmailAddress]
        public String Email { get; set; }

        [Required]
        public String Password { get; set; }

        public String ProfilePicUrl { get; set; }

        public ICollection<UserBlog> SavedBlogs { get; set; }
    }
}
