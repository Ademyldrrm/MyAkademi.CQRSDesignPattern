using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MyAkademi.CQRSDesignPattern.CQRSPattern.Commands;
using MyAkademi.CQRSDesignPattern.CQRSPattern.Handlers;
using MyAkademi.CQRSDesignPattern.CQRSPattern.Queries;

namespace MyAkademi.CQRSDesignPattern.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly CreateCategoryCommentHandler _createCategoryCommentHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;

        public CategoryController(GetCategoryQueryHandler handler, CreateCategoryCommentHandler createCategoryCommentHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler)
        {
            _getCategoryQueryHandler = handler;
            _createCategoryCommentHandler = createCategoryCommentHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getCategoryQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryComment createCategoryComment) 
        {

            _createCategoryCommentHandler.Handle(createCategoryComment);
            return RedirectToAction("Index");
        }

        
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = _getCategoryByIdQueryHandler.Handle(new GetCategoyByIdQuery(id));
            return View(values);
        }



    }

}
