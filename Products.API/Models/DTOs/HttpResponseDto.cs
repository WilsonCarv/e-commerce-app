namespace Products.API.Models.DTOs
{
    public class ErrorResponseDto
    {
        public Guid ErrorId { get; set; }
        public string? Error { get; set; }
    }
    public class HttpResponseDto<T>  where T : class
    {
        public T? Data { get; set; }
        public ErrorResponseDto? Error { get; set; }

        public HttpResponseDto(T? data, ErrorResponseDto? error)
        {
            this.Data = data;
            this.Error = error;
        }
    }
}