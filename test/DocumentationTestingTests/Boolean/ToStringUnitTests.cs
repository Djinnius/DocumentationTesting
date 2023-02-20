namespace DocumentationTestingTests.Boolean;

// <summary>
///     Tests for the <see cref="bool"/> extension method that returns the <paramref name="trueValue"/> when 
///     the <paramref name="bool"/> value is true; otherwise returns the <paramref name="falseValue"/>.
/// </summary>
[ExcludeFromCodeCoverage]
public class ToStringUnitTests
{
    [Fact]
    public void ToString_WhenTrue_ReturnsTrueValue()
    {
        // Arrange
        string trueValue = "Yes";
        string falseValue = "No";

        // Act
        string result = true.ToString(trueValue, falseValue);

        // Assert
        result.Should().Be(trueValue);
    }

    [Fact]
    public void ToString_WhenFalse_ReturnsFalseValue()
    {
        // Arrange
        string trueValue = "Yes";
        string falseValue = "No";

        // Act
        string result = false.ToString(trueValue, falseValue);

        // Assert
        result.Should().Be(falseValue);
    }

    [Fact]
    public void ToString_WithNullTrueValue_ThrowsArgumentNullException()
    {
        // Arrange
        string? trueValue = null;
        string falseValue = "No";

        // Act & Assert
#pragma warning disable CS8604 // Possible null reference argument.
        Assert.Throws<ArgumentNullException>(() => true.ToString(trueValue, falseValue));
#pragma warning restore CS8604 // Possible null reference argument.
    }

    [Fact]
    public void ToString_WithNullFalseValue_ThrowsArgumentNullException()
    {
        // Arrange
        string trueValue = "Yes";
        string? falseValue = null;

        // Act & Assert
#pragma warning disable CS8604 // Possible null reference argument.
        Assert.Throws<ArgumentNullException>(() => true.ToString(trueValue, falseValue));
#pragma warning restore CS8604 // Possible null reference argument.
    }
}

