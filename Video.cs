using System.Net.Http.Json;

namespace YoutubeOrganizer.Models;
public record Video
{
    public Guid Id { get; init; }
    public int Category { get; init; }
    public string Title { get; init; }
    public string[] Tags { get; init; }
    public DateTimeOffset CreatedDate { get; init; }
    public string YoutubeId { get; init; }
    public string ChannelName { get; init; }
    public string ChannelId { get; init; }
    public DateTimeOffset PostedDate { get; init; }
    public Uri SmallThumbnailUrl { get; init; }
    public long SmallThumbnailWidth { get; init; }
    public long SmallThumbnailHeight { get; init; }
    public Uri ThumbnailUrl { get; init; }
    public long ThumbnailWidth { get; init; }
    public long ThumbnailHeight { get; init; }
    public string VideoUrl
    {
        get {return $"https://www.youtube.com/watch?v={YoutubeId}"; }
    }
}
