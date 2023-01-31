namespace SP.Infrastructure.Commons.Base.Request
{
    //Clase base para los filtros
    public class BaseFiltersRequest : BasePaginationRequest
    {
        public int? NumFilter { get; set; } = null;
        public string? TextFilter { get; set; } = null;
        public int? StateFilter { get; set; } = null;
        public string? StartDate { get; set; } = null;
        public string? EndDate { get; set;} = null;
        public bool? DownLoad { get; set; } = false ;

    }
}
