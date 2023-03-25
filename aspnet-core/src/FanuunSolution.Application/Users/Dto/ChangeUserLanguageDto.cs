using System.ComponentModel.DataAnnotations;

namespace FanuunSolution.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}