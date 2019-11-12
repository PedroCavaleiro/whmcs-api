using Newtonsoft.Json;

namespace WHMCS_API.Models.ValidateLogin
{
    public class ValidateLogin
    {

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("userid")]
        public int UserID { get; set; }

        [JsonProperty("contactid")]
        public int ContactID { get; set; }

        [JsonProperty("passwordhash")]
        public string PasswordHash { get; set; }
    }
}
