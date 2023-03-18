using ECommerce_BusinessL.IServices;
using ECommerce_DAL.IServices;
using ECommerce_EntityL.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_BusinessL.IServicesImpl
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategory _categoryService;

        public CategoryService (ICategory categoryService)
        {
           this._categoryService=categoryService;
        }


        public IQueryable<Category> GetAll()
        {
            return _categoryService.GetAll();
        }
    }
}
