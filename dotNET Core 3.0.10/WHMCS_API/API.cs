using System;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WHMCS_API.Models;
using WHMCS_API.Models.GetClientsDetails;
using WHMCS_API.Models.GetClientsDomains;
using WHMCS_API.Models.GetClientsProducts;
using WHMCS_API.Models.GetInvoice;
using WHMCS_API.Models.GetInvoices;
using WHMCS_API.Models.GetOrders;
using WHMCS_API.Models.GetTransactions;
using WHMCS_API.Models.UpdateClientProduct;
using WHMCS_API.Models.ValidateLogin;

namespace WHMCS_API
{
    public class API
    {
        private readonly JsonSerializerSettings Settings;
        private readonly Call Call;

        public API(string Username, string Password, string AccessKey, string Url)
        {
            Call = new Call(Username, Password, AccessKey, Url);
            Settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
        }

        public ValidateLogin ValidateLogin(string Email, string Password)
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", APIEnums.Actions.ValidateLogin.ToString() },
                { EnumUtil.GetString(APIEnums.ValidateLoginParams.Email), Email },
                { EnumUtil.GetString(APIEnums.ValidateLoginParams.Password), Password }
            };

            string req = Call.MakeCall(data);
            JObject result = JObject.Parse(req);

            if (result["result"].ToString() == "success")
                return JsonConvert.DeserializeObject<ValidateLogin>(req, Settings);
            else
                throw new Exception("An API Error Ocurred", new Exception(result["message"].ToString()));
        }

        public DomainWhoIs DomainWhoIs(string Domain)
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", APIEnums.Actions.DomainWhois.ToString() },
                { EnumUtil.GetString(APIEnums.DomainWhoisParams.Domain), Domain },
            };

            string req = Call.MakeCall(data);
            JObject result = JObject.Parse(req);

            if (result["result"].ToString() == "success")
                return JsonConvert.DeserializeObject<DomainWhoIs>(req, Settings);
            else
                throw new Exception("An API Error Ocurred", new Exception(result["message"].ToString()));

        }

        public int AddClient(AddClient ClientInfo)
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", APIEnums.Actions.AddClient.ToString() }
            };

            //Processes all the data in ClientInfo model into the data NameValueCollection
            foreach (string key in ClientInfo.ClientInfo)
            {
                data.Add(key, ClientInfo.ClientInfo[key]);
            }

            JObject result = JObject.Parse(Call.MakeCall(data));

            if (result["result"].ToString() == "success")
                return Convert.ToInt32(result["clientid"]);
            else
                throw new Exception("An API Error Ocurred", new Exception(result["message"].ToString()));

        }

        public GetClientsDetails GetClientsDetails(int ClientID = -1, string ClientEmail = "", bool Stats = false)
        {
            if (ClientID == -1 && ClientEmail == "")
                throw new Exception("ClientID or ClientEmail needed");

            NameValueCollection data = new NameValueCollection()
            {
                { "action", APIEnums.Actions.GetClientsDetails.ToString() },
                { EnumUtil.GetString(APIEnums.GetClientsDetailsParams.Stats), Stats.ToString() },
            };
            if (ClientID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetClientsDetailsParams.ClientID), ClientID.ToString());
            if (ClientEmail != "" && ClientID == -1)
                data.Add(EnumUtil.GetString(APIEnums.GetClientsDetailsParams.Email), ClientEmail);

            string req = Call.MakeCall(data);
            JObject result = JObject.Parse(req);
            if (result["result"].ToString() == "success")
                return JsonConvert.DeserializeObject<GetClientsDetails>(req, Settings);
            else
                throw new Exception("An API Error occurred", new Exception(result["message"].ToString()));
        }

        public GetOrders GetOrders(int LimitStart = 0, int LimitNumber = 25, int OrderID = -1, int UserID = -1, string Status = "")
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", APIEnums.Actions.GetOrders.ToString() },
                { EnumUtil.GetString(APIEnums.GetOrdersParams.LimitStart), LimitStart.ToString() },
                { EnumUtil.GetString(APIEnums.GetOrdersParams.LimitNumber), LimitNumber.ToString() }
            };
            if (OrderID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetOrdersParams.OrderID), OrderID.ToString());
            if (UserID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetOrdersParams.UserID), UserID.ToString());
            if (Status != "")
                data.Add(EnumUtil.GetString(APIEnums.GetOrdersParams.Status), Status);

            return JsonConvert.DeserializeObject<GetOrders>(Call.MakeCall(data), Settings);
        }

        public GetTransactions GetTransactions(int InvoiceID = -1, int ClientID = -1, string TransactionID = "")
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", APIEnums.Actions.GetTransactions.ToString() }
            };
            if (InvoiceID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetTransactionsParams.InvoiceID), InvoiceID.ToString());
            if (ClientID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetTransactionsParams.ClientID), ClientID.ToString());
            if (TransactionID != "")
                data.Add(EnumUtil.GetString(APIEnums.GetTransactionsParams.TransactionID), TransactionID);

            return JsonConvert.DeserializeObject<GetTransactions>(Call.MakeCall(data), Settings);
        }

        public GetClientsProducts GetClientsProducts(int LimitStart = 0, int LimitNum = 25, int ClientID = -1, int ServiceID = -1, int ProductID = -1, string Domain = "", string Username = "")
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", APIEnums.Actions.GetClientsProducts.ToString() },
                { EnumUtil.GetString(APIEnums.GetClientsProductsParams.ResultsStartOffset), LimitStart.ToString()},
                { EnumUtil.GetString(APIEnums.GetClientsProductsParams.ResultsLimit), LimitNum.ToString()},
            };

            if (ClientID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetClientsProductsParams.ClientID), ClientID.ToString());
            if (ServiceID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetClientsProductsParams.ServiceID), ServiceID.ToString());
            if (ProductID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetClientsProductsParams.ProductID), ProductID.ToString());
            if (Domain != "")
                data.Add(EnumUtil.GetString(APIEnums.GetClientsProductsParams.Domain), Domain);
            if (Username != "")
                data.Add(EnumUtil.GetString(APIEnums.GetClientsProductsParams.Username), Username);

            return JsonConvert.DeserializeObject<GetClientsProducts>(Call.MakeCall(data), Settings);
        }

        public GetInvoices GetInvoices(int LimitStart = 0, int LimitNumber = 25, int UserID = -1, string Status = "")
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", APIEnums.Actions.GetInvoices.ToString() },
                { EnumUtil.GetString(APIEnums.GetInvoicesParams.LimitStart), LimitStart.ToString() },
                { EnumUtil.GetString(APIEnums.GetInvoicesParams.LimitNumber), LimitNumber.ToString() }
            };
            if (UserID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetInvoicesParams.UserID), UserID.ToString());
            if (Status != "")
                data.Add(EnumUtil.GetString(APIEnums.GetInvoicesParams.Status), Status);

            return JsonConvert.DeserializeObject<GetInvoices>(Call.MakeCall(data), Settings);
        }

        public GetInvoice GetInvoice(int InvoiceID)
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", EnumUtil.GetString(APIEnums.Actions.GetInvoice) },
                { EnumUtil.GetString(APIEnums.GetInvoiceParams.InvoiceID), InvoiceID.ToString() }
            };

            string req = Call.MakeCall(data);

            JObject result = JObject.Parse(req);

            if (result["result"].ToString() == "success")
                return JsonConvert.DeserializeObject<GetInvoice>(req, Settings);
            else
                throw new Exception("An API Error Ocurred", new Exception(result["message"].ToString()));

        }

        public GetClientsDomains GetClientsDomains(int LimitStart = 0, int LimitNumber = 25, int ClientID = -1, int DomainID = -1, string Domain = "")
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", EnumUtil.GetString(APIEnums.Actions.GetClientsDomains) },
                { EnumUtil.GetString(APIEnums.GetClientsDomainsParams.LimitStart), LimitStart.ToString() },
                { EnumUtil.GetString(APIEnums.GetClientsDomainsParams.LimitNumber), LimitNumber.ToString() }
            };

            if (ClientID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetClientsDomainsParams.ClientID), ClientID.ToString());
            if (DomainID != -1)
                data.Add(EnumUtil.GetString(APIEnums.GetClientsDomainsParams.DomainID), DomainID.ToString());
            if (Domain != "")
                data.Add(EnumUtil.GetString(APIEnums.GetClientsDomainsParams.Domain), Domain);

            return JsonConvert.DeserializeObject<GetClientsDomains>(Call.MakeCall(data), Settings);
        }

        public bool ModuleChangePassword(int ServiceID, string NewPassword, bool getException = true)
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", EnumUtil.GetString(APIEnums.Actions.ModuleChangePassword) },
                { EnumUtil.GetString(APIEnums.ModuleChangePasswordParams.ServiceID), ServiceID.ToString() },
                { EnumUtil.GetString(APIEnums.ModuleChangePasswordParams.NewPassword), NewPassword }
            };

            JObject result = JObject.Parse(Call.MakeCall(data));

            if (result["result"].ToString() == "success")
                return true;
            else if (result["result"].ToString() != "success" && getException)
                throw new Exception("An API Error Ocurred", new Exception(result["message"].ToString()));
            return false;
        }

        public bool ModuleCustomCommand(int ServiceID, string Command, bool getException = true)
        {
            NameValueCollection data = new NameValueCollection()
            {
                { "action", EnumUtil.GetString(APIEnums.Actions.ModuleCustomCommand) },
                { EnumUtil.GetString(APIEnums.ModuleCustomCommandParams.ServiceID), ServiceID.ToString() },
                { EnumUtil.GetString(APIEnums.ModuleCustomCommandParams.Command), Command }
            };

            JObject result = JObject.Parse(Call.MakeCall(data));

            if (result["result"].ToString() == "success")
                return true;
            else if (result["result"].ToString() != "success" && getException)
                throw new Exception("An API Error Ocurred", new Exception(result["message"].ToString()));
            return false;

        }

        public bool UpdateClientProduct(UpdateClientProduct ClientProductUpdateInfo)
        {

            JObject result = JObject.Parse(Call.MakeCall(ClientProductUpdateInfo.nvm));

            if (result["result"].ToString() == "success")
                return true;
            else
                throw new Exception("An API Error Ocurred", new Exception(result["message"].ToString()));

        }

    }
}
