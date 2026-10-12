using System.ComponentModel.DataAnnotations;

namespace Voyara.Application.DTOs
{
    public class ExternalLoginDto
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        public string IdToken { get; set; }
    }
}
