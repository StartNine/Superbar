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
    
    public class IModuleContractToViewAddInAdapter : Superbar.Views.IModule
    {
        private Start9.Api.Contracts.IModuleContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IModuleContractToViewAddInAdapter()
        {
        }
        public IModuleContractToViewAddInAdapter(Start9.Api.Contracts.IModuleContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public Superbar.Views.IConfiguration Configuration
        {
            get
            {
                return Superbar.Adapters.IConfigurationAddInAdapter.ContractToViewAdapter(_contract.Configuration);
            }
            set
            {
                _contract.Configuration = Superbar.Adapters.IConfigurationAddInAdapter.ViewToContractAdapter(value);
            }
        }
        public Superbar.Views.IMessageContract MessageContract
        {
            get
            {
                return Superbar.Adapters.IMessageContractAddInAdapter.ContractToViewAdapter(_contract.MessageContract);
            }
        }
        public Superbar.Views.IReceiverContract ReceiverContract
        {
            get
            {
                return Superbar.Adapters.IReceiverContractAddInAdapter.ContractToViewAdapter(_contract.ReceiverContract);
            }
        }
        public void Initialize(Superbar.Views.IHost host)
        {
            _contract.Initialize(Superbar.Adapters.IHostAddInAdapter.ViewToContractAdapter(host));
        }
        internal Start9.Api.Contracts.IModuleContract GetSourceContract()
        {
            return _contract;
        }
    }
}
