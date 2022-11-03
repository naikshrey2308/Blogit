using System;
using System.ComponentModel.DataAnnotations;

namespace BlogIt.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public int BlogId { get; set; }
        public Blog blog { get; set; }
        public User user { get; set; }
        public DateTime dateTime { get; set; }


    }
}
