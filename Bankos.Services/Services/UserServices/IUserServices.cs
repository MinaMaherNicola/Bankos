using Bankos.DB.Responses;
using Bankos.Services.DTOs.Users.AuthDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Services.UserServices
{
    public interface IUserServices
    {
        Task<GenericResponseModel<LoginSuccessDTO>> RegisterNewUser(RegisterDTO newUser);
    }
}
