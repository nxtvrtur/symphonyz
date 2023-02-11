using System.Collections;

namespace symphonyz.Core;

public class AudioMetadata : IEnumerable
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Genre { get; set; }

    public AudioMetadata(string title, string artist, string genre)
    {
        Title = title;
        Artist = artist;
        Genre = genre;
    }

    public AudioMetadata()
    {
        Title = "Unknown";
        Artist = "Unknown";
        Genre = "Unknown";
    }

    public IEnumerator GetEnumerator()
    {
        yield return "Title: " + Title;
        yield return "Artist: " + Artist;
        yield return "Genre: " + Genre;
    }
}