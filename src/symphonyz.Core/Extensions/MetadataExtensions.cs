using symphonyz.Core.Interfaces;

namespace symphonyz.Core.Extensions;

public static class MetadataExtensions
{
    public static IMetadata SetDefault(this IMetadata metadata)
    {
        metadata.Properties.Add("Name", "Unknown");
        metadata.Properties.Add("Artist", "Unknown_Artist");
        return metadata;
    }
}