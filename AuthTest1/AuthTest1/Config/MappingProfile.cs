using AuthTest.Core.DTO.User;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTest.API.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IdentityUser, UserInfoDto>()
                .ForMember(x => x.userName, y => y.MapFrom(z => z.UserName))
                .ForMember(x=>x.id, y=>y.MapFrom(z=>z.Id))
                ;
        }
    }
}
