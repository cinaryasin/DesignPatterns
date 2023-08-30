using ChainOfResposibilityDesignPattern.DAL.Entities;
using ChainOfResposibilityDesignPattern.DAL;
using ChainOfResposibilityDesignPattern.Models;

namespace ChainOfResposibilityDesignPattern.ChainOfResposibility
{
    public class RegionalDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();

            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    SurName = request.SurName,
                    EmloyeeName = "Bölge Müdürü - Zeynep Yılar",
                    Description = "Para çekme işlemi onaylandı, müşteriye Talep Ettiği Tutar Ödendi"

                };
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    SurName = request.SurName,
                    EmloyeeName = "Bölge Müdürü - Zeynep Yılar",
                    Description = "Para çekme işlemi onaylanmadı,Müşterinin Günlük Çekebileceği ma tutar 400000 tl olup birden fazla kez şubeye gelmeli"

                };
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
