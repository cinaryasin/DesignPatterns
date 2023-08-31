using CQRSDesignPattern.DAL;
using CQRSDesignPattern.CQRS.Results;
using System.Collections.Generic;
using System.Linq;
using CQRSDesignPattern.CQRS.Queries;

namespace CQRSDesignPattern.CQRS.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery request)
        {
            var value = _context.Products.Where(x=>x.ProductId == request.ProductId).Select(p => new GetProductByIdQueryResult
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
