using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_DAL.Interfaces
{
    public interface ICrudRepository<T>
    {
        public T Save(T entity);
        public int Delete(int id);
        public T Update(T entity);
        public IQueryable<T> GetAll();
        public T FindById(int id);
    }
}