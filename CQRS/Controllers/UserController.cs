using CQRS.Commands;
using CQRS.Models;
using CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserAsync([FromBody] User user)
        {
            CreateUserCommand createUserCommand = new CreateUserCommand(user);
            var result = await _mediator.Send(createUserCommand);
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetUserById(int id)
        {
            GetUserByIdQuery getUserByIdQuery = new GetUserByIdQuery(id);
            var result = await _mediator.Send(getUserByIdQuery);
            return Ok(result);
        }
    }
}
