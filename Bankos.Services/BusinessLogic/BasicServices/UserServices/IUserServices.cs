using Bankos.Services.DTO;
using Bankos.Services.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.BusinessLogic.BasicServices.UserServices
{
    public interface IUserServices
    {
        Task<BaseResponseModel> RegisterUser(UserRegisterDTO newUser);
    }
}
