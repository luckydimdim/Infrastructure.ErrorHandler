using System;
using Cmas.Infrastructure.ErrorHandler.Web;

namespace Cmas.Infrastructure.ErrorHandler
{
    /// <summary>
    /// 
    /// </summary>
    public class ForbiddenErrorException : Exception, IHasHttpServiceError
    {  
        public ForbiddenErrorException()
            : base()
        { }

        public ForbiddenErrorException(string message)
            : base(message)
        { }

        public ForbiddenErrorException(string message, Exception innerException)
            : base(message, innerException)
        { }

        public HttpServiceError HttpServiceError
        {
            get { return HttpServiceErrorDefinition.ForbiddenError; }
        }
    }
}