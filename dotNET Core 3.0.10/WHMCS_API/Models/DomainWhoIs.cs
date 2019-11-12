using Newtonsoft.Json;

namespace WHMCS_API.Models
{
    public class DomainWhoIs
    {

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("whois")]
        public string WhoIs { get; set; }
    }
}
