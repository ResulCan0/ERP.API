using ERP.API.Controller.BaseController;
using ERP.Business.Handler.Products.Command;
using ERP.Business.Handler.Products.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controller;
[Route("api/[controller]")]
[ApiController]
public class ProductController : BaseApiController
{
    [HttpGet("GetProduct")]
    public async Task<IActionResult> GetList()
    {
        return Ok(await Mediator.Send(new GetProductQuery()));
    }
        
    [HttpPost("AddProduct")]
    public async Task<IActionResult> Add([FromBody] CreateProductCommand addProduct)
    {
        return Created("", await Mediator.Send(addProduct));
    }
}