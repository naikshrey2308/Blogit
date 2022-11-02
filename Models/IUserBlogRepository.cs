using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public interface IUserBlogRepository
    {
        public UserBlog Add(UserBlog userBlog);
    }
}
