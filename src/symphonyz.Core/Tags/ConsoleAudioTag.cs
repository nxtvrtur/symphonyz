using System.Threading;
using System.Threading.Tasks;
using symphonyz.Core.Helpers;
using symphonyz.Core.Interfaces;

namespace symphonyz.Core.Tags;

/// <summary>
/// The `ConsoleAudioTag` class represents an audio tag displayed in the console.
/// It implements the `IAudioTag` interface to show metadata information of a tagged audio.
/// It is a part of the `Symphonyz.Core.Tags` namespace.
/// It is made for sample purposes.
/// <code>
/// var tag = new ConsoleAudioTag(audio: new Audio(@"your audio path here"));
/// </code>
/// </summary>
/// 
public class ConsoleAudioTag: IAudioTag
{
    private Track Tagged { get; }
    
    /// <summary>
    /// Creates a new instance of the `ConsoleAudioTag` class.
    /// </summary>
    /// <param name="track">Represents an audio to be tagged.</param>
    /// 
    public ConsoleAudioTag(Track track)
    {
        Tagged = track.ThrowIfNull();
    }
    
    /// <summary>
    /// The `Show` method displays the metadata information of the tagged audio in the console.
    /// </summary>
    public Task Show(CancellationToken cancellationToken)
    {
        foreach (var pair in Tagged.Metadata.Properties)
        {
            Console.WriteLine(pair);
        }
        return Task.CompletedTask;
    }
}