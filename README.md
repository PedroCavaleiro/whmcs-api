# WHMCS API C# Wrapper

This is an library to comunicate with the WHMCS API<br/>
Currently these functions are already implemented

<ul>
  <li>Add Client</li>
  <li>Domain WhoIs</li>
  <li>Get Client Details</li>
  <li>Validate Login</li>
  <li>GetTransactions</li>
  <li>GetOrders</li>
  <li>GetClientsProducts</li>
</ul>

[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=A3JFH2WA6U9YU)

The implemented functions are designed to be very easy to use
The following code demonstrates to to implement the GetClientDetails on an ASP.net MVC app

```
using WHMCS-API;
namespace YOUR_APP
{
    public class YOUR_CLASS
    {
        [HttpPost]
        public ActionResult ClientDetails(int clientID)
        {
            string username = "WHMCS_USERNAME";
            string password = "WHMCS_PASSWORD";
            string accessKey = "WHNMCS_ACCESS_KEY";
            string whmcsUrl = "WHMCS_USERFRONTEND_URL"; //ex: https://example.com/client
            API api = new API(username, password, accessKey, whmcsUrl);
            ViewBag.UserDetails = api.GetClientsDetails(clientID, Stats: true); //The model passed is of type GetClientsDetails
            return View();
        }
    }
}
```

You can still use this library to call non implemented functions by using the following code

```
using WHMCS-API.Call;
using System.Collections.Specialized;
using Newtonsoft.Json; //Not necessary but recommended as the call returns a JSON String

namespace YOUR_APP
{
    public class YOUR_CLASS
    {
        //The function can be private or public and does not need to return anything or can even return an string or any other type
        public YourModel yourFunction()
        {
            Call _call = new Call(WHMCS_API_USERNAME, WHMCS_API_PASSWORD, WHMCS_API_ACCESSKEY, WHMCS_USER_FRONTEND_URL);
            NameValueCollection data = new NameValueCollection()
            {
                { "action", "ModuleChangePackage " },
                { "accountid", "1" }
            };

            return JsonConvert.DeserializeObject<YourModel>(_call.MakeCall(data));
        }
    }
}
```

You can also create custom functions of already implemented functions.<br />
In this example i'm gonna show how to use the login function

```
using WHMCS-API;
using WHMCS-API.Call;
using System.Collections.Specialized;
using Newtonsoft.Json; //Not necessary but recommended as the call returns a JSON String

namespace YOUR_APP
{
    public class YOUR_CLASS
    {
        //The function can be private or public and does not need to return anything or can even return an string or any other type
        public void _Login()
        {
            Call _call = new Call(WHMCS_API_USERNAME, WHMCS_API_PASSWORD, WHMCS_API_ACCESSKEY, WHMCS_USER_FRONTEND_URL);
            NameValueCollection data = new NameValueCollection()
            {
                { "action", EnumUtil.GetString(APIEnums.Actions.ValidateLogin) },
                { EnumUtil.GetString(APIEnums.ValidateLoginParams.Email), Email },
                { EnumUtil.GetString(APIEnums.ValidateLoginParams.Password), Password }
            };

            ValidateLogin response =  JsonConvert.DeserializeObject<ValidateLogin.ValidateLogin>(_call.MakeCall(data));
            Session["uid"] = response.UserID;
            Session["upw"] = response.PasswordHash;
        }
    }
}
```

[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=A3JFH2WA6U9YU)
