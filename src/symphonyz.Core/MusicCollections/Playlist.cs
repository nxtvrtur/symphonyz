using System.Threading;
using System.Threading.Tasks;
using symphonyz.Core.Interfaces;
using Symphonyz.Core.Interfaces;
using symphonyz.Core.Metadata;

namespace symphonyz.Core.MusicCollections;

public class Playlist : IMusicCollection
{
    public IList<Audio> Tracks { get; set; }

    public PlaylistMetadata Metadata { get; set; }

    public async Task AddTrackAsync(Audio audio, CancellationToken cancellationToken)
    {
        await Task.Run(() => Tracks.Add(audio), cancellationToken);
    }

    public async Task RemoveTrackAsync(Audio audio, CancellationToken cancellationToken)
    {
        await Task.Run(() => Tracks.Remove(audio), cancellationToken);
    }
}