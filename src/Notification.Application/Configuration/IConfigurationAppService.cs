using System.Threading.Tasks;
using Notification.Configuration.Dto;

namespace Notification.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
