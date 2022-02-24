using System.ComponentModel.DataAnnotations;

namespace YoutubeOrganizer.Dtos;
public class CreateVideoDto
{
    [Required]
    public int Category { get; set; }
    [Required]
    public string VideoUrl { get; set; }
    public string[] Tags { get; set; }
}
