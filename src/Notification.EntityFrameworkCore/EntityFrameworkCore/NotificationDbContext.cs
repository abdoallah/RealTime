using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Notification.Authorization.Roles;
using Notification.Authorization.Users;
using Notification.MultiTenancy;

namespace Notification.EntityFrameworkCore
{
    public class NotificationDbContext : AbpZeroDbContext<Tenant, Role, User, NotificationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NotificationDbContext(DbContextOptions<NotificationDbContext> options)
            : base(options)
        {
        }
    }
}
