using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.DB.Models
{
    public class Account
    {
        public Guid Id { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Balance { get; set; }
        public int Type { get; set; }
        public Guid UserId { get; set; }

        [ForeignKey(nameof(Type))]
        public virtual AccountType AccountType { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;
    }
}
