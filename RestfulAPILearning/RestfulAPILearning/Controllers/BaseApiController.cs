using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RestfulAPILearning.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator {             
            get { return _mediator ??= HttpContext.RequestServices.GetService<IMediator>(); } 
        }
    }
}
