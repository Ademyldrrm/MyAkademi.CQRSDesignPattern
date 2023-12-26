using Microsoft.AspNetCore.Mvc;
using MyAkademi.CQRSDesignPattern.CQRSPattern.Commands;
using MyAkademi.CQRSDesignPattern.CQRSPattern.Handlers;

namespace MyAkademi.CQRSDesignPattern.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommentHandler _createProductCommentHandler;

        public ProductController(GetProductQueryHandler getProductQueryHandler, CreateProductCommentHandler createProductCommentHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommentHandler = createProductCommentHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductComment createProductComment)    
        {
            _createProductCommentHandler.Handle(createProductComment);
            return RedirectToAction("Index");
        }
    }
}
