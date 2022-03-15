using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.GenericRepository.Repo
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);
    }
}
