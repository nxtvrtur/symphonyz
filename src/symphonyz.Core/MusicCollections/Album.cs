using symphonyz.Core.Interfaces;

namespace symphonyz.Core.MusicCollections;

public class Album : IMusicCollection
{
    public IList<IAudio> Audios { get; set; }
    private IMusicCollectionInfo _info;

    public Album(IMusicCollectionInfo info)
    {
        Audios = new List<IAudio>();
        _info = info;
    }
}