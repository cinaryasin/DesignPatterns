using ChainOfResposibilityDesignPattern.ChainOfResposibility;
using ChainOfResposibilityDesignPattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResposibilityDesignPattern.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel customerProcessViewModel)
        {
            Employee treasuer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee regionalDirector = new RegionalDirector();

            treasuer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(regionalDirector);

            treasuer.ProcessRequest(customerProcessViewModel);

            return View();
        }
    }
}
