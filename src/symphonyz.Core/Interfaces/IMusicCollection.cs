using JetBrains.Annotations;

namespace symphonyz.Core.Interfaces;
public interface IMusicCollection
{
    [CanBeNull] IList<IAudio> Audios { get; set; }
}

