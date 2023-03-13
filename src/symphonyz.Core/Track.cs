using symphonyz.Core.Helpers;
using symphonyz.Core.Interfaces;
using symphonyz.Core.Metadata;

namespace symphonyz.Core;

/// <summary>
/// Represents a track.
/// </summary>
public class Track : IAudio
{
    public Track(string path, IMetadata<string, string> metadata = null)
    {
        Path = path.ThrowIfNull();
        Metadata = metadata ?? new DefaultMetadata<string, string>();
    }
    public string Path { get; }
    public IMetadata<string, string> Metadata { get; }
}