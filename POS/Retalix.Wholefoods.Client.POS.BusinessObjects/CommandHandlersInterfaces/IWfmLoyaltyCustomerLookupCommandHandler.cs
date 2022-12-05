using Retalix.Client.Common.Handlers;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces
{
    public interface IWfmLoyaltyCustomerLookupCommandHandler : ICommandHandler
    {
        void Init(string customerName);
    }
}
