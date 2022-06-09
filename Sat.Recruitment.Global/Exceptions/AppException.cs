using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Sat.Recruitment.Global.Exceptions
{
    /// <summary>
    /// Represent an error in the API.
    /// </summary>
    public class AppException : Exception
    {
        /// <summary>
        /// Create an instance of the forbidden exception.
        /// </summary>
        public AppException(HttpStatusCode statusCode, string message = null, Exception innerException = null)
            : base(message, innerException)
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// The status code for the error.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
    }
}
