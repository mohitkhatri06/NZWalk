using System.ComponentModel.DataAnnotations;

namespace NZWalk.Api.Models.DTO
{
    public class UpdateRegionRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Code has to be a minimum 3 chars")]
        [MaxLength(3, ErrorMessage = "Code has to be a maximum 3 chars")]
        public string Code { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Code has to be a maximum 199 chars")]
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
