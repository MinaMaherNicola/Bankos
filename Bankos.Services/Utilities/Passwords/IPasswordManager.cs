using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Utilities.Passwords
{
    public interface IPasswordManager
    {
        string GeneratePassword(string plainPassword);
        bool VerifyPassword(string enteredPassword, string passwordHash);
    }
}
