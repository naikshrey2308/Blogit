using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public class SQLUserBlogRepository : IUserBlogRepository
    {
        private readonly AppDbContext context;

        public SQLUserBlogRepository(AppDbContext context)
        {
            this.context = context;
        }

        UserBlog IUserBlogRepository.Add(UserBlog UserBlog) {
            context.UserBlogs.Add(UserBlog);
            context.SaveChanges();
            return UserBlog;
        }

        internal void Add(UserBlog saveBlog)
        {
            throw new NotImplementedException();
        }
    }
}
