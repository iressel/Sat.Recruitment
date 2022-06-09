using AutoMapper;
using Sat.Recruitment.Model.DB.Tables;
using Sat.Recruitment.Global.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using Sat.Recruitment.Global.Requests;

namespace Sat.Recruitment.Services.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile() 
        {
            CreateMaps();
        }

        public void CreateMaps() 
        {
            // Users config
            CreateMap<User, UserResponse>();
            CreateMap<UserRequest, User>();
            CreateMap<UserRequest, UserResponse>();
        }
    }
}
