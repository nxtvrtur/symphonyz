namespace symphonyz.Core.Interfaces;

public interface IMetadata
{
    IDictionary<string, object> Properties { get; }
    object GetProperty(string key);
    void SetProperty(string key, object value);
}