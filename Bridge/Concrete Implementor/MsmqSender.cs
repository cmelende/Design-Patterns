using System;
using BridgePattern.Implementor;

namespace BridgePattern.Concrete_Implementor
{
    public class MsmqSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("MSMQ\n{0}\n{1}\n", subject, body);
        }
    }
}