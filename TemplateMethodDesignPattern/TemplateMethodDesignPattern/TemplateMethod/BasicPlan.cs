﻿namespace TemplateMethodDesignPattern.TemplateMethod
{
    public class BasicPlan : NetflixPlans
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int CountPerson(int countPerson)
        {
            return countPerson;
        }

        public override string PlanType(string planType)
        {
            return planType;
        }

        public override float Price(float price)
        {
            return price;
        }

        public override string Resolution(string resolution)
        {
            return resolution;
        }
    }

}

