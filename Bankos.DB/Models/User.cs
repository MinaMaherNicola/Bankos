using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.DB.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [MaxLength(255)]
        public string FullName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime? LastLogin { get; set; }
        public virtual ICollection<Account>? Accounts { get; set; }

    }
}
