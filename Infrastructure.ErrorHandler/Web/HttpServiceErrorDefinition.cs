using System.Collections.Generic;
using Nancy;
using Nancy.Validation;

namespace Cmas.Infrastructure.ErrorHandler.Web
{
    public static class HttpServiceErrorDefinition
    {
        public static HttpServiceError NotFoundError = new HttpServiceError
        {
            HttpStatusCode = HttpStatusCode.NotFound,
            ServiceErrorModel = new ServiceErrorModel
            {
                Code = ServiceErrorCode.NotFound,
                Details = "The requested entity was not found."
            }
        };

        public static HttpServiceError GeneralError = new HttpServiceError
        {
            HttpStatusCode = HttpStatusCode.BadRequest,
            ServiceErrorModel = new ServiceErrorModel
            {
                Code = ServiceErrorCode.GeneralError,
                Details = "An error occured during processing the request."
            }
        };

        public static HttpServiceError InternalServerError = new HttpServiceError
        {
            HttpStatusCode = HttpStatusCode.InternalServerError,
            ServiceErrorModel = new ServiceErrorModel
            {
                Code = ServiceErrorCode.InternalServerError,
                Details = "There was an internal server error during processing the request."
            }
        };

        public static HttpServiceError InvalidTokenError = new HttpServiceError
        {
            HttpStatusCode = HttpStatusCode.BadRequest,
            ServiceErrorModel = new ServiceErrorModel
            {
                Code = ServiceErrorCode.InvalidToken,
                Details = "Invalid API Token."
            }
        };

        public static HttpServiceError ConflictError = new HttpServiceError
        {
            HttpStatusCode = HttpStatusCode.Conflict,
            ServiceErrorModel = new ServiceErrorModel
            {
                Code = ServiceErrorCode.Conflict,
                Details = "The request could not be completed due to a conflict with the current state of the resource"
            }
        };

        public static HttpServiceError ValidationError(IEnumerable<dynamic> errors)
        {
            return new HttpServiceError
                {
                    HttpStatusCode = HttpStatusCode.BadRequest,
                    ServiceErrorModel = new ValidationErrorModel
                    {
                        Code = ServiceErrorCode.ValidationError,
                        Details = "Invalid request",
                        Errors = errors
                    }
                };
        }
    }
}
