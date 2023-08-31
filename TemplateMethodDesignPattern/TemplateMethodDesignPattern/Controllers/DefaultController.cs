﻿using Microsoft.AspNetCore.Mvc;
using TemplateMethodDesignPattern.TemplateMethod;

namespace TemplateMethodDesignPattern.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(64.99f);
            ViewBag.v4 = netflixPlans.Content("Film Dizi");
            ViewBag.v5 = netflixPlans.Resolution("480px");
            return View();
        }
        public IActionResult StandartPlanIndex()
        {
            NetflixPlans netflixPlans = new StandartPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(74.99f);
            ViewBag.v4 = netflixPlans.Content("Film Dizi Animasyon");
            ViewBag.v5 = netflixPlans.Resolution("720px");
            return View();
        }
        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(99.99f);
            ViewBag.v4 = netflixPlans.Content("Film Dizi Animasyon Belgesel");
            ViewBag.v5 = netflixPlans.Resolution("1080px");
            return View();
        }
    }
}
