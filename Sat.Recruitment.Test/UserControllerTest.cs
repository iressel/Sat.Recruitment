using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sat.Recruitment.Api.Controllers;
using Sat.Recruitment.Api.Extensions;
using Sat.Recruitment.Global.Enums;
using Sat.Recruitment.Global.Exceptions;
using Sat.Recruitment.Global.Requests;
using Sat.Recruitment.Global.Responses;
using Sat.Recruitment.Services.AutoMapper;
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
            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(DomainProfile).Assembly);
            services.AddDatabaseService();
            services.AddApplicationServices();

            var serviceProvider = services.BuildServiceProvider();

            _userController = serviceProvider.GetService<UsersController>();
        }

        [Fact]
        public async Task CreateUserOk()
        {
            var response = await _userController.CreateUser(new UserRequest
            {
                Name = "ismain",
                Email = "iressel@gmail.com",
                Address = "san juan 855",
                Phone = "+542920483610",
                UserType = UserType.Normal,
                Money = 116
            });

            var okResult = response as ObjectResult;
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public async Task CreateUserBadRequest()
        {
            await _userController.CreateUser(new UserRequest
            {
                Name = "fchavez",
                Email = "fchavez@gmail.com",
                Address = "harosteguy 225",
                Phone = "+542920626182",
                UserType = UserType.Normal,
                Money = 116
            });

            var user = new UserRequest
            {
                Name = "mromero",
                Email = "fchavez@gmail.com",
                Address = "calle 45 763/2",
                Phone = "+542920403645",
                UserType = UserType.Normal,
                Money = 116
            };

            var ex = await Assert.ThrowsAsync<AppBadRequestException>(() => _userController.CreateUser(user));

            Assert.Contains($"There is already a user with", ex.Message);
        }
    }
}
