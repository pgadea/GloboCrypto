namespace GloboCrypto.WebAPI.Services.Http
{
    public interface IHttpService
    {
        Task<T> GetAsync<T>(string url);
    }
}
