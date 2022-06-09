using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Sat.Recruitment.Global.Responses
{
    /// <summary>
    /// Standards API response.
    /// </summary>
    public class StandardResponse<T>
    {
        /// <summary>
        /// The http status code of the response.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// A custom message of the response.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The data associated with the response.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Gets a value indicating whether this response indicates a success.
        /// </summary>
        public bool IsSuccessStatusCode => StatusCode >= HttpStatusCode.OK && StatusCode <= HttpStatusCode.IMUsed;

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardResponse{T}"/> class.
        /// </summary>
        public StandardResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardResponse{T}"/> class.
        /// </summary>
        /// <param name="statusCode">The status code.</param>
        /// <param name="data">The data.</param>
        /// <param name="message">The message.</param>
        public StandardResponse(HttpStatusCode statusCode, T data = default, string message = "")
        {
            Data = data;
            StatusCode = statusCode;
            Message = message;
        }
    }
}
