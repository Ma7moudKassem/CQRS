using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProductsController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await _mediator.Send(new GetValueQuery());

        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Product product)
    {
        await _mediator.Send(new AddProductCommand(product));

        return StatusCode(201);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _mediator.Send(new GetProductById(id));

        return Ok(product);
    }
}