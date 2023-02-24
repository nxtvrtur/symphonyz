using JetBrains.Annotations;
using symphonyz.Core.Extensions;
using symphonyz.Core.Interfaces;

namespace symphonyz.Core.Metadata;

public class DefaultMetadata<TKey, TValue> : IMetadata<TKey, TValue>
{
    public DefaultMetadata(IDictionary<TKey, TValue> properties)
    {
        Properties = properties;
    }

    public DefaultMetadata()
    {
        Properties = new Dictionary<TKey, TValue>();
        this.SetDefaultProperties();
    }

    [CanBeNull] public IDictionary<TKey, TValue> Properties { get; }
}