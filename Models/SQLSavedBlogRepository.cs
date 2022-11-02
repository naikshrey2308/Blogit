using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public class SQLSavedBlogRepository
    {
        private readonly AppDbContext context;

        public SQLSavedBlogRepository(AppDbContext context)
        {
            this.context = context;
        }

        // public SavedBlog Add(User user, Blog blog)
        // {
        //     SavedBlog savedBlog = new SavedBlog(blog.Id, user.Id,blog,user);
            
        //     context.SavedBlogs.Add(savedBlog);
        //     context.SaveChanges();
        //     return savedBlog;
        // }
    }
}
