using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sat.Recruitment.Global.Exceptions;
using Sat.Recruitment.Global.Requests;
using Sat.Recruitment.Global.Responses;
using Sat.Recruitment.Model.DB;
using Sat.Recruitment.Model.DB.Tables;
using Sat.Recruitment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Services
{
    public class UserManager : IUserManager
    {
        private readonly RecruitmentDB _context;
        private readonly IMoneyManager _moneyManager;
        private readonly IMapper _mapper;

        public UserManager(RecruitmentDB context, IMapper mapper, IMoneyManager moneyManager)
        {
            _context = context;
            _moneyManager = moneyManager;
            _mapper = mapper;
        }

        public async Task<UserResponse> CreateUser(UserRequest userRequest)
        {
            userRequest.Money = _moneyManager.CalculateAmount(userRequest);
            var user = await _context.Users
                                     .FirstOrDefaultAsync(u => u.Id == userRequest.Id
                                                               ||u.Email == userRequest.Email
                                                               || u.Phone == userRequest.Phone
                                                               || u.Name == userRequest.Name
                                                               || u.Address == userRequest.Address
                                                         );

            if (user != null) 
            {
                throw new AppBadRequestException($"There is already a user with id: {user.Id} email: {user.Email} or phone: {user.Phone} or name: {user.Name} or address: {user.Address}");
            }

            user = _mapper.Map<User>(userRequest);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return _mapper.Map<UserResponse>(user);
        }
    }
}
