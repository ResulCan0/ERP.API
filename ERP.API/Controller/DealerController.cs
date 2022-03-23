using ERP.API.Controller.BaseController;
using ERP.Business.Handler.Dealers.Command;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerController : BaseApiController
    {
        [HttpPost("AddDealer")]
        public async Task<IActionResult> Add([FromBody] CreateDealerCommand addDealer)
        {
            return Created("", await Mediator.Send(addDealer));
        }
    }
}
