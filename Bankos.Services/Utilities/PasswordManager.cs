﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Utilities
{
    public static class PasswordManager
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyIncomingPassword(string incomingPassword, string storedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(incomingPassword, storedPassword);
        }
    }
}
