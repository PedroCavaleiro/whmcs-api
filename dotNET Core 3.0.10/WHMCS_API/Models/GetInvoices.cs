using Newtonsoft.Json;
using System.Collections.Generic;

namespace WHMCS_API.Models.GetInvoices
{
    public class Invoice
    {

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("userid")]
        public string UserID { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("companyname")]
        public string CompanyName { get; set; }

        [JsonProperty("invoicenum")]
        public string InvoiceNumber { get; set; }

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

        [JsonProperty("currencycode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currencyprefix")]
        public string CurrencyPrefix { get; set; }

        [JsonProperty("currencysuffix")]
        public string CurrencySuffix { get; set; }
    }

    public class Invoices
    {

        [JsonProperty("invoice")]
        public IList<Invoice> Invoice { get; set; }
    }

    public class GetInvoices
    {

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("totalresults")]
        public string TotalResults { get; set; }

        [JsonProperty("startnumber")]
        public int StartNumber { get; set; }

        [JsonProperty("numreturned")]
        public int NumberReturned { get; set; }

        [JsonProperty("invoices")]
        public Invoices Invoices { get; set; }
    }
}
