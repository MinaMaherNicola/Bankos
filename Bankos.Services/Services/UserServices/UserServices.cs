using AutoMapper;
using Bankos.DB.Models;
using Bankos.DB.Responses;
using Bankos.Services.Constants;
using Bankos.Services.DTOs.Users.AuthDTOs;
using Bankos.Services.Utilities.JWT;
using Bankos.Services.Utilities.Passwords;
using Bankos.UnitofWork.UoF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Services.UserServices
{
    public class UserServices : IUserServices
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;
        private readonly IPasswordManager passwordManager;
        private readonly IJwt jwt;

        public UserServices(IMapper mapper, IUnitofWork unitofWork, IPasswordManager passwordManager, IJwt jwt)
        {
            this.mapper = mapper;
            this.unitofWork = unitofWork;
            this.passwordManager = passwordManager;
            this.jwt = jwt;
        }

        public async Task<GenericResponseModel<LoginSuccessDTO>> RegisterNewUser(RegisterDTO newUser)
        {
            var response = new GenericResponseModel<LoginSuccessDTO>();

            var user = mapper.Map<User>(newUser);
            user.Password = passwordManager.GeneratePassword(user.Password);
            var userRole = await unitofWork.UserRolesRepository.FirstOrDefault(r => r.NormalizedRoleName == UserRolesConstants.UserNormalizedName);
            if (userRole != null)
            {
                user.UserRole = userRole;
            }
            await unitofWork.UserRepository.Add(user);
            await unitofWork.SaveChanges();
            var loginToken = jwt.CreateUserToken(user);
            var loginData = mapper.Map<LoginSuccessDTO>(loginToken);
            loginData.FullName = user.FullName;
            response.GenerateSuccess(loginData);
            return response;
        }
    }
}
