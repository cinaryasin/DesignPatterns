using ChainOfResposibilityDesignPattern.Models;

namespace ChainOfResposibilityDesignPattern.ChainOfResposibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee approver)
        {
            this.NextApprover = approver;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel request);
    }
}
