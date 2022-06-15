using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.DTOs.Users.AuthDTOs
{
    public class TokenDTO
    {
        public string Token { get; set; } = null!;
        public DateTime? ExpiresOn { get; set; } = null!;
    }
}
