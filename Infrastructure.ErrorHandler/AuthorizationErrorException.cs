using System;
using Cmas.Infrastructure.ErrorHandler.Web;

namespace Cmas.Infrastructure.ErrorHandler
{
    /// <summary>
    ///  Ошибка при попытке аунтификации
    /// </summary>
    public class AuthorizationErrorException : Exception, IHasHttpServiceError
    {  
        public AuthorizationErrorException()
            : base()
        { }

        public AuthorizationErrorException(string message)
            : base(message)
        { }

        public AuthorizationErrorException(string message, Exception innerException)
            : base(message, innerException)
        { }

        public HttpServiceError HttpServiceError
        {
            get { return HttpServiceErrorDefinition.AuthorizationError; }
        }
    }
}