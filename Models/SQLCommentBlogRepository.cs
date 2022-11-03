namespace BlogIt.Models
{
    public class SQLCommentBlogRepository
    {
        private readonly AppDbContext context;

        public SQLCommentBlogRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Comment Add(Comment obj)
        {
            context.Comments.Add(obj);
            context.SaveChanges();
            return obj;
        }
    }
}
