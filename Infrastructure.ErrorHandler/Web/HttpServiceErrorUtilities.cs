﻿using System;

namespace Cmas.Infrastructure.ErrorHandler.Web
{
    public static class HttpServiceErrorUtilities
    {
        public static HttpServiceError ExtractFromException(Exception exception, HttpServiceError defaultValue)
        {
            HttpServiceError result = defaultValue;

            if (exception != null)
            {
                IHasHttpServiceError exceptionWithServiceError = exception as IHasHttpServiceError;

                if (exceptionWithServiceError != null)
                    result = exceptionWithServiceError.HttpServiceError;
            }

            return result;
        }
    }
}
