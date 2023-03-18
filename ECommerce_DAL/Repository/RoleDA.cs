using ECommerce_DAL.IServices;
using ECommerce_EntityL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_DAL.SercvicesImpl
{
    public class RoleDA : IRole
    {
        private readonly AppDbContext _dbContext;

        public RoleDA(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public IQueryable<Role> GetAll()
        {
            IQueryable<Role> role = _dbContext.Roles;
            return role;
        }
    }
}
