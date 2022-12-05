using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Builders
{
    public interface IWfmLoyaltyCustomerLookupRequestBuilder
    {
        WfmLoyaltyCustomerLookupRequest BuildLookupRequest(string makerName);
    }
}
