using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public class SQLBlogRepository : IBlogRepository
    {
        private readonly AppDbContext context;

        public SQLBlogRepository(AppDbContext context) {
            this.context = context;
        }

        Blog IBlogRepository.Add(Blog blog) {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return blog;
        }

        Blog IBlogRepository.Delete(int Id)
        {
            Blog blog = context.Blogs.Find(Id);
            if (blog != null)
            {
                context.Blogs.Remove(blog);
                context.SaveChanges();
            }
            return blog;
        }

        IEnumerable<Blog> IBlogRepository.GetAllBlogs()
        {
            /*Console.WriteLine(context.Blogs);
            Console.ReadLine();*/
            // context.Blogs.Include(b => b.Author);
            return context.Blogs.Include(b => b.Author);
        }

        Blog IBlogRepository.GetBlog(int Id)
        {
            return context.Blogs.FirstOrDefault(b => b.Id == Id);
        }

        
    }
}
