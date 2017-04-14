using System;
using Cmas.Infrastructure.ErrorHandler.Web;

namespace Cmas.Infrastructure.ErrorHandler
{
    public class ConflictErrorException : Exception, IHasHttpServiceError
    {
        public ConflictErrorException()
            : base()
        { }

        public ConflictErrorException(string message)
            : base(message)
        { }

        public ConflictErrorException(string message, Exception innerException)
            : base(message, innerException)
        { }

        public HttpServiceError HttpServiceError
        {
            get { return HttpServiceErrorDefinition.ConflictError; }
        }
    }
}