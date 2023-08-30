namespace ChainOfResposibilityDesignPattern.DAL.Entities
{
    public class CustomerProcess
    {
        public int CustomerProcessId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public float Amount { get; set; }
        public string EmloyeeName { get; set; }
        public string Description { get; set; }
    }
}
