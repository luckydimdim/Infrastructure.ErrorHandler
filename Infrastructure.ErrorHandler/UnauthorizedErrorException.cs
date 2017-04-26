using System;
using Cmas.Infrastructure.ErrorHandler.Web;

namespace Cmas.Infrastructure.ErrorHandler
{
    /// <summary>
    /// You aren’t authenticated–either not authenticated at all or authenticated incorrectly–but please reauthenticate and try again
    /// </summary>
    public class UnauthorizedErrorException : Exception, IHasHttpServiceError
    {  
        public UnauthorizedErrorException()
            : base()
        { }

        public UnauthorizedErrorException(string message)
            : base(message)
        { }

        public UnauthorizedErrorException(string message, Exception innerException)
            : base(message, innerException)
        { }

        public HttpServiceError HttpServiceError
        {
            get { return HttpServiceErrorDefinition.UnauthorizedError; }
        }
    }
}