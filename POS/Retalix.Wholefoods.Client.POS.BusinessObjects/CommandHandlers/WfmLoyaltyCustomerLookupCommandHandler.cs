using Retalix.Client.POS.BusinessObjects.CommandHandlers;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
using System.ComponentModel.Composition;
using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;
using Retalix.Wholefoods.Client.POS.BusinessObjects.DataModels;
using Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.Agents;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlers
{
    [Export(typeof(IWfmLoyaltyCustomerLookupCommandHandler))]
    public class WfmLoyaltyCustomerLookupCommandHandler : PosCommandHandlerBase, IWfmLoyaltyCustomerLookupCommandHandler
    {
        private string _customerName;
        private const string wfmLCLookupOutcome = "WfmLoyaltyCustomerLookupOutcome";

        public void Init(string customerName)
        {
            _customerName = customerName;
        }

        protected override string ExecuteLogic()
        {
            var wfmLCLookupResponse = WfmLoyaltyCustomerLookupServiceAgent();
            SetupWfmLCDataModel(wfmLCLookupResponse);
            return wfmLCLookupOutcome;
        }

        private void SetupWfmLCDataModel(WfmLoyaltyCustomerLookupResponse wfmLCLookupResponse)
        {
            var wfmLCDataModel = GetDataModel<IWfmLoyaltyCustomerDataModel>();
            wfmLCDataModel.wfmLCLookupResponseType = wfmLCLookupResponse;
        }

        private WfmLoyaltyCustomerLookupResponse WfmLoyaltyCustomerLookupServiceAgent()
        {
            var wfmLCLookupServiceAgent = GetServiceAgent<IWfmLoyaltyCustomerLookupServiceAgent>();
            return wfmLCLookupServiceAgent.Execute(_customerName);
        }
    }
}
