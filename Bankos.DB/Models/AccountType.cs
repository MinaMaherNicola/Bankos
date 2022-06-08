using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.DB.Models
{
    public class AccountType
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Interest { get; set; }
        public bool Subscribable { get; set; }
    }
}
