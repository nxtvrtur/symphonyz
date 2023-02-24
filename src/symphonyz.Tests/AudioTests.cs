using FluentAssertions;
using symphonyz.Core;
using symphonyz.Core.Helpers;
using symphonyz.Core.Metadata;

namespace symphonyz.Tests;

public class AudioTests
{
    [Fact]
    public void Test_ShouldCreateTrackWithDefaultMetadata()
    {
        var track = new Track("sample.mp3");
        track.Metadata.Should().BeEquivalentTo(new DefaultMetadata<string, string>());
    }
    //test notnull method
    [Fact]
    public void NotNull_ShouldThrowException()
    {
        string? nullStr = null;
        var act = () => nullStr.ThrowIfNull();
        act.Should().Throw<ArgumentNullException>();
    }
    [Fact]
    public void NotNull_ShouldNotThrowException()
    {
        var nullStr = "not null";
        var act = () => nullStr.ThrowIfNull();
        act().Should().Be(nullStr);
    }
}