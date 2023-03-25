using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FanuunSolution.Configuration.Dto;

namespace FanuunSolution.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FanuunSolutionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
