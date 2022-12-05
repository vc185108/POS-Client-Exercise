using Retalix.Client.CommonServices.Utils;
using Retalix.Contracts.Generated.Arts.PosLogV6.Source;
using Retalix.Contracts.Generated.Common;
using System.ComponentModel.Composition;
using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Builders
{
    [Export(typeof(IWfmLoyaltyCustomerLookupRequestBuilder))]
    class WfmLoyaltyCustomerLookupRequestBuilder : IWfmLoyaltyCustomerLookupRequestBuilder
    {
        public WfmLoyaltyCustomerLookupRequest BuildLookupRequest(string customerName)
        {
            var wfmLCSearchCriteria = new SearchCriteriaType { Customer = customerName };
            var wfmLCLookupRequest = new WfmLoyaltyCustomerLookupRequest()
            {
                Header = new RetalixCommonHeaderType()
                {
                    MessageId = new RequestIDCommonData()
                    {
                        Value = MessageIdGenerator.GetId().ToString()
                    }
                },
                SearchCriteria = wfmLCSearchCriteria

            };
            return wfmLCLookupRequest;
        }
    }
}
