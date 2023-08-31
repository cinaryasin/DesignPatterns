using CQRSDesignPattern.DAL;
using CQRSDesignPattern.CQRS.Results;
using System.Linq;
using CQRSDesignPattern.CQRS.Queries;

namespace CQRSDesignPattern.CQRS.Handlers
{
    public class GetProductUpdateQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery request)
        {
            var value = _context.Products.Where(x => x.ProductId == request.ProductId).Select(p => new GetProductUpdateQueryResult
            {
                ProductId = p.ProductId,
                Description = p.Description,
                Name = p.Name,
                Price = p.Price,
                Stock = p.Stock,
                Stotus = p.Stotus

            }).FirstOrDefault();
            return value;
        }
    }
}
