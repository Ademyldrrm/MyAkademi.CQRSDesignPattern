using MyAkademi.CQRSDesignPattern.CQRSPattern.Commands;
using MyAkademi.CQRSDesignPattern.DAL.Context;
using MyAkademi.CQRSDesignPattern.DAL.Entities;

namespace MyAkademi.CQRSDesignPattern.CQRSPattern.Handlers
{
    public class CreateCategoryCommentHandler
    {
        private readonly SaleContext _saleContext;

        public CreateCategoryCommentHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateCategoryComment createCategoryComment)
        {
            _saleContext.Categories.Add(new Category
            {
                CategoryName= createCategoryComment.CategoryName

            });
            _saleContext.SaveChanges();

        }
    }
}
