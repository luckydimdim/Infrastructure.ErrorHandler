﻿namespace Cmas.Infrastructure.ErrorHandler.Web
{
    public enum ServiceErrorCode
    {
        GeneralError = 0,
        NotFound = 10,
        InternalServerError = 20,
        InvalidToken = 30,
        Conflict = 40,
        ValidationError = 50,
        Unauthorized = 60,
        AuthorizationError = 70,
        ForbiddenError = 80,
    }
}
