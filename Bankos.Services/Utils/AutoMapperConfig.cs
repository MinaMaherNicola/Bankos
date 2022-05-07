using AutoMapper;
using Bankos.DB.Models;
using Bankos.Services.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Utils
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserRegisterDTO>().ReverseMap();
        }
    }
}
