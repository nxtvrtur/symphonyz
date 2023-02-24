namespace symphonyz.Core.Helpers;

public static class ThrowIfArgument
{
    /// <summary>
    /// Throws an exception if the argument is null.
    /// </summary>
    /// <param name="value">
    /// The value to check. If null, an exception is thrown.
    /// </param>
    /// <typeparam name="T">
    /// The type of the value.
    /// </typeparam>
    /// <returns>
    /// The value.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown if the value is null.
    /// </exception>
    public static T ThrowIfNull<T>(this T value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));
        return value;
    }
}