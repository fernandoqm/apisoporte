using FluentValidation.Results;

namespace SP.Application.Commons.Base
{
    public class BaseResponse<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }
        public string? Mensaje { get; set; }
        public IEnumerable<ValidationFailure> Errores { get; set; }
    }
}
