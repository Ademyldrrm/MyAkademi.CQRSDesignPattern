using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyAkademi.CQRSDesignPattern.CQRSPattern.Queries;
using MyAkademi.CQRSDesignPattern.CQRSPattern.Results;
using MyAkademi.CQRSDesignPattern.DAL.Context;

namespace MyAkademi.CQRSDesignPattern.CQRSPattern.Handlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetCategoryByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public GetCategoryByIdQueryResult Handle(GetCategoyByIdQuery query)
        {
            var values = _saleContext.Categories.Find(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryID = values.CategoryID,
                CategoryName = values.CategoryName
            };

        }
         
    }
}
