using ERP.API.Controller.BaseController;
using ERP.Business.Handler.Dealers.Command;
using ERP.Business.Handler.Dealers.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerController : BaseApiController
    {
        [HttpGet("GetDealer")]
        public async Task<IActionResult> GetList()
        {
            return Ok(await Mediator.Send(new GetDealerQuery()));
        }
        
        [HttpPost("AddDealer")]
        public async Task<IActionResult> Add([FromBody] CreateDealerCommand addDealer)
        {
            return Created("", await Mediator.Send(addDealer));
        }
    }
}
