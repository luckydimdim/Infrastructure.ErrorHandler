using System;
using Cmas.Infrastructure.ErrorHandler.Web;

namespace Cmas.Infrastructure.ErrorHandler
{
    public class InvalidTokenErrorException : Exception, IHasHttpServiceError
    {
        public InvalidTokenErrorException()
            : base() { }

        public InvalidTokenErrorException(string message)
            : base(message) { }

        public InvalidTokenErrorException(string message, Exception innerException)
            : base(message, innerException) { }

        public HttpServiceError HttpServiceError { get { return HttpServiceErrorDefinition.InvalidTokenError; } }
    }
}
