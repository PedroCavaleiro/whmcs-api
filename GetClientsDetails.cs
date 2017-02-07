using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WHMCS_API
{
    public class Client
    {

        [JsonProperty("userid")]
        public int UserID { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("companyname")]
        public string CompanyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("fullstate")]
        public string FullState { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postcode")]
        public string PostCode { get; set; }

        [JsonProperty("countrycode")]
        public string CountryCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("countryname")]
        public string CountryName { get; set; }

        [JsonProperty("phonecc")]
        public int PhoneCC { get; set; }

        [JsonProperty("phonenumberformatted")]
        public string PhoneNumberFormatted { get; set; }

        [JsonProperty("billingcid")]
        public int BillingCID { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("twofaenabled")]
        public bool TwoFactorEnabled { get; set; }

        [JsonProperty("currency")]
        public int Currency { get; set; }

        [JsonProperty("defaultgateway")]
        public string DefaultGateway { get; set; }

        [JsonProperty("cctype")]
        public string CreditCardType { get; set; }

        [JsonProperty("cclastfour")]
        public string CreditCardLastFourDigits { get; set; }

        [JsonProperty("securityqid")]
        public int SecurityQuestionID { get; set; }

        [JsonProperty("securityqans")]
        public string SecurityQuestionAnswer { get; set; }

        [JsonProperty("groupid")]
        public int GroupID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("credit")]
        public string Credit { get; set; }

        [JsonProperty("taxexempt")]
        public bool TexExempt { get; set; }

        [JsonProperty("latefeeoveride")]
        public bool LateFeeOveride { get; set; }

        [JsonProperty("overideduenotices")]
        public bool OverideDueNotices { get; set; }

        [JsonProperty("separateinvoices")]
        public bool SeparateInvoices { get; set; }

        [JsonProperty("disableautocc")]
        public bool DisableAutoCC { get; set; }

        [JsonProperty("emailoptout")]
        public bool EmailOptOut { get; set; }

        [JsonProperty("overrideautoclose")]
        public bool OverideAutoClose { get; set; }

        [JsonProperty("allowSingleSignOn")]
        public int AllowSingleSignOn { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lastlogin")]
        public string LastLogin { get; set; }

        [JsonProperty("currency_code")]
        public string Currency_Code { get; set; }
    }

    public class Stats
    {

        [JsonProperty("numdueinvoices")]
        public string NumberDueInvoices { get; set; }

        [JsonProperty("dueinvoicesbalance")]
        public string DueInvoicesBalance { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("incredit")]
        public bool InCredit { get; set; }

        [JsonProperty("creditbalance")]
        public string CreditBalance { get; set; }

        [JsonProperty("numoverdueinvoices")]
        public int NumberOverdueInvoices { get; set; }

        [JsonProperty("overdueinvoicesbalance")]
        public string OverudeInvoicesBalance { get; set; }

        [JsonProperty("numDraftInvoices")]
        public int NumDraftInvoices { get; set; }

        [JsonProperty("draftInvoicesBalance")]
        public string DraftInvoicesBalance { get; set; }

        [JsonProperty("numpaidinvoices")]
        public string NumPaidInvoices { get; set; }

        [JsonProperty("paidinvoicesamount")]
        public string PaidInvoicesAmount { get; set; }

        [JsonProperty("numunpaidinvoices")]
        public int NumUnpaidInvoices { get; set; }

        [JsonProperty("unpaidinvoicesamount")]
        public string UnPaidInvoicesAmount { get; set; }

        [JsonProperty("numcancelledinvoices")]
        public int numcancelledinvoices { get; set; }

        [JsonProperty("cancelledinvoicesamount")]
        public string CancelledInvoicesAmount { get; set; }

        [JsonProperty("numrefundedinvoices")]
        public int NumRefundedInvoices { get; set; }

        [JsonProperty("refundedinvoicesamount")]
        public string RefundedInvoicesAmount { get; set; }

        [JsonProperty("numcollectionsinvoices")]
        public int NumCollectionsInvoices { get; set; }

        [JsonProperty("collectionsinvoicesamount")]
        public string CollectionsInvoicesAmount { get; set; }

        [JsonProperty("productsnumactivehosting")]
        public string ProductsNumActiveHosting { get; set; }

        [JsonProperty("productsnumhosting")]
        public int ProductsNumHosting { get; set; }

        [JsonProperty("productsnumactivereseller")]
        public int ProductsNumActiveReseller { get; set; }

        [JsonProperty("productsnumreseller")]
        public int ProductNumReseller { get; set; }

        [JsonProperty("productsnumactiveservers")]
        public int ProductsNumActiveServers { get; set; }

        [JsonProperty("productsnumservers")]
        public int ProductsNumServers { get; set; }

        [JsonProperty("productsnumactiveother")]
        public int ProductsNumActiveOther { get; set; }

        [JsonProperty("productsnumother")]
        public int ProductsOther { get; set; }

        [JsonProperty("productsnumactive")]
        public int ProductsNumActive { get; set; }

        [JsonProperty("productsnumtotal")]
        public int ProductsNumTotal { get; set; }

        [JsonProperty("numactivedomains")]
        public int NumActiveDomains { get; set; }

        [JsonProperty("numdomains")]
        public int NumDomains { get; set; }

        [JsonProperty("numacceptedquotes")]
        public int NumAcceptedQuotes { get; set; }

        [JsonProperty("numquotes")]
        public int NumQuotes { get; set; }

        [JsonProperty("numtickets")]
        public int NumTickets { get; set; }

        [JsonProperty("numactivetickets")]
        public int NumActiveTickets { get; set; }

        [JsonProperty("numaffiliatesignups")]
        public string NumAffiliateSignups { get; set; }

        [JsonProperty("isAffiliate")]
        public bool IsAffiliate { get; set; }
    }

    public class GetClientsDetails
    {

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("client")]
        public Client Client { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }
}