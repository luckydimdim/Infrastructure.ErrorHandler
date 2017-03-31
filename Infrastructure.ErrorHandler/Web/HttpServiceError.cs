namespace Cmas.Infrastructure.ErrorHandler.Web
{
    public class HttpServiceError
    {
        public ServiceErrorModel ServiceErrorModel { get; set; }

        public Nancy.HttpStatusCode HttpStatusCode { get; set; }
    }
}