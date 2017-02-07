using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WHMCS_API
{
    public class Lineitem
    {

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("relid")]
        public string relid { get; set; }

        [JsonProperty("producttype")]
        public string producttype { get; set; }

        [JsonProperty("product")]
        public string product { get; set; }

        [JsonProperty("domain")]
        public string domain { get; set; }

        [JsonProperty("billingcycle")]
        public string billingcycle { get; set; }

        [JsonProperty("amount")]
        public string amount { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("dnsmanagement")]
        public string dnsmanagement { get; set; }

        [JsonProperty("emailforwarding")]
        public string emailforwarding { get; set; }

        [JsonProperty("idprotection")]
        public string idprotection { get; set; }
    }

    public class Lineitems
    {

        [JsonProperty("lineitem")]
        public IList<Lineitem> lineitem { get; set; }
    }

    public class Order
    {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("ordernum")]
        public string ordernum { get; set; }

        [JsonProperty("userid")]
        public string userid { get; set; }

        [JsonProperty("contactid")]
        public string contactid { get; set; }

        [JsonProperty("date")]
        public string date { get; set; }

        [JsonProperty("nameservers")]
        public string nameservers { get; set; }

        [JsonProperty("transfersecret")]
        public string transfersecret { get; set; }

        [JsonProperty("renewals")]
        public string renewals { get; set; }

        [JsonProperty("promocode")]
        public string promocode { get; set; }

        [JsonProperty("promotype")]
        public string promotype { get; set; }

        [JsonProperty("promovalue")]
        public string promovalue { get; set; }

        [JsonProperty("orderdata")]
        public string orderdata { get; set; }

        [JsonProperty("amount")]
        public string amount { get; set; }

        [JsonProperty("paymentmethod")]
        public string paymentmethod { get; set; }

        [JsonProperty("invoiceid")]
        public string invoiceid { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("ipaddress")]
        public string ipaddress { get; set; }

        [JsonProperty("fraudmodule")]
        public string fraudmodule { get; set; }

        [JsonProperty("fraudoutput")]
        public string fraudoutput { get; set; }

        [JsonProperty("notes")]
        public string notes { get; set; }

        [JsonProperty("paymentmethodname")]
        public string paymentmethodname { get; set; }

        [JsonProperty("paymentstatus")]
        public object paymentstatus { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("currencyprefix")]
        public string currencyprefix { get; set; }

        [JsonProperty("currencysuffix")]
        public string currencysuffix { get; set; }

        [JsonProperty("frauddata")]
        public string frauddata { get; set; }

        [JsonProperty("lineitems")]
        public Lineitems lineitems { get; set; }
    }

    public class Orders
    {

        [JsonProperty("order")]
        public IList<Order> order { get; set; }
    }

    public class GetOrders
    {

        [JsonProperty("result")]
        public string result { get; set; }

        [JsonProperty("totalresults")]
        public string totalresults { get; set; }

        [JsonProperty("startnumber")]
        public int startnumber { get; set; }

        [JsonProperty("numreturned")]
        public int numreturned { get; set; }

        [JsonProperty("orders")]
        public Orders orders { get; set; }
    }
}