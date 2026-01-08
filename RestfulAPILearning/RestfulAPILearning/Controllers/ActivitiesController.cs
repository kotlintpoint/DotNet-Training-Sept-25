using Application.Activities;
using Learning.Data;
using Learning.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RestfulAPILearning.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        //private readonly IMediator _mediator;
        //public ActivitiesController(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities() {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult> CreateActivity(Activity Activity)
        {
            await Mediator.Send(new Create.Command { Activity = Activity});
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateActivity(Guid id, Activity Activity)
        {
            Activity.Id = id;
            await Mediator.Send(new Edit.Command { Activity = Activity });
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteActivity(Guid id)
        {            
            await Mediator.Send(new Delete.Command { Id = id });
            return Ok();
        }
    }
}
