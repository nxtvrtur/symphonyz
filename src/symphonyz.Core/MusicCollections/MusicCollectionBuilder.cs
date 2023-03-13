using symphonyz.Core.Interfaces;

namespace symphonyz.Core.MusicCollections;

public class MusicCollectionBuilder
{
    public static T Build<T>(IMusicCollectionInfo _info) where T : IMusicCollection
    {
        var collectionType = typeof(T);
        return collectionType != null
            ? (T)Activator.CreateInstance(collectionType
                , _info)
            : throw new ArgumentException($"{collectionType} is not a valid type");
    }
}