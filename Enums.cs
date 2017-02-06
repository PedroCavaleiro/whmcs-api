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

        /// <summary>
        /// Actions Supported by the WHMCS API that are implemented in this Wrapper
        /// </summary>
        public enum Actions
        {
            [StringValue("ValidateLogin")] ValidateLogin,
            [StringValue("DomainWhois")] DomainWhois,
            [StringValue("AddClient")] AddClient,
            [StringValue("GetClientsDetails")] GetClientsDetails
        }
    }

    /// <summary>
    /// Creastes an attribute called StringValue
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
        /// <summary>
        /// Gets the string out of the enum
        /// </summary>
        /// <param name="value">The enum from witch will be extracted the string</param>
        /// <returns>The string associated with the value enum</returns>
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


