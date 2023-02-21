namespace DocumentationTesting.Boolean;

public static partial class CoreExtensions
{
    /// <summary>
    ///     A <see cref="bool"/> extension method that returns the <paramref name="trueValue"/> when 
    ///     the <paramref name="bool"/> value is true; otherwise returns the <paramref name="falseValue"/>.
    /// </summary>
    /// <param name="bool"> The source bool to act on. </param>
    /// <param name="trueValue"> The true value to be returned if the <paramref name="bool"/> value is true. </param>
    /// <param name="falseValue"> The false value to be returned if the <paramref name="bool"/> value is false.</param>
    /// <returns> A string that represents of the current boolean value. </returns>
    /// <exception cref="ArgumentNullException"> When the <paramref name="trueValue"/> or <paramref name="falseValue"/> is <see langword="null"/>. </exception>
    public static string ToString(this bool @bool, string trueValue, string falseValue)
    {
        if (trueValue is null)
            throw new ArgumentNullException(nameof(trueValue), $"Boolean extension method ToString called with null parameter 'true value'.");

        if (falseValue is null)
            throw new ArgumentNullException(nameof(falseValue), $"Boolean extension method ToString called with null parameter 'false value'.");

        return @bool ? trueValue : falseValue;
    }
}
