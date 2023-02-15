namespace symphonyz.Core.Interfaces;

public interface IMetadata
{
    public IDictionary<string, object> Properties { get; }
    public object GetProperty(string key);
    public void SetProperty(string key, object value);
}