using Retalix.Client.POS.Presentation.ViewModels.ViewModels;
using Retalix.Client.Presentation.Core.Command;
using Retalix.Wholefoods.Client.POS.BusinessObjects.DataModels;
using System.Collections.Generic;
using System.Windows.Input;
using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;

namespace Retalix.Wholefoods.Client.POS.Presentation.ViewModels.ViewModels
{
    public class WfmLoyaltyCustomerViewModel : PosViewModelBase
    {
        private IWfmLoyaltyCustomerDataModel _wfmLCDataModel;
        public ICommand BackCommand { get; private set; }

        private IList<WfmLoyaltyCustomerType> _wfmLCElement;
        public IList<WfmLoyaltyCustomerType> wfmLCElement
        {
            get { return _wfmLCElement; }
            set { _wfmLCElement = value; }
        }

        public WfmLoyaltyCustomerViewModel()
        {
            Init();
            InitCommands();
        }

        private void Init()
        {
            _wfmLCDataModel = _dataModelProvider.GetDataModel<IWfmLoyaltyCustomerDataModel>();
            wfmLCElement = _wfmLCDataModel.wfmLCLookupResponseType.WfmLoyaltyCustomer;
        }


        private void InitCommands()
        {
            BackCommand = new CommandAction<object>(ExecuteBackCommand, x => true);
        }

        protected virtual void ExecuteBackCommand(object obj)
        {

            ExecuteBackCommandHandler();
        }

        protected virtual void ExecuteBackCommandHandler()
        {
            var command = CommandHandlerFactory.Create<IWfmLoyaltyCustomerBackCommandHandler>();
            ExecuteCommandHandlerAndStartFlow(command);
        }
    }
}
