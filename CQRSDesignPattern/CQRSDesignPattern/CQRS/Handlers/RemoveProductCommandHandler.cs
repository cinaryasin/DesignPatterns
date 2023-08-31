using CQRSDesignPattern.DAL;
using CQRSDesignPattern.CQRS.Commands;
using CQRSDesignPattern.DAL.Entities;
using System.Security.Cryptography.X509Certificates;

namespace CQRSDesignPattern.CQRS.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand request)
        {
            var findProduct = _context.Products.Find(request.Id);
            if (findProduct != null)
            {
                _context.Products.Remove(findProduct);
                _context.SaveChanges();
            }
        }
    }
}
