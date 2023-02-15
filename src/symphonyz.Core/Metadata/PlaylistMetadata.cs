using symphonyz.Core.Helpers;
using symphonyz.Core.Interfaces;

namespace symphonyz.Core.Metadata;

public class PlaylistMetadata : IMetadata
{
    public PlaylistMetadata(IDictionary<string, object> properties)
    {
        Properties = ThrowIfArgument.IsNull(properties);
    }
    public IDictionary<string, object> Properties { get; }

    public object GetProperty(string key) => Properties[key];

    public void SetProperty(string key, object value) => Properties.Add(key, value);
}