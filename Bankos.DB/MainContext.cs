using Bankos.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.DB
{
    public class MainContext : BankosContext
    {
        public MainContext() : base() { }

        public MainContext(DbContextOptions<BankosContext> options) : base(options) { }
    }
}
