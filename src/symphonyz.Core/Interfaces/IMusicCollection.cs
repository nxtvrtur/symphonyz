using JetBrains.Annotations;

namespace symphonyz.Core.Interfaces;
public interface IMusicCollection<T> where T : IAudio
{
    [CanBeNull] IList<T> Audios { get; set; }
}

