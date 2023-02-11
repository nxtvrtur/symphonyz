using System.Threading;
using System.Threading.Tasks;
using symphonyz.Core;
using Symphonyz.Core.Interfaces;

namespace Symphonyz.Core.Tags;

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
    private Audio Tagged { get; }
    
    /// <summary>
    /// Creates a new instance of the `ConsoleAudioTag` class.
    /// </summary>
    /// <param name="audio">Represents an audio to be tagged.</param>
    /// 
    public ConsoleAudioTag(Audio audio)
    {
        Tagged = ThrowIfArgument.IsNull(audio);
    }
    
    /// <summary>
    /// The `Show` method displays the metadata information of the tagged audio in the console.
    /// </summary>
    public Task Show(CancellationToken cancellationToken)
    {
        foreach (var o in Tagged.Metadata)
        {
            Console.WriteLine($"{o}");
        }

        return Task.CompletedTask;
    }
}