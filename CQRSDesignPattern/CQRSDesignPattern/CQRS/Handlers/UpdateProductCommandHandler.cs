using CQRSDesignPattern.DAL;
using CQRSDesignPattern.CQRS.Commands;
using CQRSDesignPattern.DAL.Entities;
using System.Linq;

namespace CQRSDesignPattern.CQRS.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand request)
        {
            var product = _context.Products.Where(x=> x.ProductId == request.ProductId).FirstOrDefault();
            
            product.Stotus = request.Status;
            product.Name = request.Name;
            product.Description = request.Description;
            product.Price= request.Price;
            product.Stock= request.Stock;
         
            _context.SaveChanges();
        }
    }
}
