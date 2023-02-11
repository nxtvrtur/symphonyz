namespace symphonyz.Core;

public static class MusicHelper
{
    public static IEnumerable<Audio> ImportMusicFromDirectory(string path)
    {
        var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories)
            .Where(f => f.EndsWith(".mp3") || 
                        f.EndsWith(".wav")).ToArray();
        return files.Select(a=> new Audio(a));
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