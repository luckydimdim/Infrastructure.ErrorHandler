using System;
using Cmas.Infrastructure.ErrorHandler.Web;
using System.Collections.Generic;
using Nancy.Validation;

namespace Cmas.Infrastructure.ErrorHandler
{
    public class ValidationErrorException : Exception, IHasHttpServiceError
    {
        private IEnumerable<dynamic> Errors;

        public ValidationErrorException()
            : base()
        { }

        public ValidationErrorException(IEnumerable<dynamic> errors)
            : base()
        {
            Errors = errors;
        }

        public ValidationErrorException(string message, IEnumerable<dynamic> errors)
            : base(message)
        {
            Errors = errors;
        }

        public ValidationErrorException(string message, Exception innerException)
            : base(message, innerException)
        { }

        public HttpServiceError HttpServiceError
        {
            get { return HttpServiceErrorDefinition.ValidationError(Errors); }
        }
    }
}