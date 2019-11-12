using Newtonsoft.Json;
using System.Collections.Generic;

namespace WHMCS_API.Models.GetOrders
{
    public class Lineitem
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("relid")]
        public string relid { get; set; }

        [JsonProperty("producttype")]
        public string ProductType { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("billingcycle")]
        public string BillingCycle { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dnsmanagement")]
        public string DNSManagment { get; set; }

        [JsonProperty("emailforwarding")]
        public string EmailFowarding { get; set; }

        [JsonProperty("idprotection")]
        public string IDProtection { get; set; }
    }

    public class Lineitems
    {

        [JsonProperty("lineitem")]
        public IList<Lineitem> LineItem { get; set; }
    }

    public class Order
    {

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("ordernum")]
        public string OrderNumber { get; set; }

        [JsonProperty("userid")]
        public string UserID { get; set; }

        [JsonProperty("contactid")]
        public string ContactID { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("nameservers")]
        public string NameServers { get; set; }

        [JsonProperty("transfersecret")]
        public string TransfererSecret { get; set; }

        [JsonProperty("renewals")]
        public string RenewalsSecret { get; set; }

        [JsonProperty("promocode")]
        public string PromoCode { get; set; }

        [JsonProperty("promotype")]
        public string PromoType { get; set; }

        [JsonProperty("promovalue")]
        public string PromoValue { get; set; }

        [JsonProperty("orderdata")]
        public string OrderData { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("paymentmethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("invoiceid")]
        public string InvoiceID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ipaddress")]
        public string IPAddress { get; set; }

        [JsonProperty("fraudmodule")]
        public string FraudModule { get; set; }

        [JsonProperty("fraudoutput")]
        public string FraudOutput { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("paymentmethodname")]
        public string PaymentMethodName { get; set; }

        [JsonProperty("paymentstatus")]
        public object PaymentStatus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("currencyprefix")]
        public string CurrencyPrefix { get; set; }

        [JsonProperty("currencysuffix")]
        public string CurrencySuffix { get; set; }

        [JsonProperty("frauddata")]
        public string FraudData { get; set; }

        [JsonProperty("lineitems")]
        public Lineitems LineItems { get; set; }
    }

    public class Orders
    {

        [JsonProperty("order")]
        public IList<Order> Order { get; set; }
    }

    public class GetOrders
    {

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("totalresults")]
        public string TotalResults { get; set; }

        [JsonProperty("startnumber")]
        public int StartNumber { get; set; }

        [JsonProperty("numreturned")]
        public int NumberReturned { get; set; }

        [JsonProperty("orders")]
        public Orders Orders { get; set; }
    }
}