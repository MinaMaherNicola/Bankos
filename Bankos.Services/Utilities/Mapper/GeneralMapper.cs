using AutoMapper;
using Bankos.DB.Models;
using Bankos.Services.DTOs.Users.AuthDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Utilities.Mapper
{
    public class GeneralMapper : Profile
    {
        public GeneralMapper()
        {
            CreateMap<User, RegisterDTO>().ReverseMap();
            CreateMap<LoginSuccessDTO, TokenDTO>().ReverseMap();
        }
    }
}
