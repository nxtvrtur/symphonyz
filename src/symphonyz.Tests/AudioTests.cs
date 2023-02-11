using FluentAssertions;
using symphonyz.Core;
using Xunit.Abstractions;

namespace symphonyz.Tests;

public class AudioTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public AudioTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Create_AudioWhenPathIsNotNull()
    {
        _testOutputHelper.WriteLine("Create_AudioWhenPathIsNotNull");
        // Arrange
        var audio = new Audio("sample.mp3");
        // Act & Assert
        audio.Should().NotBeNull();
    }

    [Fact]
    public void Create_AudioWhenPathIsNull()
    {
        // Arrange
        string? path = null;
        // Act
        var act = () => new Audio(path);
        // Assert
        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void Create_AudioWhenMetadataIsNull()
    {
        // Act & Act
        var audio = new Audio("sample.mp3");
        // Assert
        audio.Metadata.Should().NotBeNull();
        audio.Metadata.Title.Should().Be("Unknown");
        audio.Metadata.Artist.Should().Be("Unknown");
        audio.Metadata.Genre.Should().Be("Unknown");
    }

    [Fact]
    public void Create_AudioWhenMetadataIsNotNull()
    {
        //Arrange
        var path = "sample.mp3";
        var metadata = new AudioMetadata("title", "artist", "genre");
        //Act
        var audio = new Audio(path, metadata);
        //Assert
        audio.Metadata.Should().NotBeNull().And.BeEquivalentTo(metadata);
    }
}