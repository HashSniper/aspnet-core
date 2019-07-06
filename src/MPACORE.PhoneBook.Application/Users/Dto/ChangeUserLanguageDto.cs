using System.ComponentModel.DataAnnotations;

namespace MPACORE.PhoneBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}