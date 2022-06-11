using Bankos.DB.Models;
using Bankos.GenericRepo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.UnitofWork.UoF
{
    public interface IUnitofWork : IAsyncDisposable
    {
        IGenericRepo<Account> AccountRepository { get; }
        IGenericRepo<AccountType> AccountTypeRepository { get; }
        IGenericRepo<User> UserRepository { get; }
        Task<int> SaveChanges();
    }
}
