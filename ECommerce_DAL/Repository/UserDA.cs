using ECommerce_DAL.Interfaces;
using ECommerce_EntityL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_DAL.Implementations
{
    public class UserDA : ICrudRepository<User>
    {
        private readonly AppDbContext _dbContext;

        public UserDA(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User Save(User entity)
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}