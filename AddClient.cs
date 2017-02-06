using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS_API
{
    /// <summary>
    /// Params info @ https://developers.whmcs.com/api-reference/addclient/
    /// </summary>
    public class AddClient
    {
        public readonly NameValueCollection ClientInfo;
        public AddClient(string Firstname, string Lastname, string Email, string Address1,
            string City, string State, string PostCode, string CountryCode, string PhoneNumber,
            string Password, bool NoEmail = false, string CompanyName = "", string Address2 = "",
            int SecurityQuestionID = -1, string SecurityQuestionAnswer = "", string CardType = "",
            string CardNumber = "", string ExpiricyDate = "", string StartDate = "",
            string IssueNumber = "", string CVV = "", int Currency = -1, int GroupID = -1,
            string CustomFields = "", string Language = "", string ClientIP = "", string Notes = "")
        {
            ClientInfo = new NameValueCollection()
            {
                { EnumUtil.GetString(APIEnums.AddClientParams.Firstname), Firstname },
                { EnumUtil.GetString(APIEnums.AddClientParams.Lastname), Lastname },
                { EnumUtil.GetString(APIEnums.AddClientParams.Email), Email },
                { EnumUtil.GetString(APIEnums.AddClientParams.Address1), Address1 },
                { EnumUtil.GetString(APIEnums.AddClientParams.City), City },
                { EnumUtil.GetString(APIEnums.AddClientParams.State), State },
                { EnumUtil.GetString(APIEnums.AddClientParams.Postcode), PostCode },
                { EnumUtil.GetString(APIEnums.AddClientParams.CountryCode), CountryCode },
                { EnumUtil.GetString(APIEnums.AddClientParams.PhoneNumber), PhoneNumber },
                { EnumUtil.GetString(APIEnums.AddClientParams.Password), Password },
                { EnumUtil.GetString(APIEnums.AddClientParams.NoEmail), NoEmail.ToString() }
            };
            if (CompanyName != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CompanyName), CompanyName);
            if (Address2 != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Address2), Address2);
            if (SecurityQuestionID != -1)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.SecurityQuestionID), SecurityQuestionID.ToString());
            if (SecurityQuestionAnswer != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.SecurityQuestionAnswer), SecurityQuestionAnswer);
            if (CardType != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CardType), CardType);
            if (CardNumber != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CardNumber), CardNumber);
            if (ExpiricyDate != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.ExpiricyDate), ExpiricyDate);
            if (StartDate != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.StartDate), StartDate);
            if (IssueNumber != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.IssueNumber), IssueNumber);
            if (CVV != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CVV), CVV);
            if (Currency != -1)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Currency), Currency.ToString());
            if(GroupID != -1)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.GroupID), GroupID.ToString());
            if (CustomFields != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CustomFields), CustomFields);
            if (Language != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Language), Language);
            if (ClientIP != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.ClientIP), ClientIP);
            if (Notes != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Notes), Notes);
        }
    }
}
