using symphonyz.Core.Interfaces;

namespace symphonyz.Core.MusicCollections;

public class Playlist : IMusicCollection
{
    public IList<IAudio> Audios { get; set; }

    private IMusicCollectionInfo _info;

    public Playlist(IMusicCollectionInfo info)
    {
        Audios = new List<IAudio>();
        _info = info;
    }
}