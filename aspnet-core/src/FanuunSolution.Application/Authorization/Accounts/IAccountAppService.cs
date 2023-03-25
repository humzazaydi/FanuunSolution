using System.Threading.Tasks;
using Abp.Application.Services;
using FanuunSolution.Authorization.Accounts.Dto;

namespace FanuunSolution.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
