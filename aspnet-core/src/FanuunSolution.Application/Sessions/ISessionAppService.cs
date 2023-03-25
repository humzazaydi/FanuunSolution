using System.Threading.Tasks;
using Abp.Application.Services;
using FanuunSolution.Sessions.Dto;

namespace FanuunSolution.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
