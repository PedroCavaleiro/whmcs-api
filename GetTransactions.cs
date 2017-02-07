using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS_API.GetTransactions
{
    public class Transaction
    {

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("userid")]
        public string UserID { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("gateway")]
        public string PaymentGateway { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("amountin")]
        public string AmountIn { get; set; }

        [JsonProperty("fees")]
        public string Fees { get; set; }

        [JsonProperty("amountout")]
        public string AmountOut { get; set; }

        [JsonProperty("rate")]
        public string Rate { get; set; }

        [JsonProperty("transid")]
        public string TransactionID { get; set; }

        [JsonProperty("invoiceid")]
        public string InvoiceID { get; set; }

        [JsonProperty("refundid")]
        public string RefundID { get; set; }
    }

    public class Transactions
    {

        [JsonProperty("transaction")]
        public IList<Transaction> Transaction { get; set; }
    }

    public class GetTransactions
    {

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("totalresults")]
        public int TotalResults { get; set; }

        [JsonProperty("startnumber")]
        public int StartNumber { get; set; }

        [JsonProperty("numreturned")]
        public int NumberReturned { get; set; }

        [JsonProperty("transactions")]
        public Transactions Transactions { get; set; }
    }

}
