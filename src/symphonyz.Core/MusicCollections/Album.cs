using System.Threading;
using System.Threading.Tasks;
using symphonyz.Core.Interfaces;
using symphonyz.Core.MusicCollections.Base;

namespace symphonyz.Core.MusicCollections;

public class Album : MusicCollectionBase, IAlbum
{
    protected override Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public string Title { get; set; }
    public string Artist { get; set; }
    public int ReleaseDate { get; set; }
    public string CoverImageFilePath { get; set; }
}