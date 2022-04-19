using System.ComponentModel.DataAnnotations;

namespace BirthdayCardGenerator.Models
{
    public class Birthday
    {
        [Required]
        public string From { get; set; } = String.Empty;

        [Required]
        public string To { get; set; } = String.Empty;

        [Required]
        public string Message { get; set; } = String.Empty;
    }
}
