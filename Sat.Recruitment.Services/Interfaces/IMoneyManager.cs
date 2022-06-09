using Sat.Recruitment.Global.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Services.Interfaces
{
    public interface IMoneyManager
    {
        decimal CalculateAmount(UserRequest userRequest);
    }
}
