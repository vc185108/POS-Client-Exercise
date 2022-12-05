using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;
namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Validations
{
    public interface IWfmLoyaltyCustomerLookupValidator
    {
        void Validate(WfmLoyaltyCustomerLookupRequest request, WfmLoyaltyCustomerLookupResponse response);
    }
}
