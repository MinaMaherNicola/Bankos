using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.DTO
{
    public class UserRegisterDTO
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        private string password = null!;

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length < 8)
                {
                    throw new Exception("Password is too short!");
                }
                else
                {
                    password = value;
                }
            }
        }
    }
}
