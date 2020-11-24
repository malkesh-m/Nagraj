using System.ComponentModel.DataAnnotations;

namespace Nagraj.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}