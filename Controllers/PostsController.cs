using SBIChallenge.Models.Requests;

using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MediatR;

namespace SBIChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IMediator mediator;

        public PostsController(IMediator mediator) 
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try 
            {
                var query = new PostsRequest(id);
                var result = await mediator.Send(query);

                if (result != null) 
                {
                    return Ok(result);
                }
                else 
                {
                    return StatusCode(400, "No se encontro el post con el id dado.");
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }
    }
}
