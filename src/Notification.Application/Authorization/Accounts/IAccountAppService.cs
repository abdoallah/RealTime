using System.Threading.Tasks;
using Abp.Application.Services;
using Notification.Authorization.Accounts.Dto;

namespace Notification.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
