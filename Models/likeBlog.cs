namespace BlogIt.Models
{
    public class likeBlog
    {
        public int BlogId { get; set; }
        public int UserId { get; set; }
        public Blog blog { get; set; }

        public User user { get; set; }
    }
}
