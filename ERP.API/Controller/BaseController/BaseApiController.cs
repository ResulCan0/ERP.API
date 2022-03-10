using Bogus;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controller.BaseController
{
    [ApiController]
    [Route("[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        private static Faker _dg;
        protected static Faker DataGenerator => _dg ??= new Faker(locale: "tr");
    }
}
