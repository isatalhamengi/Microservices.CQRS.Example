using Microservices.CQRS.Example.Manual_CQRS.Queries.Requests;
using Microservices.CQRS.Example.Manual_CQRS.Queries.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest request)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(x=> x.Id == request.ProductId);

            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                CreateDate = product.CreateDate,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };
        }
    }
}
