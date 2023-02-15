using FluentAssertions;
using symphonyz.Core;
using symphonyz.Core.Metadata;

namespace symphonyz.Tests;

public class AudioTests
{
  
    [Fact]
    public void Create_AudioWhenPathIsNotNull()
    {
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
        // Arrange & Act & Assert
        new Audio("sample.mp3").Metadata.Should().NotBeNull();
    }

    [Fact]
    public void Create_AudioWhenMetadataIsNotNull()
    {
        
    }
}