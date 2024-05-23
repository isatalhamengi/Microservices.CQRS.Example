using MediatR;
using Microservices.CQRS.Example.MediatR_CQRS.Commands.Requests;
using Microservices.CQRS.Example.MediatR_CQRS.Queries.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.CQRS.Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Manuel CQRS
        /*
        CreateProductCommandHandler _createProductCommandHandler;
        DeleteProductCommandHandler _deleteProductCommandHandler;
        GetAllProductQueryHandler _getAllProductQueryHandler;
        GetByIdProductQueryHandler _getByIdProductQueryHandler;

        public ProductsController(CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler)
        {
            _createProductCommandHandler = createProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _getAllProductQueryHandler = getAllProductQueryHandler;
            _getByIdProductQueryHandler = getByIdProductQueryHandler;
        }


        [HttpGet]
        public IActionResult Get([FromQuery] GetAllProductQueryRequest request) => Ok(_getAllProductQueryHandler.GetAllProduct(request));

        [HttpGet("{ProductId}")]
        public IActionResult Get([FromRoute] GetByIdProductQueryRequest request) => Ok(_getByIdProductQueryHandler.GetByIdProduct(request));

        [HttpPost]
        public IActionResult Get([FromBody] CreateProductCommandRequest request) => Ok(_createProductCommandHandler.CreateProduct(request));

        [HttpDelete("{ProductId}")]
        public IActionResult Get([FromRoute] DeleteProductCommandRequest request) => Ok(_deleteProductCommandHandler.DeleteProduct(request));
        */
        #endregion

        IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] GetAllProductQueryRequest request) => Ok(_mediator.Send(request));

        [HttpGet("{ProductId}")]
        public IActionResult Get([FromRoute] GetByIdProductQueryRequest request) => Ok(_mediator.Send(request));

        [HttpPost]
        public IActionResult Get([FromBody] CreateProductCommandRequest request) => Ok(_mediator.Send(request));

        [HttpDelete("{ProductId}")]
        public IActionResult Get([FromRoute] DeleteProductCommandRequest request) => Ok(_mediator.Send(request));
    }
}
