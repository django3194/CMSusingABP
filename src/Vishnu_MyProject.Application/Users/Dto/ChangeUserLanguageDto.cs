using System.ComponentModel.DataAnnotations;

namespace Vishnu_MyProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}