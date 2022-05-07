using Bankos.DB.Models;
using Bankos.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.UnitofWork.UoF
{
    public interface IUnitofWork
    {
        IBankosRepository<User> UsersRepository { get; }
        IBankosRepository<Transaction> TransactionsRepository { get; }
        Task<int> SaveChanges();
    }
}
