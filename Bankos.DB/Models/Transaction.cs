using System;
using System.Collections.Generic;

namespace Bankos.DB.Models
{
    public partial class Transaction
    {
        public Guid Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public decimal TransactionAmount { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual User Receiver { get; set; } = null!;
        public virtual User Sender { get; set; } = null!;
    }
}
