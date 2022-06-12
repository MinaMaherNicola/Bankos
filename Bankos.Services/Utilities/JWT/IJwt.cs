using Bankos.DB.Models;
using Bankos.DB.Responses;
using Bankos.Services.DTOs.Users.AuthDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Utilities.JWT
{
    public interface IJwt
    {
        GenericResponseModel<LoginDTO> CreateUserToken(User user);
    }
}
