using Bankos.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.DB
{
    public class BankosContext : DbContext
    {
        public BankosContext(DbContextOptions<BankosContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
    }
}
