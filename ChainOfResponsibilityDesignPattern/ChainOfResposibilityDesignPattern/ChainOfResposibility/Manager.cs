using ChainOfResposibilityDesignPattern.DAL.Entities;
using ChainOfResposibilityDesignPattern.DAL;
using ChainOfResposibilityDesignPattern.Models;

namespace ChainOfResposibilityDesignPattern.ChainOfResposibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();

            if (request.Amount <= 250000)
            {
                CustomerProcess customerProcess = new()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    SurName = request.SurName,
                    EmloyeeName = "Müdür - Yadigar Bulur",
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
                    EmloyeeName = "Müdür - Yadigar Bulur",
                    Description = "Para çekme işlemi onaylanmadı,(Müdür Limiti Aşıldı) müşteri Bölge Müdür e Aktarıldı."

                };
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
