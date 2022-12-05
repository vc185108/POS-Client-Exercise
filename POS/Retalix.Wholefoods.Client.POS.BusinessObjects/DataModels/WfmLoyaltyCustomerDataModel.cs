using Retalix.Client.Common.DataModels;
using System.ComponentModel.Composition;
using Retalix.Wholefoods.Contracts.Generated.WfmLoyaltyCustomer;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.DataModels
{
    [Export(typeof(IDataModel))]
    public class WfmLoyaltyCustomerDataModel : IWfmLoyaltyCustomerDataModel
    {
        public WfmLoyaltyCustomerLookupResponse wfmLCLookupResponseType { get; set; }

        public void Clear()
        {
            wfmLCLookupResponseType = null;
        }

    }
}
