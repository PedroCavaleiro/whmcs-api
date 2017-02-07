using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS_API
{
    public class Transaction
    {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("userid")]
        public string userid { get; set; }

        [JsonProperty("currency")]
        public string currency { get; set; }

        [JsonProperty("gateway")]
        public string gateway { get; set; }

        [JsonProperty("date")]
        public string date { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("amountin")]
        public string amountin { get; set; }

        [JsonProperty("fees")]
        public string fees { get; set; }

        [JsonProperty("amountout")]
        public string amountout { get; set; }

        [JsonProperty("rate")]
        public string rate { get; set; }

        [JsonProperty("transid")]
        public string transid { get; set; }

        [JsonProperty("invoiceid")]
        public string invoiceid { get; set; }

        [JsonProperty("refundid")]
        public string refundid { get; set; }
    }

    public class Transactions
    {

        [JsonProperty("transaction")]
        public IList<Transaction> transaction { get; set; }
    }

    public class GetTransactions
    {

        [JsonProperty("result")]
        public string result { get; set; }

        [JsonProperty("totalresults")]
        public int totalresults { get; set; }

        [JsonProperty("startnumber")]
        public int startnumber { get; set; }

        [JsonProperty("numreturned")]
        public int numreturned { get; set; }

        [JsonProperty("transactions")]
        public Transactions transactions { get; set; }
    }

}
