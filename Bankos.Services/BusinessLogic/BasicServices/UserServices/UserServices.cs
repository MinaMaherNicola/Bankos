using AutoMapper;
using Bankos.DataAccessLayer.Models;
using Bankos.Services.DTO;
using Bankos.Services.Response;
using Bankos.Services.Utilities;
using Bankos.UnitofWork.UOF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.BusinessLogic.BasicServices.UserServices
{
    public class UserServices : IUserServices
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;
        public UserServices(IUnitofWork unitofWork, IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }
        public async Task<BaseResponseModel> RegisterUser(UserRegisterDTO newUser)
        {
            var response = new BaseResponseModel();
            try
            {
                newUser.Password = PasswordManager.HashPassword(newUser.Password);
                await unitofWork.UsersRepository.Add(mapper.Map<User>(newUser));
                await unitofWork.SaveChanges();
            }
            catch(Exception ex)
            {
                response.GenerateFailure(ex.Message);
            }
            return response;
        }
    }
}
