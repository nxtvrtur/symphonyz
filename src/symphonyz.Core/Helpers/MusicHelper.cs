namespace symphonyz.Core.Helpers;

public static class MusicHelper
{
    public static IEnumerable<Audio> ImportMusicFromDirectory(string path)
    {
        return Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories)
            .Where(f => f.EndsWith(".mp3") || 
                        f.EndsWith(".wav")).Select(a => new Audio(a));
    }

    public static AudioFormat GetFormat(string path)
    {
        return Path.GetExtension(path).ToLowerInvariant().Replace(".", "") switch
        {
            "mp3" => AudioFormat.Mp3, "wav" => AudioFormat.Wav, _ => AudioFormat.None
        };
    }

    public static string GetFileName(string path)
    {
        return Path.GetFileNameWithoutExtension(path);
    }
}