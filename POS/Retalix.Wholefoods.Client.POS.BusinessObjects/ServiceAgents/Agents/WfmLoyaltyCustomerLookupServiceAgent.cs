using Retalix.Client.Common.ServiceAgents;
using Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Builders;
using Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Services;
using Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Validations;
using System.ComponentModel.Composition;
using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;
namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Agents
{
    [Export(typeof(IServiceAgent))]
    public class WfmLoyaltyCustomerLookupServiceAgent: IWfmLoyaltyCustomerLookupServiceAgent
    {
        [Import] 
        private IWfmLoyaltyCustomerLookupService _wfmLoyaltyCustomerLookupService;

        [Import] 
        private IWfmLoyaltyCustomerLookupValidator _wfmLoyaltyCustomerLookupValidator;

        [Import] 
        private IWfmLoyaltyCustomerLookupRequestBuilder _wfmLoyaltyCustomerLookupRequestBuilder;


        public WfmLoyaltyCustomerLookupResponse Execute(string customerName)
        {
            var wfmLCLookupRequest = _wfmLoyaltyCustomerLookupRequestBuilder.BuildLookupRequest(customerName);
            var wfmLCLookupResponse = _wfmLoyaltyCustomerLookupService.Execute(wfmLCLookupRequest);
            _wfmLoyaltyCustomerLookupValidator.Validate(wfmLCLookupRequest, wfmLCLookupResponse);
            return wfmLCLookupResponse;
        }
    }
}
