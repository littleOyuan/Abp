using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Abby.Configuration.Dto;

namespace Abby.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbbyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
