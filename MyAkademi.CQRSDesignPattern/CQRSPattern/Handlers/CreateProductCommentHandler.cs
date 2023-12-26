using MyAkademi.CQRSDesignPattern.CQRSPattern.Commands;
using MyAkademi.CQRSDesignPattern.DAL.Context;
using MyAkademi.CQRSDesignPattern.DAL.Entities;

namespace MyAkademi.CQRSDesignPattern.CQRSPattern.Handlers
{
    public class CreateProductCommentHandler
    {
        private readonly SaleContext _saleContext;

        public CreateProductCommentHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateProductComment createProductComment)
        {
            _saleContext.Products.Add(new Product
            {
                ProductName= createProductComment.ProductName,
                CategoryID=createProductComment.CategoryID,
                Price=createProductComment.Price,
                Stock=createProductComment.Stock
            });
            _saleContext.SaveChanges();
        }
    }
}
