using Bankos.DataAccessLayer.Models;
using Bankos.GenericRepository.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.UnitofWork.UOF
{
    public class UnitofWork : IUnitofWork
    {
        private readonly BankosContext context;
        public IGenericRepository<User> UsersRepository { get; set; }

        public UnitofWork(IGenericRepository<User> usersRepository, BankosContext context)
        {
            UsersRepository = usersRepository;
            this.context = context;
        }

        public async Task<int> SaveChanges()
        {
            try
            {
                return (await context.SaveChangesAsync());
            }
            catch
            {
                throw;
            }
        }

        public async ValueTask DisposeAsync()
        {
            try
            {
                await context.DisposeAsync();
                GC.SuppressFinalize(this);
            }
            catch
            {
                throw;
            }
        }
    }
}
