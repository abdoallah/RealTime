using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Notification.EntityFrameworkCore
{
    public static class NotificationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NotificationDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NotificationDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
