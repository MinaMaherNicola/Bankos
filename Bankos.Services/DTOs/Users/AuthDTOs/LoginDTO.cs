using Bankos.DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.DTOs.Users.AuthDTOs
{
    public class LoginDTO
    {
        [MaxLength(255)]
        public string FullName { get; set; } = null!;
        public string Token { get; set; } = null!;
        public DateTime? ExpiresOn { get; set; } = null!;
    }
}
