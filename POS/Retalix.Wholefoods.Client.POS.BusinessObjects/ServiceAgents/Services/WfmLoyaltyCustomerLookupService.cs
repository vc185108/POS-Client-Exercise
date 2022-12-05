using Retalix.Client.Net;
using System.ComponentModel.Composition;
using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Services
{
    [Export(typeof(IWfmLoyaltyCustomerLookupService))]
    public class WfmLoyaltyCustomerLookupService: ServiceBase, IWfmLoyaltyCustomerLookupService
    {
        private const string ServiceName = "WfmLoyaltyCustomerLookup";
        public WfmLoyaltyCustomerLookupResponse Execute(WfmLoyaltyCustomerLookupRequest request)
        {
            return Execute<WfmLoyaltyCustomerLookupRequest, WfmLoyaltyCustomerLookupResponse>(request, ServiceName);
        }
    }
}
