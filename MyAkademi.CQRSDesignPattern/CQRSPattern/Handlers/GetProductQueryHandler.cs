using MyAkademi.CQRSDesignPattern.CQRSPattern.Results;
using MyAkademi.CQRSDesignPattern.DAL.Context;

namespace MyAkademi.CQRSDesignPattern.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetProductQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values=_saleContext.Products.Select(x=> new GetProductQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                Price = x.Price,
                Stock = x.Stock ,
                CategoryID = x.CategoryID,
                
            }).ToList();
            return values;  
        }
    }
}
