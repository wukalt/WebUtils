namespace WebUtils.Formatter;

public static class Formatter
{
    public static string FormatString(string text)
    {
        return text
            .Trim()
            .ToLower();
    }
}
