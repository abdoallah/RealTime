using System.Threading.Tasks;
using Abp.Application.Services;
using Notification.Sessions.Dto;

namespace Notification.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
