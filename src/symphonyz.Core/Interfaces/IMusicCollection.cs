using System.Threading;
using System.Threading.Tasks;
using symphonyz.Core;

namespace Symphonyz.Core.Interfaces;

public interface IMusicCollection
{
    IList<Audio> Tracks { get; set; }
    Task AddTrackAsync(Audio audio, CancellationToken cancellationToken);
    Task RemoveTrackAsync(Audio audio, CancellationToken cancellationToken);
}