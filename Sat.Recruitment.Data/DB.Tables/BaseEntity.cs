using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Model.DB.Tables
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
