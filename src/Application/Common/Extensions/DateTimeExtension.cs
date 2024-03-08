using System.Diagnostics.CodeAnalysis;

namespace Application.Common.Extensions;

public static class DateTimeExtension
{
    /// <summary>
    /// Determines if <see cref="DateTime"/> has value then converts to string
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns>
    /// String when <see cref="DateTime"/> has value
    /// <para>
    /// Null when <see cref="DateTime"/> does not have value
    /// </para>
    /// </returns>
    public static string? ToStringOrNull(
        this DateTime? dateTime,
        [StringSyntax("DateTimeFormat")] string format)
    {
        if (!dateTime.HasValue)
            return null;

        return dateTime.Value.ToString(format);
    }
}