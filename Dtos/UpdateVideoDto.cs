using System.ComponentModel.DataAnnotations;

namespace YoutubeOrganizer.Dtos;
public class UpdateVideoDto
{

    [Required]
    public int Category { get; init; }
    [Required]
    public string[] Tags { get; init; }
}
