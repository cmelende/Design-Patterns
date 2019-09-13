using Bridge.Abstraction;

namespace Bridge.Refined_Abstraction
{
    public class UserMessage : Message
    {
        public string UserComments { get; set; }

        public override void Send()
        {
            var fullBody = $"{Body}\nUser Comments: {UserComments}";
            MessageSender.SendMessage(Subject, fullBody);
        }
    }
}