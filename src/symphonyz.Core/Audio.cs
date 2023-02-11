namespace symphonyz.Core;

public class Audio
{
    private readonly string _path;
    public string Name { get; }
    public AudioFormat Format { get; }
    public AudioMetadata Metadata { get; set; }

    public Audio(string path, AudioMetadata metadata = null)
    {
        _path = ThrowIfArgument.IsNull(path);
        Format = MusicHelper.GetFormat(path);
        Name = MusicHelper.GetFileName(path);
        Metadata = metadata ?? new AudioMetadata();
    }
}