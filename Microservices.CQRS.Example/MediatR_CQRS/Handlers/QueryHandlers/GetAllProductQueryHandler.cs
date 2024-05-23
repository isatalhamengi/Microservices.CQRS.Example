using MediatR;
using Microservices.CQRS.Example.MediatR_CQRS.Queries.Requests;
using Microservices.CQRS.Example.MediatR_CQRS.Queries.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return ApplicationDbContext.ProductList.Select(x => new GetAllProductQueryResponse
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
