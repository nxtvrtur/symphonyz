namespace symphonyz.Core.Helpers;

public static class ThrowIfArgument
{
    public static T IsNull<T>(T value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));
        return value;
    }
}