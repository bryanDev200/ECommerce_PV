using ECommerce_DAL.IServices;
using ECommerce_EntityL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_DAL.SercvicesImpl
{
    public class CategoryDA:ICategory
    {
        private readonly AppDbContext _dbContext;

        public CategoryDA(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IQueryable<Category> GetAll()
        {
            IQueryable<Category> category = _dbContext.Categories;
            return category;
        }
    }
}

