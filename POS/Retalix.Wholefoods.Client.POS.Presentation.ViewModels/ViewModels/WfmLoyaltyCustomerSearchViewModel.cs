using Retalix.Client.POS.Presentation.ViewModels.ViewModels;
using Retalix.Client.Presentation.Core.Command;
using System.Windows.Input;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
namespace Retalix.Wholefoods.Client.POS.Presentation.ViewModels.ViewModels
{
    public class WfmLoyaltyCustomerSearchViewModel : PosViewModelBase
    {

        public ICommand GetWfmLoyaltyCustomerCommand { get; private set; }
        public ICommand BackCommand { get; private set; }


        private string _customer;
        public string Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                NotifyPropertyChanged("Customer");
            }
        }

        public WfmLoyaltyCustomerSearchViewModel()
        {
            Init();
        }
        private void Init()
        {
            InitCommands();
        }

        private void InitCommands()
        {
            GetWfmLoyaltyCustomerCommand = new CommandAction<object>(ExecuteGetCommand, CanExecuteGetCommand);
            BackCommand = new CommandAction<object>(ExecuteBackCommand, x => true);


        }

        private bool CanExecuteGetCommand(object obj)
        {
            //return !string.IsNullOrWhiteSpace(Customer);
            return true;
        }

        protected virtual void ExecuteGetCommand(object obj)
        {

            ExecuteWfmLoyaltyCustomerLookupCommandHandler(Customer);
        }

        protected virtual void ExecuteBackCommand(object obj)
        {

            ExecuteBackCommandHandler();
        }

        protected virtual void ExecuteWfmLoyaltyCustomerLookupCommandHandler(string customerName)
        {
            var command = CommandHandlerFactory.Create<IWfmLoyaltyCustomerLookupCommandHandler>();
            command.Init(customerName);
            ExecuteCommandHandlerAndStartFlow(command);
        }

        protected virtual void ExecuteBackCommandHandler()
        {
            var command = CommandHandlerFactory.Create<IWfmLoyaltyCustomerBackCommandHandler>();
            ExecuteCommandHandlerAndStartFlow(command);
        }
    }
}
