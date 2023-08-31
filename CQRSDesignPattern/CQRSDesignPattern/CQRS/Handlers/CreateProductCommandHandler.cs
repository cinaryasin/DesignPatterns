using CQRSDesignPattern.DAL;
using CQRSDesignPattern.CQRS.Results;
using System.Collections.Generic;
using System.Linq;
using CQRSDesignPattern.CQRS.Commands;
using CQRSDesignPattern.DAL.Entities;

namespace CQRSDesignPattern.CQRS.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public string Handle(CreateProductCommand request)
        {
            _context.Products.Add(new Product
            {
                Description = request.Description,
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock,
                Stotus = true

            });
            _context.SaveChanges();
            return "Eklendi";
        }
    }
}
