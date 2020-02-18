using System.ComponentModel.DataAnnotations;

namespace FE-practice.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}