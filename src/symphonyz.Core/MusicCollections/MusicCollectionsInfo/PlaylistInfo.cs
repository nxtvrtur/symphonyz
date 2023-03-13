using symphonyz.Core.Interfaces;

namespace symphonyz.Core.MusicCollections.MusicCollectionsInfo;

public class PlaylistInfo : IMusicCollectionInfo
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
}