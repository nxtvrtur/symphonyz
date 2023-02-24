namespace symphonyz.Core.Interfaces;

public interface IMetadata<TKey, TValue>
{
    public IDictionary<TKey, TValue> Properties { get; }

}