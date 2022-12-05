using Retalix.Client.POS.BusinessObjects.CommandHandlers;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
using System.ComponentModel.Composition;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlers
{
    [Export(typeof(IWfmLoyaltyCustomerSerachCommandHandler))]
    public class WfmLoyaltyCustomerSearchCommandHandler : PosCommandHandlerBase, IWfmLoyaltyCustomerSerachCommandHandler
    {
        private const string wfmLCSearchOutcome = "WfmLoyaltyCustomerSearchOutcome";

        protected override string ExecuteLogic()
        {
            return wfmLCSearchOutcome;
        }

    }
}
