using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public class SQLUserBlogRepository
    {
        private readonly AppDbContext context;

        public SQLUserBlogRepository(AppDbContext context)
        {
            this.context = context;
        }

        public UserBlog Add(UserBlog UserBlog) {
            /*Console.WriteLine("hello" + UserBlog.Blog.Author.Name);*/
            context.UserBlogs.Add(UserBlog);
            context.SaveChanges();
            return UserBlog;
        }

        public IEnumerable<UserBlog>  GetAllSavedBlogs()
        {
            return context.UserBlogs.Include(b => b.Blog).Include(bc => bc.Blog.Author);
        }

        public UserBlog GetUserBlog(int userid,int blogid)
        {
            return context.UserBlogs.FirstOrDefault(m => m.UserId == userid && m.BlogId==blogid);
        }


    }
}
