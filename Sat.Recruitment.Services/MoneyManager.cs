using Sat.Recruitment.Global.Enums;
using Sat.Recruitment.Global.Requests;
using Sat.Recruitment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Services
{
    public class MoneyManager : IMoneyManager
    {
        public decimal CalculateAmount(UserRequest userRequest)
        {
            switch (userRequest.UserType)
            {
                case UserType.Normal:

                    if (userRequest.Money > 100)
                        return CalculateGif(userRequest.Money, 0.20m);
                    else if (userRequest.Money < 100 && userRequest.Money > 10)
                        return CalculateGif(userRequest.Money, 0.8m);

                    break;
                case UserType.SuperUser:

                    if (userRequest.Money > 100)
                        return CalculateGif(userRequest.Money, 0.20m);

                    break;
                case UserType.Premium:

                    if (userRequest.Money > 100)
                        return CalculateGif(userRequest.Money, 2m);

                    break;
                default:
                    return userRequest.Money;
            }

            return userRequest.Money;

        }

        private decimal CalculateGif(decimal money, decimal percentage)
        {
            var gif = (money * percentage) + money;
            return gif;
        }
    }
}
