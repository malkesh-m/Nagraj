using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Nagraj.Configuration.Dto;

namespace Nagraj.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NagrajAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
