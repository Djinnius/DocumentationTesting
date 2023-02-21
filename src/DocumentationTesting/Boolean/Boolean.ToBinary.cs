namespace DocumentationTesting.Boolean;

public static partial class CoreExtensions
{
    /// <summary>
    ///     A <see cref="bool"/> extension method that converts this <paramref name="bool"/> into a binary representation.
    /// </summary>
    /// <param name="bool"> The source bool to act on. </param>
    /// <returns> A binary represenation of <paramref name="bool"/>. </returns>
    public static byte ToBinary(this bool @bool)
        => Convert.ToByte(@bool);
}
