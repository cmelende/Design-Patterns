using System;
using BridgePattern.Implementor;

namespace BridgePattern.Concrete_Implementor
{
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Web Service\n{0}\n{1}\n", subject, body);
        }
    }
}