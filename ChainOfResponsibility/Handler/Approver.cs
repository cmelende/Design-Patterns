using ChainOfResponsibility.Details;

namespace ChainOfResponsibility.Handler
{
    public abstract class Approver : IApprover
    {
        protected Approver Successor;

        public void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}