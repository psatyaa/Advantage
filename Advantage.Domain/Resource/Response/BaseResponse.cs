namespace Advantage.Domain.Resource.Response
{
    public abstract class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}