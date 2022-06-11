using Bankos.DB;
using Bankos.DB.Models;
using Bankos.GenericRepo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.UnitofWork.UoF
{
    public class UnitofWork : IUnitofWork
    {
        private readonly BankosContext _context;
        public IGenericRepo<Account> AccountRepository { get; }
        public IGenericRepo<AccountType> AccountTypeRepository { get; }

        public IGenericRepo<User> UserRepository { get; }

        public UnitofWork(BankosContext context,
                          IGenericRepo<Account> accountRepository,
                          IGenericRepo<AccountType> accountTypeRepository,
                          IGenericRepo<User> userRepository)
        {
            _context = context;
            AccountRepository = accountRepository;
            AccountTypeRepository = accountTypeRepository;
            UserRepository = userRepository;
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
            GC.SuppressFinalize(this);
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
