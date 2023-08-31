namespace TemplateMethodDesignPattern.TemplateMethod
{
    public abstract class NetflixPlans
    {
        public abstract string PlanType(string planType);
        public abstract int CountPerson(int countPerson);
        public abstract float Price(float price);
        public abstract string Resolution(string resolution);
        public abstract string Content(string content);
    }

}

