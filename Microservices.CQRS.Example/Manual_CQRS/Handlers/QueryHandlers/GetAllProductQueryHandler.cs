using Microservices.CQRS.Example.Manual_CQRS.Queries.Requests;
using Microservices.CQRS.Example.Manual_CQRS.Queries.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest request)
        {
            return ApplicationDbContext.ProductList.Select(x=> new GetAllProductQueryResponse
            {
                CreateDate = x.CreateDate,
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity
            }).ToList();
        }
    }
}
