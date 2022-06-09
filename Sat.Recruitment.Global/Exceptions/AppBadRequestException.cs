using Sat.Recruitment.Global.Constants;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Sat.Recruitment.Global.Exceptions
{
    /// <summary>
    /// An exception to indicate the request is badly conformed.
    /// </summary>
    public class AppBadRequestException : AppException
    {
        /// <summary>
        /// Create an instance of the bad request exception.
        /// </summary>
        public AppBadRequestException(string message = Messages.Exceptions.BadRequest, Exception innerException = null)
            : base(HttpStatusCode.BadRequest, message, innerException)
        {
        }
    }
}
