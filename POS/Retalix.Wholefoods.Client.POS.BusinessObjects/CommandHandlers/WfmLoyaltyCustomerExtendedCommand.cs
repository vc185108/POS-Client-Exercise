using Retalix.Client.Common.Handlers;
using Retalix.Client.POS.BusinessObjects.Factory;
using Retalix.Client.Presentation.Core.ViewModels;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
using System.ComponentModel.Composition;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlers
{
    [Export(typeof(IExtendedCommand))]
    public class WfmLoyaltyCustomerExtendedCommand: IExtendedCommand
    {
        private const string WfmLCCommandName = "WfmLoyaltyCustomer";

        [Import]
        private ICommandHandlerFactory _commandHandlerFactory;
        public string CommandName { get { return WfmLCCommandName; } }

        public ICommandHandler GetCommandHandler(ViewModelBase viewModel)
        {
            var commandHandler = _commandHandlerFactory.Create<IWfmLoyaltyCustomerSerachCommandHandler>();
            return commandHandler;
        }
    }
}
