using Retalix.Client.POS.BusinessObjects.ServiceAgents.Validations;
using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;
using System.ComponentModel.Composition;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Validations
{
    [Export(typeof(IWfmLoyaltyCustomerLookupValidator))]
    public class WfmLoyaltyCustomerLookupValidator:RetalixValidatorBase, IWfmLoyaltyCustomerLookupValidator
    {
        public void Validate(WfmLoyaltyCustomerLookupRequest request, WfmLoyaltyCustomerLookupResponse response)
        {
            ValidateResponseError(response.Header);
        }
    }
}
