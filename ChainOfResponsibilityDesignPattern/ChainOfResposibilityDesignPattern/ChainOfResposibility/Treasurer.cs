using ChainOfResposibilityDesignPattern.DAL;
using ChainOfResposibilityDesignPattern.DAL.Entities;
using ChainOfResposibilityDesignPattern.Models;

namespace ChainOfResposibilityDesignPattern.ChainOfResposibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();

            if(request.Amount <= 100000)
            {
                CustomerProcess customerProcess = new()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    SurName = request.SurName,
                    EmloyeeName = "Veznedar - Ali Beter",
                    Description = "Para çekme işlemi onaylandı, müşteriye Talep Ettiği Tutar Ödendi"

                };
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover !=null)
            {
                CustomerProcess customerProcess = new()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    SurName = request.SurName,
                    EmloyeeName = "Veznedar - Ali Beter",
                    Description = "Para çekme işlemi onaylanmadı,(Veznedar Limiti Aşıldı) müşteri Müdür Yard. a Aktarıldı."

                };
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
