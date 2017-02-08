# WHMCS API C# Wrapper

This is an library to comunicate with the WHMCS API<br/>
Currently these functions are already implemented

<ul>
  <li><a href="https://github.com/hitmanpt/whmcs-api/wiki/AddClient%28%29">Add Client</a></li>
  <li><a href="https://github.com/hitmanpt/whmcs-api/wiki/DomainWhoIs%28%29">Domain WhoIs</a></li>
  <li><a href="https://github.com/hitmanpt/whmcs-api/wiki/GetClientsDetails%28%29">Get Client Details</a></li>
  <li>Validate Login</li>
  <li>GetTransactions</li>
  <li><a href="https://github.com/hitmanpt/whmcs-api/wiki/GetOrders%28%29">GetOrders</a></li>
  <li><a href="https://github.com/hitmanpt/whmcs-api/wiki/GetClientsProducts%28%29">GetClientsProducts</a></li>
</ul>

[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=A3JFH2WA6U9YU)

How to install<br />
[NuGet](https://www.nuget.org/packages/WHMCS_API) Packet Manager Console on VisualStudio `Install-Package WHMCS_API`
<br />or<br />
<a href="https://github.com/hitmanpt/whmcs-api/releases">Releases</a> project page (need to also download Newtonsoft.Json if not already included on your project)

The implemented functions are designed to be very easy to use
The following code demonstrates to to implement the GetClientDetails on an ASP.net MVC app<br />
More information on the project Wiki <a href="https://github.com/hitmanpt/whmcs-api/wiki/Getting-Started">Getting Started</a>

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

You can still use this library to call non implemented<br />
Read more at the project Wiki <a href="https://github.com/hitmanpt/whmcs-api/wiki/%5BAdvanced-Usage%5D-Unsuported-Actions">[Advanced Usage] Unsuported Actions</a>


You can also create custom functions of already implemented functions.<br />
Read more at the project Wiki <a href="https://github.com/hitmanpt/whmcs-api/wiki/%5BAdvanced-Usage%5D-Supported-Actions">[Advanced Usage] Supported Actions</a>


[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=A3JFH2WA6U9YU)
