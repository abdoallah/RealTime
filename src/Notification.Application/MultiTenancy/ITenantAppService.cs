using Abp.Application.Services;
using Notification.MultiTenancy.Dto;

namespace Notification.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

