namespace CQRSDesignPattern.CQRS.Queries
{
    public class GetProductByIdQuery
    {
        public int ProductId { get; set; }

        public GetProductByIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
