using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public class UserBlog
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
