using System.Threading;
using System.Threading.Tasks;

namespace symphonyz.Core.Interfaces;

public interface IMusicCollection
{
    IList<Audio> Tracks { get; set; }
    Task AddTrackAsync(Audio audio, CancellationToken cancellationToken);
    Task RemoveTrackAsync(Audio audio, CancellationToken cancellationToken);
}