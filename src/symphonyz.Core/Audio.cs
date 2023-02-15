using symphonyz.Core.Helpers;
using symphonyz.Core.Interfaces;
using symphonyz.Core.Metadata;

namespace symphonyz.Core;

public class Audio
{
    private readonly string _path;
    private IMetadata _metadata;

    public Audio(string path, IMetadata metadata = null)
    {
        _path = ThrowIfArgument.IsNull(path);
        _metadata = ThrowIfArgument.IsNull(metadata) ?? new AudioMetadata();
    }
}