using System;
using System.Collections.Generic;

namespace Bankos.DB.Models
{
    public partial class User
    {
        public User()
        {
            TransactionReceivers = new HashSet<Transaction>();
            TransactionSenders = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public decimal Balance { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Transaction> TransactionReceivers { get; set; }
        public virtual ICollection<Transaction> TransactionSenders { get; set; }
    }
}
