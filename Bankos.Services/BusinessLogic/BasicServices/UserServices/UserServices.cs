using AutoMapper;
using Bankos.DataAccessLayer.Models;
using Bankos.Services.DTOs.UserDTOs;
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

        public async Task<GenericResponseModel<string>> LoginUser(UserLoginDTO user)
        {
            var response = new GenericResponseModel<string>();

            var savedUserData = await unitofWork.UsersRepository.FirstOrDefault(u => u.Email == user.Email);
            if (savedUserData == null)
            {
                response.GenerateFailure("Wrong email or password!");
                return response;
            }
            if (!(PasswordManager.VerifyIncomingPassword(user.Password, savedUserData.Password)))
            {
                response.GenerateFailure("Wrong email or password!");
                return response;
            }
            response.GenerateSuccess("JWT Token here");
            return response;
        }

        public async Task<BaseResponseModel> RegisterUser(UserRegisterDTO newUser)
        {
            var response = new BaseResponseModel();
            newUser.Password = PasswordManager.HashPassword(newUser.Password);
            await unitofWork.UsersRepository.Add(mapper.Map<User>(newUser));
            await unitofWork.SaveChanges();
            return response;
        }
    }
}
