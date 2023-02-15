using System.Collections;
using symphonyz.Core.Helpers;
using symphonyz.Core.Interfaces;

namespace symphonyz.Core.Metadata;

public class AudioMetadata : IMetadata
{
    public IDictionary<string, object> Properties { get; }

    public AudioMetadata(IDictionary<string, object> properties)
    {
        Properties = ThrowIfArgument.IsNull(properties);
    }

    public object GetProperty(string key) => Properties[key];

    public void SetProperty(string key, object value) => Properties.Add(key, value);
}