using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;
namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Services
{
    public interface IWfmLoyaltyCustomerLookupService
    {
        WfmLoyaltyCustomerLookupResponse Execute(WfmLoyaltyCustomerLookupRequest request);
    }
}
