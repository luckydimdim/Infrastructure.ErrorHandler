namespace Cmas.Infrastructure.ErrorHandler.Web
{
    public interface IHasHttpServiceError
    {
        HttpServiceError HttpServiceError { get; }
    }
}
