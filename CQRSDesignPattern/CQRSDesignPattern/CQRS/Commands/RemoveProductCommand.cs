namespace CQRSDesignPattern.CQRS.Commands
{
    public class RemoveProductCommand
    {
        public int Id { get; set; }

        public RemoveProductCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
