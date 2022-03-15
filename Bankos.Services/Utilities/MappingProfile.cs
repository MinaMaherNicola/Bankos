using AutoMapper;
using Bankos.DataAccessLayer.Models;
using Bankos.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserRegisterDTO>().ReverseMap();
        }
    }
}
