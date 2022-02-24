using System.ComponentModel.DataAnnotations;

namespace YoutubeOrganizer.Dtos;
public class UpdateVideoDto
{

    [Required]
    public int Category { get; set; }
    [Required]
    public string[] Tags { get; set; }
}
