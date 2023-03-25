using System.Threading.Tasks;
using FanuunSolution.Configuration.Dto;

namespace FanuunSolution.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
