using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.DTOs.Users
{
    public class UserRegisterDTO
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public decimal? Balance { get; set; } = null;
    }
}
