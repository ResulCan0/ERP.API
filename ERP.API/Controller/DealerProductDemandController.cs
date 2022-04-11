using ERP.API.Controller.BaseController;
using ERP.Business.Handler.DealerProductDemands.Command;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controller;
[Route("api/[controller]")]
[ApiController]
public class DealerProductDemandController : BaseApiController
{
    [HttpPost("AddDealerProductDemand")]
    public async Task<IActionResult> Add([FromBody] CreateDealerProductDemandCommand addDealerProductDemand)
    {
        return Created("", await Mediator.Send(addDealerProductDemand));
    }
}