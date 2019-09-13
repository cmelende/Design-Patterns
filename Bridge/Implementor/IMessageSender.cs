namespace Bridge.Implementor
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}