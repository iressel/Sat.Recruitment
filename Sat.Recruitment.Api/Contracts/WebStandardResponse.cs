using Microsoft.AspNetCore.Mvc;
using Sat.Recruitment.Global.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Contracts
{
    /// <summary>
    /// Standards API response.
    /// </summary>
    public class WebStandardResponse<T> : StandardResponse<T>
    {
        public WebStandardResponse(HttpStatusCode statusCode, T data = default, string message = "")
            : base(statusCode, data, message)
        {
        }

        /// <summary>
        /// Gets the action result to send to caller.
        /// </summary>
        [JsonIgnore]
        public IActionResult Result
        {
            get
            {
                return new ObjectResult(this)
                {
                    StatusCode = (int)StatusCode
                };
            }
        }
    }

}
