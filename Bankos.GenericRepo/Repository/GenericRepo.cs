using Bankos.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.GenericRepo.Repository
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        private readonly BankosContext _context;
        private readonly DbSet<TEntity> _set;
        public GenericRepo(BankosContext context)
        {
            _context = context;
            _set = _context.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            return (await _set.AddAsync(entity)).Entity;
        }

        public async Task<IEnumerable<TEntity>> AddRange(IEnumerable<TEntity> entities)
        {
            await _set.AddRangeAsync(entities);
            return entities;
        }

        public async Task<TEntity?> GetById(int id)
        {
            return await _set.FindAsync(id);
        }
    }
}
