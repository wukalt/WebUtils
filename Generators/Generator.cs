namespace WebUtils.Generators;

public static class Generator
{
    public static string GenerateUniqName()
    {
        return Guid.NewGuid()
            .ToString()
            .Replace("-", "");
    }
}
