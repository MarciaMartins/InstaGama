using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstaGama.Application.AppAmigo.Input;
using InstaGama.Application.AppAmigo.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaGama.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmigoController : ControllerBase
    {
        private readonly IAmigoAppService _amigoAppService;

        public AmigoController(IAmigoAppService amigoAppService)
        {
            _amigoAppService = amigoAppService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AmigoInput amigoInput)
        {
            try
            {
                var amigo = await _amigoAppService
                    .InsertAsync(amigoInput)
                    .ConfigureAwait(false);
                return Created("", amigo);
            }catch(ArgumentException ex)
            {
                return BadRequest(ex.Message) ;
            }
        }

    }
}
