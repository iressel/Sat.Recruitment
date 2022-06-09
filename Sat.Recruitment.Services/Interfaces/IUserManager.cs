using Sat.Recruitment.Global.Requests;
using Sat.Recruitment.Global.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Services.Interfaces
{
    public interface IUserManager
    {
        Task<UserResponse> CreateUser(UserRequest userRequest);
    }
}
