using Bankos.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.GenericRepository.Repo
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly BankosContext context;
        private readonly DbSet<TEntity> dbSet;
        public GenericRepository(BankosContext context)
        {
            this.context = context;
            dbSet = this.context.Set<TEntity>();
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            try
            {
                return (await dbSet.AddAsync(entity)).Entity;
            }
            catch
            {
                throw;
            }
        }

        public async Task<TEntity?> FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }
    }
}
