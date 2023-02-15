using symphonyz.Core.Extensions;
using symphonyz.Core.Interfaces;

namespace symphonyz.Core.Metadata;

public class AudioMetadata : IMetadata
{
    public AudioMetadata(IDictionary<string, object> properties)
    {
        Properties = properties;
    }

    public AudioMetadata()
    {
        Properties = new Dictionary<string, object>();
        this.SetDefault();
    }

    public IDictionary<string, object> Properties { get; }

    public object GetProperty(string key)
    {
        return Properties[key];
    }

    public void SetProperty(string key, object value) => Properties.Add(key, value);
}