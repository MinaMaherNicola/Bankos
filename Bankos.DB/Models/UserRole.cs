using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.DB.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; } = null!;
        public string NormalizedRoleName { get; set; } = null!;
        public virtual ICollection<User>? Users { get; set; }
    }
}
