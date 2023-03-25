using Abp.Application.Services;
using FanuunSolution.MultiTenancy.Dto;

namespace FanuunSolution.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

