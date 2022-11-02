using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public interface IBlogRepository
    {
        Blog GetBlog(int Id);
        Blog Add(Blog blog);
        IEnumerable<Blog> GetAllBlogs();
        Blog Delete(int Id);

    }
}
