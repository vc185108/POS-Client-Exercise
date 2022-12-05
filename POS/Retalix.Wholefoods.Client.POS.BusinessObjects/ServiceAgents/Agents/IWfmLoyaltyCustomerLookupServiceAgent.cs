using Retalix.Client.Common.ServiceAgents;
using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Agents
{
    public interface IWfmLoyaltyCustomerLookupServiceAgent:IServiceAgent
    {
        WfmLoyaltyCustomerLookupResponse Execute(string customerName);
    }
}
