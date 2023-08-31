using CQRSDesignPattern.DAL;
using CQRSDesignPattern.CQRS.Results;
using System.Collections.Generic;
using System.Linq;

namespace CQRSDesignPattern.CQRS.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(p=>new GetProductQueryResult
            {
                ProductId = p.ProductId,
                Description = p.Description,
                Name= p.Name,
                Price= p.Price,
                Stock = p.Stock,
                Stotus = p.Stotus
                
            }).ToList();
            return values;
        }
    }
}
