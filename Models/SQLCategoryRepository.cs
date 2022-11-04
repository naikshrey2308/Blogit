using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlogIt.Models
{
    public class SQLCategoryRepository
    {
        private readonly AppDbContext context ;

        public SQLCategoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return context.Categories;
        }

        public Category GetCategory(int Id)
        {
            return context.Categories.FirstOrDefault(m => m.Id == Id );
        }
    }
}
