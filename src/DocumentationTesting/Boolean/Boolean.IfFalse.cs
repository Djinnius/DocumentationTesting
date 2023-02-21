namespace DocumentationTesting.Boolean;

public static partial class CoreExtensions
{
    /// <summary>
    ///     A <see cref="bool"/> extension method that executes an <paramref name="action"/> if the value is <see langword="false"/>.
    /// </summary>
    /// <param name="bool"> The source bool to act on. </param>
    /// <param name="action"> The action to execute. </param>
    /// <exception cref="ArgumentNullException"> When the <paramref name="action"/> is <see langword="null"/>. </exception>
    public static void IfFalse(this bool @bool, Action action)
    {
        if (action is null)
            throw new ArgumentNullException(nameof(action), $"Boolean extension method {IfFalse} called with null parameter action.");

        if (!@bool)
            action();
    }
}
