using System.Security.Cryptography;
using System.Text;
using static WHMCS_API.Extensions.ByteArrExts;

namespace WHMCS_API.Cryptography
{
    public static class Hashing
    {
        public static string CalculateMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            
            return hash.ToHexString();
        }
    }
}
