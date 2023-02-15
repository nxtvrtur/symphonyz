namespace symphonyz.Core.Interfaces;

public interface IAlbum : IMusicCollection
{
    string Title { get; set; }
    string Artist { get; set; }
    int ReleaseDate { get; set; }
    string CoverImageFilePath { get; set; }
}