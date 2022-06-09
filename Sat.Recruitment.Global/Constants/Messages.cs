using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Global.Constants
{
    /// <summary>
    /// Messages of the aplication
    /// </summary>
    public static class Messages
    {
        /// <summary>
        /// Global messages
        /// </summary>
        public static class Global
        {
            /// <summary>
            /// Data not found
            /// </summary>
            public const string TokenExpired = "Token expired";

            /// <summary>
            /// Data not found
            /// </summary>
            public const string DataNotFound = "Data not found";

            /// <summary>
            /// Data not available
            /// </summary>
            public const string DataNotAvailable = "Data not available";
        }

        public static class Exceptions
        {
            public const string BadRequest = "The server cannot or will not process the request due to an apparent client error";

            public const string ForbiddenRequest = "The request contained valid data and was understood by the server, but the server is refusing action";

            public const string NotFoundRequest = "The requested resource could not be found";

            public const string InternalError = "There was an internal error processing the request";
        }
    }


}
