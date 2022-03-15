using Bankos.DataAccessLayer.Models;
using Bankos.GenericRepository.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.UnitofWork.UOF
{
    public interface IUnitofWork : IAsyncDisposable
    {
        Task<int> SaveChanges();

        IGenericRepository<User> UsersRepository { get; }
    }
}
