using ECommerce_EntityL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_DAL.IServices
{
    public interface ICategory
    {
        public IQueryable<Category> GetAll();
    }
}
