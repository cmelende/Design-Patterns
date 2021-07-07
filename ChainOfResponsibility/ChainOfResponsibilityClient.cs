using ChainOfResponsibility.Details;
using ChainOfResponsibility.Handler;
using ChainOfResponsibilityPattern.ConcreteHandler;
using DesignPatternBase;

namespace ChainOfResponsibility
{
    public class ChainOfResponsibilityClient : IDesignPatternClient
    {
        public string Name => "Chain of Responsibility";

        public void Main()
        {
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests
            var p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);
        }
    }
}