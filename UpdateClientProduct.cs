using System;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace WHMCS_API.UpdateClientProduct
{
	public class UpdateClientProduct
	{
		public readonly NameValueCollection nvm;
		public UpdateClientProduct(int ServiceID, int PackageID = -1, int ServerID = -1, DateTime NextDueDate = default(DateTime),
								   DateTime TerminationDate = default(DateTime), DateTime CompletedDate = default(DateTime),
								   string Domain = "", string FirstPaymentAmount = "", string RecurringAmount = "",
								   string PaymentMethod = "", int SubscriptionID = -1,
								   APIEnums.UpdateClientProductSubEnums.Status Status = APIEnums.UpdateClientProductSubEnums.Status.Null,
								   string Notes = "", string ServiceUsername = "", string ServicePassword = "",
								   APIEnums.UpdateClientProductSubEnums.OverideAutoSuspend OverideAutoSuspend = APIEnums.UpdateClientProductSubEnums.OverideAutoSuspend.Null,
								   DateTime OverideSuspendUntil = default(DateTime), string NameServer1 = "", string NameServer2 = "",
								   string DedicatedIP = "", string AssignedIPs = "", int DiskUsage = -2, int DiskLimit = -2,
								   int BandwidthUsage = -2, int BandwidthLimit = -2, string SuspendReason = "", int PromoID = -1,
								   NameValueCollection UnSet = null, APIEnums.UpdateClientProductSubEnums.AutoRecalculate AutoRecalculate = APIEnums.UpdateClientProductSubEnums.AutoRecalculate.Null,
								   NameValueCollection CustomFields = null, NameValueCollection ConfigurationOptions = null)
		{
			nvm = new NameValueCollection()
			{
				{ "action", EnumUtil.GetString(APIEnums.Actions.UpdateClientProduct) },
				{ EnumUtil.GetString(APIEnums.UpdateClientProductParams.ServiceID), ServiceID.ToString() }
			};
			if (PackageID != -1)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.PackageID), PackageID.ToString());
			if( ServerID != -1)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.ServerID), ServerID.ToString());
			if (NextDueDate != default(DateTime))
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.NextDueDate), NextDueDate.ToString("Y-m-d"));
			if(TerminationDate != default(DateTime))
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.TerminationDate), TerminationDate.ToString("Y-m-d"));
			if(CompletedDate != default(DateTime))
			   nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.CompletedDate), CompletedDate.ToString("Y-m-d"));
			if(Domain != "")
			   nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.Domain), Domain);
			if (FirstPaymentAmount != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.FirstPaymentAmount), FirstPaymentAmount);
			if (RecurringAmount != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.RecurringAmount), RecurringAmount);
			if (FirstPaymentAmount != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.PaymentMethod), PaymentMethod);
			if (SubscriptionID != -1)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.SubscriptionID), SubscriptionID.ToString());
			if (Status != APIEnums.UpdateClientProductSubEnums.Status.Null)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.SubscriptionID), EnumUtil.GetString(Status));
			if(Notes != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.Notes), Notes);
			if(ServiceUsername != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.ServiceUsername), ServiceUsername);
			if(ServicePassword != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.ServicePassword), ServicePassword);
			if(OverideAutoSuspend != APIEnums.UpdateClientProductSubEnums.OverideAutoSuspend.Null)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.OverideAutoSuspend), EnumUtil.GetString(OverideAutoSuspend));
			if(OverideSuspendUntil != default(DateTime))
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.OverideSuspendUntil), OverideSuspendUntil.ToString("Y-m-d"));
			if(NameServer1 != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.NameServer1), NameServer1);
			if(NameServer2 != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.NameServer2), NameServer2);
			if(DedicatedIP != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.DedicatedIP), DedicatedIP);
			if(AssignedIPs != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.AssignedIPs), AssignedIPs);
			if(DiskUsage != -2)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.DiskUsage), DiskUsage.ToString());
			if(DiskLimit != -2)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.DiskLimit), DiskLimit.ToString());
			if(BandwidthUsage != -2)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.BandwidthUsage), BandwidthUsage.ToString());
			if(BandwidthLimit != -2)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.BandwidthLimit), BandwidthLimit.ToString());
			if(SuspendReason != "")
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.SuspendReason), SuspendReason);
			if(PromoID != -1)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.PromoID), PromoID.ToString());
			if (UnSet != null)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.Unset), JsonConvert.SerializeObject(UnSet));
			if(AutoRecalculate != APIEnums.UpdateClientProductSubEnums.AutoRecalculate.Null)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.AutoRecalculate), EnumUtil.GetString(AutoRecalculate));
			if (CustomFields != null)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.CustomFields), Helper.Base64Encode(JsonConvert.SerializeObject(CustomFields)));
			if (ConfigurationOptions != null)
				nvm.Add(EnumUtil.GetString(APIEnums.UpdateClientProductParams.ConfigurationOptions), Helper.Base64Encode(JsonConvert.SerializeObject(ConfigurationOptions)));				        
		}
	}
}
