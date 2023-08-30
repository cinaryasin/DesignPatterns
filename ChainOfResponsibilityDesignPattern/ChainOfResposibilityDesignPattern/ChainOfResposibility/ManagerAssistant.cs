using ChainOfResposibilityDesignPattern.DAL;
using ChainOfResposibilityDesignPattern.DAL.Entities;
using ChainOfResposibilityDesignPattern.Models;

namespace ChainOfResposibilityDesignPattern.ChainOfResposibility
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();

            if (request.Amount <= 150000)
            {
                CustomerProcess customerProcess = new()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    SurName = request.SurName,
                    EmloyeeName = "Müdür Yard - Ayşe Betmez",
                    Description = "Para çekme işlemi onaylandı, müşteriye Talep Ettiği Tutar Ödendi"

                };
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    SurName = request.SurName,
                    EmloyeeName = "Müdür Yard - Ayşe Betmez",
                    Description = "Para çekme işlemi onaylanmadı,(Müdür Yard. Limiti Aşıldı) müşteri Müdür e Aktarıldı."

                };
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
