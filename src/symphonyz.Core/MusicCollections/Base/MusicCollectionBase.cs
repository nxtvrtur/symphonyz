using System.Threading;
using System.Threading.Tasks;
using symphonyz.Core.Interfaces;

namespace symphonyz.Core.MusicCollections.Base;

public abstract class MusicCollectionBase : IMusicCollection
{
    public IList<Audio> Tracks { get; set; }
    protected abstract Task SaveChangesAsync(CancellationToken cancellationToken);

    public async Task AddTrackAsync(Audio audio, CancellationToken cancellationToken)
    {
        Tracks.Add(audio);
        await SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveTrackAsync(Audio audio, CancellationToken cancellationToken)
    {
        Tracks.Remove(audio);
        await SaveChangesAsync(cancellationToken);
    }
}