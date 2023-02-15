using symphonyz.Core;
using symphonyz.Core.Metadata;
using symphonyz.Core.MusicCollections;

var properties = new Dictionary<string, object> { { "Tittle", "MyPLaylist" }, { "Description", "lalalla description" } };
var playlist = new Playlist { Tracks = new List<Audio>(), Metadata = new PlaylistMetadata(properties)};
await playlist.AddTrackAsync(new Audio("sample.mp3"), CancellationToken.None);
await playlist.AddTrackAsync(new Audio("sample2.mp3"), CancellationToken.None);
foreach (var track in playlist.Tracks)
{
    Console.WriteLine($"{track.Name}/{track.Format}");
}