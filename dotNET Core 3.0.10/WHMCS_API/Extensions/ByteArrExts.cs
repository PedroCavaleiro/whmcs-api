using System.Text;

namespace WHMCS_API.Extensions
{
    public static class ByteArrExts
    {
        public static string ToHexString(this byte[] barray)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte t in barray)
            {
                sb.Append(t.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
