namespace CQRSDesignPattern.CQRS.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
