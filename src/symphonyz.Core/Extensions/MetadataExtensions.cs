using symphonyz.Core.Interfaces;

namespace symphonyz.Core.Extensions
{
    public static class MetadataExtensions
    {
        public static void SetDefaultProperties<TKey, TValue>(this IMetadata<TKey, TValue> metadata)
        {
            metadata.Properties.TryAdd(default, default);
        }
        public static IMetadata<TKey, TValue> SetProperties<TKey, TValue>(this IMetadata<TKey, TValue> metadata
            , TKey key, TValue value)
        {
            metadata.Properties.Add(key, value);
            return metadata;
        }
        public static IMetadata<TKey, TValue> GetProperty<TKey, TValue>(this IMetadata<TKey, TValue> metadata, TKey key, out TValue value)
        {
            value = metadata.Properties[key];
            return metadata;
        }

    }
}