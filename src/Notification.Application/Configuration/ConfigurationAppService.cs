using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Notification.Configuration.Dto;

namespace Notification.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NotificationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
