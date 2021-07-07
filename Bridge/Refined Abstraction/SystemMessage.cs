using BridgePattern.Abstraction;

namespace BridgePattern.Refined_Abstraction
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}