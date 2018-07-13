using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogSite.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogSite.Service.Categories
{
    public class CategoryRepository : GenericRepository<Category>,ICategoryRepository

    {
        public CategoryRepository(BlogContext dbContext)
        : base(dbContext)
        {
         
        }
    }
}
