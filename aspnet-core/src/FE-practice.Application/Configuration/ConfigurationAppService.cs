using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FE-practice.Configuration.Dto;

namespace FE-practice.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FE-practiceAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
