using Notification.Debugging;

namespace Notification
{
    public class NotificationConsts
    {
        public const string LocalizationSourceName = "Notification";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7d32588ddec04184a97ac61f02433dde";
    }
}
