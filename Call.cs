using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS_API
{
    public class Call
    {
        private readonly string Username;
        private readonly string Password;
        private readonly string AccessKey;
        private readonly string Url;

        /// <summary>
        /// Prepare the call of the API
        /// </summary>
        /// <param name="Username">API Username</param>
        /// <param name="Password">API Password</param>
        /// <param name="AccessKey">API AccessKey (must be set in config.php)</param>
        /// <param name="Url">WHMCS User Front End URL (ex: https://example.com/client)</param>
        public Call(string Username, string Password, string AccessKey, string Url)
        {
            this.Username = Username;
            this.Password = CalculateMD5Hash(Password);
            this.AccessKey = AccessKey;
            this.Url = Url + "/includes/api.php";
        }

        private NameValueCollection BuildRequestData(NameValueCollection data)
        {
            
            NameValueCollection request = new NameValueCollection()
            {
                { "username", Username},
                { "password", Password},
                { "accesskey", AccessKey },
                { "responsetype", "json"}
            };

            foreach(string key in data)
            {
                request.Add(key, data[key]);
            }

            return request;
        }

        public string MakeCall(NameValueCollection data)
        {
            byte[] webResponse;

            try
            {
                webResponse = new WebClient().UploadValues(Url, BuildRequestData(data));

            }
            catch (Exception ex)
            {
                throw new Exception("Unable to connect to WHMCS API. " + ex.Message.ToString());
            }

            return Encoding.ASCII.GetString(webResponse);
        }

        private string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            foreach (byte t in hash)
            {
                sb.Append(t.ToString("x2"));
            }
            return sb.ToString();
        }
        
    }
}
