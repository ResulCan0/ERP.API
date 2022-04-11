using ERP.API.Controller.BaseController;
using ERP.Business.Handler.DealerProductFeatureSuggestions.Command;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controller;

public class DealerProductFeatureSuggestionController : BaseApiController
{
    [HttpPost("AddDealerProductFeatureSuggestion")]
    public async Task<IActionResult> Add([FromBody] CreateDealerProductFeatureSuggestionCommand addDealerProductFeatureSuggestion)
    {
        return Created("", await Mediator.Send(addDealerProductFeatureSuggestion));
    }
}