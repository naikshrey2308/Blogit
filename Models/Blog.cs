using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required][ForeignKey("AuthorId")]
        public User Author { get; set; }
        
        [Required]
        public string Title { get; set; }

        public string TitleImageUrl { get; set; }

        [Required]
        public string DateTime { get; set; }

        [Required]
        public string Content { get; set; }

        public bool Published { get; set; }

        [ForeignKey("CategoryId")]
        public Category category { get; set; }

        public int views { get; set; }

        public ICollection<UserBlog> SavedBlogs { get; set; }

        public ICollection<likeBlog> likeBlogs { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
