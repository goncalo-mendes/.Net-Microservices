using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Publiser { get; set; } = string.Empty;
        [Required]
        public string Cost { get; set; } = string.Empty;
    }
}
