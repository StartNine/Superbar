//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Superbar.Views
{
    
    public interface IReceiverEntry
    {
        System.Type Type
        {
            get;
        }
        string FriendlyName
        {
            get;
        }
        event System.EventHandler<MessageReceivedEventArgs> MessageReceived;
        void SendMessage(IMessage message);
    }
}
