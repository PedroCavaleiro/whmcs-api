using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS_API
{
    public static class APIEnums  
    {
        public enum ValidateLoginParams
        {
            [StringValue("email")] Email,
            [StringValue("password2")] Password
        }        

        public enum DomainWhoisParams
        {
            [StringValue("domain")] Domain
        }
        
        public enum AddClientParams
        {
            [StringValue("firstname")] Firstname,
            [StringValue("lastname")] Lastname,
            [StringValue("email")] Email,
            [StringValue("address1")] Address1,
            [StringValue("city")] City,
            [StringValue("state")] State,
            [StringValue("postcode")] Postcode,
            [StringValue("countrycode")] CountryCode,
            [StringValue("phonenumber")] PhoneNumber,
            [StringValue("password2")] Password,
            [StringValue("noemail")] NoEmail,
            [StringValue("companyname")] CompanyName,
            [StringValue("address2")] Address2,
            [StringValue("securityqid")] SecurityQuestionID,
            [StringValue("securityqans")] SecurityQuestionAnswer,
            [StringValue("cardtype")] CardType,
            [StringValue("cardnum")] CardNumber,
            [StringValue("expdate")] ExpiricyDate,
            [StringValue("startdate")] StartDate,
            [StringValue("issuenumber")] IssueNumber,
            [StringValue("cvv")] CVV,
            [StringValue("currency")] Currency,
            [StringValue("groupid")] GroupID,
            [StringValue("customfields")] CustomFields,
            [StringValue("language")] Language,
            [StringValue("clientip")] ClientIP,
            [StringValue("notes")] Notes,
            [StringValue("skipvalidation")] SkipValidation
        }

        public enum GetClientsDetailsParams
        {
            [StringValue("clientid")] ClientID,
            [StringValue("email")] Email,
            [StringValue("stats")] Stats
        }

        public enum GetOrdersParams
        {
            [StringValue("limitstart")] LimitStart,
            [StringValue("limitnum")] LimitNumber,
            [StringValue("id")] OrderID,
            [StringValue("userid")] UserID,
            [StringValue("status")] Status
        }

        public enum GetTransactionsParams
        {
            [StringValue("invoiceid")] InvoiceID,
            [StringValue("clientid")] ClientID,
            [StringValue("transid")] TransactionID
        }

        public enum GetClientsProductsParams
        {
            [StringValue("limitstart")] ResultsStartOffset,
            [StringValue("limitnum")] ResultsLimit,
            [StringValue("clientid")] ClientID,
            [StringValue("serviceid")] ServiceID,
            [StringValue("pid")] ProductID,
            [StringValue("domain")] Domain,
            [StringValue("username2")] Username
        }

        public enum GetInvoicesParams
        {
            [StringValue("limitstart")] LimitStart,
            [StringValue("limitnum")] LimitNumber,
            [StringValue("userid")] UserID,
            [StringValue("status")] Status
        }

        public enum GetInvoiceParams
        {
            [StringValue("invoiceid")] InvoiceID
        }

        public enum GetClientsDomainsParams
        {
            [StringValue("limitstart")] LimitStart,
            [StringValue("limitnum")] LimitNumber,
            [StringValue("clientid")] ClientID,
            [StringValue("domainid")] DomainID,
            [StringValue("domain")] Domain
        }

        /// <summary>
        /// Actions Supported by the WHMCS API that are implemented in this Wrapper
        /// </summary>
        public enum Actions
        {
            [StringValue("ValidateLogin")] ValidateLogin,
            [StringValue("DomainWhois")] DomainWhois,
            [StringValue("AddClient")] AddClient,
            [StringValue("GetClientsDetails")] GetClientsDetails,
            [StringValue("GetOrders")] GetOrders,
            [StringValue("GetTransactions")] GetTransactions,
            [StringValue("GetClientsProducts")] GetClientsProducts,
            [StringValue("GetInvoices")] GetInvoices,
            [StringValue("GetInvoice")] GetInvoice,
            [StringValue("GetClientsDomains")] GetClientsDomains
        }
    }

    /// <summary>
    /// Creates an attribute called StringValue
    /// </summary>
    public class StringValue : Attribute
    {
        private readonly string _value;

        public StringValue(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }        

    }

    /// <summary>
    /// Used to get the string out of the Enum
    /// </summary>
    public static class EnumUtil
    {
        public static string GetString(Enum value)
        {
            string output = null;
            Type type = value.GetType();

            FieldInfo fi = type.GetField(value.ToString());
            StringValue[] attrs =
               fi.GetCustomAttributes(typeof(StringValue),
                                       false) as StringValue[];
            if (attrs.Length > 0)
            {
                output = attrs[0].Value;
            }

            return output;
        }
    }

}


