using Bankos.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Repository.Repository
{
    public class BankosRepository<TEntity> : IBankosRepository<TEntity> where TEntity : class
    {
        private readonly MainContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public BankosRepository(MainContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            try
            {
                return (await _dbSet.AddAsync(entity)).Entity;
            }
            catch
            {
                throw;
            }
        }
    }
}
