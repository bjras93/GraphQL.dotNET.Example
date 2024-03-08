namespace Application.Common.Extensions;

public static class StringExtension
{
    /// <summary>
    /// Parses date when string has value
    /// </summary>
    /// <param name="date"></param>
    /// <returns>
    /// <see cref="DateTime" /> when valid string
    /// <para>
    /// Null when whitespace
    /// </para>
    /// </returns>
    /// <exception cref="FormatException"/>
    public static DateTime? ParseDateOrNull(this string? date)
    {
        if (string.IsNullOrWhiteSpace(date))
            return null;

        return DateTime.Parse(date);
    }
    /// <summary>
    /// Check string for whitespace or null
    /// </summary>
    /// <param name="str"></param>
    /// <returns>
    /// String value when not whitespace
    /// <para>
    /// Null when only whitespace
    /// </para>
    /// </returns>
    public static string? ValueOrNull(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return null;

        return str;
    }
}