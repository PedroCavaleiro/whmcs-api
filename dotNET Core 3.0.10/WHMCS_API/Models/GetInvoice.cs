using Newtonsoft.Json;
using System.Collections.Generic;

namespace WHMCS_API.Models.GetInvoice
{
    public class Item
    {

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("relid")]
        public string relid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("taxed")]
        public string Taxed { get; set; }
    }

    public class Items
    {

        [JsonProperty("item")]
        public IList<Item> Item { get; set; }
    }

    public class Transaction
    {

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("userid")]
        public string UserID { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

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

    public class GetInvoice
    {

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("invoiceid")]
        public string InvoiceID { get; set; }

        [JsonProperty("invoicenum")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("userid")]
        public string UserID { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("duedate")]
        public string DueDate { get; set; }

        [JsonProperty("datepaid")]
        public string DatePaid { get; set; }

        [JsonProperty("subtotal")]
        public string SubTotal { get; set; }

        [JsonProperty("credit")]
        public string Credit { get; set; }

        [JsonProperty("tax")]
        public string Tax { get; set; }

        [JsonProperty("tax2")]
        public string Tax2 { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("taxrate")]
        public string TaxRate { get; set; }

        [JsonProperty("taxrate2")]
        public string TaxRate2 { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("paymentmethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("ccgateway")]
        public bool CCGateway { get; set; }

        [JsonProperty("items")]
        public Items Items { get; set; }

        [JsonProperty("transactions")]
        public Transactions Transactions { get; set; }
    }
}
