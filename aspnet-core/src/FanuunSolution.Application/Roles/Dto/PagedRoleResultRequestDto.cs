using Abp.Application.Services.Dto;

namespace FanuunSolution.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

