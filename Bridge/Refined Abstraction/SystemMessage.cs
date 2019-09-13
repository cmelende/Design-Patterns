using Bridge.Abstraction;

namespace Bridge.Refined_Abstraction
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}