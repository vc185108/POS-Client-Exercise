using Retalix.Client.Common.DataModels;
using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.DataModels
{
    public interface IWfmLoyaltyCustomerDataModel : IDataModel
    {
        WfmLoyaltyCustomerLookupResponse wfmLCLookupResponseType { get; set; }
    }
}
