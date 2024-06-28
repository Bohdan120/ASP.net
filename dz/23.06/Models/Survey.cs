using System.ComponentModel.DataAnnotations;

namespace _23._06.Models
{
    public class Survey
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ім'я є обов'язковим")]
        [MinLength(2, ErrorMessage = "Ім'я повинно містити не менше 2 символів")]
        public string Name { get; set; }

        [Required]
        [AgeRange(18, 99, ErrorMessage = "Вік повинен бути в межах 18-99 років")]
        public int Age { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Некоректна електронна пошта")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Рівень задоволеності повинен бути обраним")]
        public string Satisfaction { get; set; }
       

        [MaxLength(500, ErrorMessage = "Пропозиції не можуть містити більше 500 символів")]
        public string Suggestions { get; set; }
    }
}
