using Sat.Recruitment.Global.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Model.DB.Tables
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public UserType UserType { get; set; }
        public decimal Money { get; set; }
    }
}
