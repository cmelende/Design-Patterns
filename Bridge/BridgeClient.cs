﻿using System;
using BridgePattern.Abstraction;
using BridgePattern.Concrete_Implementor;
using BridgePattern.Implementor;
using BridgePattern.Refined_Abstraction;
using DesignPatternBase;

namespace BridgePattern
{
    public class BridgeClient : IDesignPatternClient
    {
        public string Name => "Bridge";

        public void Main()
        {
            IMessageSender email = new EmailSender();
            IMessageSender queue = new MsmqSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";

            message.MessageSender = email;
            message.Send();

            message.MessageSender = queue;
            message.Send();

            message.MessageSender = web;
            message.Send();

            var userMsg = new UserMessage();
            userMsg.Subject = "Test Message";
            userMsg.Body = "Hi, This is a Test Message";
            userMsg.UserComments = "I hope you are well";

            userMsg.MessageSender = email;
            userMsg.Send();

            Console.ReadKey();
        }
    }
}