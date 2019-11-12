namespace WHMCS_API.Extensions
{
    public static class StringExts
    {
        public static string EncodeToBase64(this string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
