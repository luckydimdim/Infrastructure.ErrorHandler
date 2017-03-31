using System;
using Cmas.Infrastructure.ErrorHandler.Web;

namespace Cmas.Infrastructure.ErrorHandler
{
    public class InternalServerErrorException : Exception, IHasHttpServiceError
    {
        public InternalServerErrorException()
            : base() { }

        public InternalServerErrorException(string message)
            : base(message) { }

        public InternalServerErrorException(string message, Exception innerException)
            : base(message, innerException) { }

        public HttpServiceError HttpServiceError { get { return HttpServiceErrorDefinition.InternalServerError; } }
    }
}
