using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sat.Recruitment.Api.Contracts;
using Sat.Recruitment.Global.Exceptions;
using Sat.Recruitment.Global.Requests;
using Sat.Recruitment.Global.Responses;
using Sat.Recruitment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class UsersController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        [Route("/create-user")]
        public async Task<IActionResult> CreateUser(UserRequest request)
        {
            var result = await _userManager.CreateUser(request);
            return result != null
                   ? new WebStandardResponse<UserResponse>(HttpStatusCode.OK, result).Result
                   : new WebStandardResponse<UserResponse>(HttpStatusCode.InternalServerError, result).Result;
        }
    }
}
