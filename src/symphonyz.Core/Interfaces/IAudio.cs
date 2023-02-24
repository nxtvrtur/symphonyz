namespace symphonyz.Core.Interfaces;

public interface IAudio
{
    string Path { get; }
    IMetadata<string, string> Metadata { get; }
}