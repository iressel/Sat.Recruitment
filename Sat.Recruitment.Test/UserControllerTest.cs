using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Sat.Recruitment.Api.Controllers;
using Sat.Recruitment.Global.Enums;
using Sat.Recruitment.Global.Requests;
using Sat.Recruitment.Global.Responses;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sat.Recruitment.Test
{
    [CollectionDefinition("Tests", DisableParallelization = true)]
    public class UserControllerTest
    {
        private readonly UsersController _userController;

        public UserControllerTest()
        {

        }

        [Fact]
        public async Task CreateUserOk()
        {
            var response = await _userController.CreateUser(new UserRequest
            {
                Name = "iressel",
                Email = "ismainressel@gmail.com",
                Address = "Harosteguy 225",
                Phone = "+542920403645",
                UserType = UserType.Normal,
                Money = 116
            });

            var okResult = response as ObjectResult;

            Assert.NotNull(okResult);
            Assert.True(okResult is ObjectResult);
            Assert.IsType<UserRequest>(okResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task CreateUserBadRequest()
        {
            await _userController.CreateUser(new UserRequest
            {
                Name = "fchavez",
                Email = "fiorellapalacioschavez@gmail.com",
                Address = "Harosteguy 225",
                Phone = "+51981082583",
                UserType = UserType.Normal,
                Money = 116
            });

            var response = await _userController.CreateUser(new UserRequest
            {
                Name = "mromero",
                Email = "ismainressel@gmail.com",
                Address = "calle 45 763/2",
                Phone = "+542920403645",
                UserType = UserType.Normal,
                Money = 116
            });

            var result = response as ObjectResult;

            Assert.NotNull(result);
            Assert.True(result is ObjectResult);
            Assert.Equal(StatusCodes.Status500InternalServerError, result.StatusCode);
        }
    }
}
