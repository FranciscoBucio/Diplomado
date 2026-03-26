using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Saludos.DTOs;

namespace Saludos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaludosController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hola mundo");
        }

        [HttpGet("{saludo}")]
        public IActionResult Get(string saludo)
        {
            return Ok($"Hola {saludo}");
        }

        /// <summary>
        /// Hola mundo
        /// </summary>
        /// <returns></returns>
        /// <response code="200">IdDto</response>
        [ProducesResponseType(typeof(IdDTO), StatusCodes.Status200OK)]
        [Produces("application/json")]
        [HttpPost]
        public IActionResult Post([FromBody] SaludoDTOIn saludo)
        {
            IdDTO idDTO = new IdDTO
            {
                Id = Guid.NewGuid().ToString(),
                Mensaje = $"Hola {saludo.Saludo}"
            };

            return Ok(idDTO);
        }


        /// <summary>
        /// Regresa un error 500 Internal Server Error con un ProblemDetails personalizado
        /// </summary>
        /// <returns></returns>
        /// <response code="500"></response>
        [ProducesResponseType<ProblemDetails>(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpDelete]
        public IActionResult Delete()
        {
            try
            {
                throw new Exception("Este es un error");
            }
            catch (Exception)
            {
                ProblemDetails problemDetails = new ProblemDetails
                {
                    Title = "Error",
                    Detail = "Ocurrió un error al procesar la solicitud",
                    Status = StatusCodes.Status500InternalServerError
                };

                return StatusCode(StatusCodes.Status500InternalServerError, problemDetails);
            }
        }
    }
}
