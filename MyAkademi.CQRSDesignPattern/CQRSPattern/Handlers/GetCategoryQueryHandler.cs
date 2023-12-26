using MyAkademi.CQRSDesignPattern.CQRSPattern.Results;
using MyAkademi.CQRSDesignPattern.DAL.Context;

namespace MyAkademi.CQRSDesignPattern.CQRSPattern.Handlers
{
    public class GetCategoryQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetCategoryQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public List<GetCategoryQueryResult> Handle()
        {
            var values = _saleContext.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName
            }).ToList();
            return values;
        }
    }
}
