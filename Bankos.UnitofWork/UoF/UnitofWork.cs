using Bankos.DB;
using Bankos.DB.Models;
using Bankos.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.UnitofWork.UoF
{
    public class UnitofWork : IUnitofWork, IAsyncDisposable
    {
        private readonly MainContext _context;

        public IBankosRepository<User> UsersRepository { get; }

        public IBankosRepository<Transaction> TransactionsRepository { get; }

        public UnitofWork(
            MainContext context,
            IBankosRepository<User> usersRepository,
            IBankosRepository<Transaction> transactionsRepository
            )
        {
            _context = context;
            UsersRepository = usersRepository;
            TransactionsRepository = transactionsRepository;
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
            GC.SuppressFinalize(this);
        }
    }
}
