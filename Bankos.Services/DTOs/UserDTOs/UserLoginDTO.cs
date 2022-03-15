using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.DTOs.UserDTOs
{
    public class UserLoginDTO
    {
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
