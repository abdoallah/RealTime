using System.ComponentModel.DataAnnotations;

namespace Notification.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}