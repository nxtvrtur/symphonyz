namespace symphonyz.Core.Extensions;


public static class DictionaryExtensions
{
    /// <summary>
    /// Try to add a key-value pair to a dictionary.
    /// If exception is thrown, ignore it.
    /// </summary>
    /// <param name="dictionary">
    /// Dictionary to add to.
    /// </param>
    /// <param name="key">
    /// Key to add.
    /// </param>
    /// <param name="value">
    /// value to add.
    /// </param>
    /// <typeparam name="TKey">
    /// Type of key.
    /// </typeparam>
    /// <typeparam name="TValue">
    /// Type of value.
    /// </typeparam>
    public static void TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
    {
        try
        {
            dictionary.Add(key, value);
        } catch (Exception)
        {
            // ignored
        }
    }
}