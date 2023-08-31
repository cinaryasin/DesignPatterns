using CQRSDesignPattern.CQRS.Commands;
using CQRSDesignPattern.CQRS.Handlers;
using CQRSDesignPattern.CQRS.Queries;
using CQRSDesignPattern.CQRS.Results;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDesignPattern.Controllers
{
    public class ProductsController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly GetProductUpdateQueryHandler _getProductUpdateQueryHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;

        public ProductsController(GetProductQueryHandler getProductQueryHandlerİ, CreateProductCommandHandler createProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateQueryHandler getProductUpdateQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandlerİ;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductUpdateQueryHandler = getProductUpdateQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand request)
        {
            var message = _createProductCommandHandler.Handle(request);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetProductById(int id)
        {
            var result = _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return View(result);
        }

        public IActionResult DeleteProduct(int id)
        {
            _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        } 
        public IActionResult UpdateProduct(int id)
        {
            var result =  _getProductUpdateQueryHandler.Handle(new GetProductUpdateByIdQuery(id));
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand request)
        {
            _updateProductCommandHandler.Handle(request);
            return RedirectToAction("Index");
        }
    }
}
