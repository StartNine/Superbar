//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Superbar.Adapters
{
    
    public class IReceiverContractViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IReceiverContractContract
    {
        private Superbar.Views.IReceiverContract _view;
        public IReceiverContractViewToContractAddInAdapter(Superbar.Views.IReceiverContract view)
        {
            _view = view;
        }
        public System.AddIn.Contract.IListContract<Start9.Api.Contracts.IReceiverEntryContract> Entries
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIListContract<Superbar.Views.IReceiverEntry, Start9.Api.Contracts.IReceiverEntryContract>(_view.Entries, Superbar.Adapters.IReceiverEntryAddInAdapter.ViewToContractAdapter, Superbar.Adapters.IReceiverEntryAddInAdapter.ContractToViewAdapter);
            }
        }
        internal Superbar.Views.IReceiverContract GetSourceView()
        {
            return _view;
        }
    }
}
