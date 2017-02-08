using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS_API.GetClientsProducts
{
    public class Customfields
    {

        [JsonProperty("customfield")]
        public IList<Customfield> CustomField { get; set; }
    }

    public class Customfield
	{
        [JsonProperty("id")]
		public string ID { get; set; }
        [JsonProperty("name")]
		public string Name { get; set; }
        [JsonProperty("translated_name")]
		public string TranslatedName { get; set; }
        [JsonProperty("value")]
		public string Value { get; set; }
	}

    public class Configoptions
    {

        [JsonProperty("configoption")]
        public IList<Configoption> ConfigOption { get; set; }
    }

    public class Configoption
	{
        [JsonProperty("id")]
		public string ID { get; set; }
        [JsonProperty("option")]
		public string Option { get; set; }
        [JsonProperty("type")]
		public string Type { get; set; }
        [JsonProperty("value")]
		public object Value { get; set; }
	}

    public class Product
    {

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("clientid")]
        public string ClientID { get; set; }

        [JsonProperty("orderid")]
        public string OrderID { get; set; }

        [JsonProperty("pid")]
        public string ProductID { get; set; }

        [JsonProperty("regdate")]
        public string RegistryDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("translated_name")]
        public string TranslatedName { get; set; }

        [JsonProperty("groupname")]
        public string GroupName { get; set; }

        [JsonProperty("translated_groupname")]
        public string TranslatedGroupName { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dedicatedip")]
        public string DedicatedIP { get; set; }

        [JsonProperty("serverid")]
        public string ServerID { get; set; }

        [JsonProperty("servername")]
        public string ServerName { get; set; }

        [JsonProperty("serverip")]
        public string ServerIP { get; set; }

        [JsonProperty("serverhostname")]
        public string ServerHostname { get; set; }

        [JsonProperty("suspensionreason")]
        public string SuspensionReason { get; set; }

        [JsonProperty("firstpaymentamount")]
        public string FirstPaymentAmount { get; set; }

        [JsonProperty("recurringamount")]
        public string RecurringAmount { get; set; }

        [JsonProperty("paymentmethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("paymentmethodname")]
        public string PaymentMethodName { get; set; }

        [JsonProperty("billingcycle")]
        public string BillingCycle { get; set; }

        [JsonProperty("nextduedate")]
        public string NextDueDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("subscriptionid")]
        public string Subscription { get; set; }

        [JsonProperty("promoid")]
        public string PromotionID { get; set; }

        [JsonProperty("overideautosuspend")]
        public string OverideAutoSuspend { get; set; }

        [JsonProperty("overidesuspenduntil")]
        public string OverideSuspendUntil { get; set; }

        [JsonProperty("ns1")]
        public string Nameserver1 { get; set; }

        [JsonProperty("ns2")]
        public string Nameserver2 { get; set; }

        [JsonProperty("assignedips")]
        public string AssignedIPs { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("diskusage")]
        public string DiskUsage { get; set; }

        [JsonProperty("disklimit")]
        public string DiskLimit { get; set; }

        [JsonProperty("bwusage")]
        public string BandwithUsage { get; set; }

        [JsonProperty("bwlimit")]
        public string BandwithLimit { get; set; }

        [JsonProperty("lastupdate")]
        public string LastUpdate { get; set; }

        [JsonProperty("customfields")]
        public Customfields CustomFields { get; set; }

        [JsonProperty("configoptions")]
        public Configoptions ConfigOptions { get; set; }
    }

    public class Products
    {

        [JsonProperty("product")]
        public IList<Product> Product { get; set; }
    }

    public class GetClientsProducts
    {

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("clientid")]
        public string ClientID { get; set; }

        [JsonProperty("serviceid")]
        public int ServiceID { get; set; }

        [JsonProperty("pid")]
        public int ProductID { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("totalresults")]
        public string TotalResults { get; set; }

        [JsonProperty("startnumber")]
        public int StartNumber { get; set; }

        [JsonProperty("numreturned")]
        public int NumberReturned { get; set; }

        [JsonProperty("products")]
        public Products Products { get; set; }
    }
}
