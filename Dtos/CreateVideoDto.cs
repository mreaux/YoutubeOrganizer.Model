using System.ComponentModel.DataAnnotations;

namespace YoutubeOrganizer.Dtos;
public class CreateVideoDto
{
    [Required]
    public int Category { get; init; }
    [Required]
    public string VideoUrl { get; init; }
    public string[] Tags { get; init; }
}
