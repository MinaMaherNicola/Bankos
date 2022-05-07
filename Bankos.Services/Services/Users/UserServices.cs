using AutoMapper;
using Bankos.DB.Models;
using Bankos.Services.DTOs.Response;
using Bankos.Services.DTOs.Users;
using Bankos.UnitofWork.UoF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Services.Users
{
    public class UserServices : IUserServices
    {
        private readonly IMapper mapper;
        private readonly IUnitofWork unitofWork;
        public UserServices(IMapper mapper, IUnitofWork unitofWork)
        {
            this.mapper = mapper;
            this.unitofWork = unitofWork;
        }

        public async Task<ResponseModel> RegisterUser(UserRegisterDTO newUser)
        {
            var response = new ResponseModel();
            await unitofWork.UsersRepository.Add(mapper.Map<User>(newUser));
            await unitofWork.SaveChanges();
            return response.GenerateSuccess();
        }
    }
}
