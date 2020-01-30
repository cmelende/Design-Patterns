using ChainOfResponsibility.Details;
using ChainOfResponsibility.Handler;

namespace ChainOfResponsibility
{
    public interface IApprover
    {
        void SetSuccessor(Approver successor);
        void ProcessRequest(Purchase purchase);
    }
}