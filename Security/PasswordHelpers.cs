using System.Text;
using System.Security.Cryptography;

namespace WebUtils.Security;

public static class PasswordHelpers
{
    public static string EncodePasswordMD5(string password)
    {
        byte[] originalBytes;
        byte[] encodedBytes;

        MD5 mD5 = MD5.Create();

        originalBytes = Encoding.Default.GetBytes(password);
        encodedBytes = mD5.ComputeHash(originalBytes);

        return BitConverter.ToString(encodedBytes);
    }
}
