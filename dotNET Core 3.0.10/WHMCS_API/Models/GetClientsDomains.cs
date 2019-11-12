using Newtonsoft.Json;
using System.Collections.Generic;

namespace WHMCS_API.Models.GetClientsDomains
{
    public class Domain
    {

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("userid")]
        public string UserID { get; set; }

        [JsonProperty("orderid")]
        public string OrderID { get; set; }

        [JsonProperty("regtype")]
        public string RegType { get; set; }

        [JsonProperty("domainname")]
        public string DomainName { get; set; }

        [JsonProperty("registrar")]
        public string Registrar { get; set; }

        [JsonProperty("regperiod")]
        public string RegPeriod { get; set; }

        [JsonProperty("firstpaymentamount")]
        public string FirstPaymentAmount { get; set; }

        [JsonProperty("recurringamount")]
        public string RecurringAmount { get; set; }

        [JsonProperty("paymentmethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("paymentmethodname")]
        public string PaymentMethodName { get; set; }

        [JsonProperty("regdate")]
        public string RegistryDate { get; set; }

        [JsonProperty("expirydate")]
        public string ExpiricyDate { get; set; }

        [JsonProperty("nextduedate")]
        public string NextDueDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subscriptionid")]
        public string Subscription { get; set; }

        [JsonProperty("promoid")]
        public string PromoID { get; set; }

        [JsonProperty("dnsmanagement")]
        public string DNSManagment { get; set; }

        [JsonProperty("emailforwarding")]
        public string EmailFowarding { get; set; }

        [JsonProperty("idprotection")]
        public string IDProtection { get; set; }

        [JsonProperty("donotrenew")]
        public string DoNotRenew { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class Domains
    {

        [JsonProperty("domain")]
        public IList<Domain> Domain { get; set; }
    }

    public class GetClientsDomains
    {

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("clientid")]
        public string ClientID { get; set; }

        [JsonProperty("domainid")]
        public string DomainID { get; set; }

        [JsonProperty("totalresults")]
        public string TotalResults { get; set; }

        [JsonProperty("startnumber")]
        public int StartNumber { get; set; }

        [JsonProperty("numreturned")]
        public int NumberReturned { get; set; }

        [JsonProperty("domains")]
        public Domains Domains { get; set; }
    }

}
