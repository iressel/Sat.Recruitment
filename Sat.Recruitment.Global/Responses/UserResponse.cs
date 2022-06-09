using Sat.Recruitment.Global.Enums;
using Sat.Recruitment.Global.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sat.Recruitment.Global.Responses
{
    public class UserResponse
    {
        public Guid Id { get; set; }

        [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(AppBadRequestException))]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "EmailRequired", ErrorMessageResourceType = typeof(AppBadRequestException))]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "AddressRequired", ErrorMessageResourceType = typeof(AppBadRequestException))]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required(ErrorMessageResourceName = "PhoneRequired", ErrorMessageResourceType = typeof(AppBadRequestException))]
        [MaxLength(50)]
        public string Phone { get; set; }

        public UserType UserType { get; set; }

        public decimal Money { get; set; }
    }
}
