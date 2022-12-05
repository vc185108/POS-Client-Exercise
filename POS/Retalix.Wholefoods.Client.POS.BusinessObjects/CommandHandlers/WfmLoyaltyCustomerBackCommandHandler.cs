using Retalix.Client.POS.BusinessObjects.CommandHandlers;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
using System.ComponentModel.Composition;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlers
{
    [Export(typeof(IWfmLoyaltyCustomerBackCommandHandler))]
    class WfmLoyaltyCustomerBackCommandHandler : PosCommandHandlerBase, IWfmLoyaltyCustomerBackCommandHandler
    {
        private const string wfmLoyaltyCustomerBackOutcome = "WfmLoyaltyCustomerBackOutcome";

        protected override string ExecuteLogic()
        {
            return wfmLoyaltyCustomerBackOutcome;
        }

    }
}
