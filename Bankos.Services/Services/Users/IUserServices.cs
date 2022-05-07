using Bankos.Services.DTOs.Response;
using Bankos.Services.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Services.Users
{
    public interface IUserServices
    {
        Task<ResponseModel> RegisterUser(UserRegisterDTO newUser);
    }
}
