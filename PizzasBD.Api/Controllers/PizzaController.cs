using Microsoft.AspNetCore.Mvc;
using Pizzas.Api.DTOs;
using PizzasBD.Api.Interfaces;

namespace PizzasBD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaBL _pizzaBL;
        private readonly IMasaBL _masaBL;
        private readonly IBebidaBL _bebidaBL;
        private readonly IPollosBL _pollosBL;
        private readonly IAdicionalBL _adicionalBL;
        private readonly IMenuBL _menuBL;
        private readonly ITamanioBL _tamanioBL;

        public PizzaController(IPizzaBL pizzaBL, IMasaBL masaBL, IBebidaBL bebidaBL, IPollosBL pollosBL, IAdicionalBL adicionalBL, IMenuBL menuBL, ITamanioBL tamanioBL)
        {
            _pizzaBL = pizzaBL;
            _masaBL = masaBL;
            _bebidaBL = bebidaBL;
            _pollosBL = pollosBL;
            _adicionalBL = adicionalBL;
            _menuBL = menuBL;
            _tamanioBL = tamanioBL;
        }

        /// <summary>
        /// Obtener lista de menús disponibles
        /// </summary>
        /// <returns>Lista de menús</returns>
        /// <response code="200">Regresa la lista de menús</response>
        [HttpGet("menus")]
        [Produces("application/json")]
        [ProducesResponseType<List<MenuDTO>>(StatusCodes.Status200OK)]
        public async Task<IActionResult> ObtenerMenus()
        {
            List<MenuDTO> menus = await _menuBL.ObtenerMenus();
            return Ok(menus);
        }

        /// <summary>
        /// Obtener lista de pizzas disponibles
        /// </summary>
        /// <returns>Lista de pizzas</returns>
        /// <response code="200">Regresa la lista de pizzas</response>
        [HttpGet("pizzas")]
        [Produces("application/json")]
        [ProducesResponseType<List<ProductoDTO>>(StatusCodes.Status200OK)]
        public async Task<IActionResult> ObtenerPizzas()
        {
            List<ProductoDTO> pizzas = await _pizzaBL.ObtenerPizzas();
            return Ok(pizzas);
        }

        /// <summary>
        /// Obtener lista de masas disponibles
        /// </summary>
        /// <returns>Lista de masas</returns>
        /// <response code="200">Regresa la lista de masas</response>
        [HttpGet("pizzas/masas")]
        [Produces("application/json")]
        [ProducesResponseType<List<MasaDTO>>(StatusCodes.Status200OK)]
        public async Task<IActionResult> ObtenerMasas()
        {
            List<MasaDTO> masas = await _masaBL.ObtenerMasas();
            return Ok(masas);
        }

        /// <summary>
        /// Obtener lista de tamaños disponibles
        /// </summary>
        /// <returns>Lista de tamaños</returns>
        /// <response code="200">Regresa la lista de tamaños</response>
        [HttpGet("pizzas/tamanios")]
        [Produces("application/json")]
        [ProducesResponseType<List<TamanioDTO>>(StatusCodes.Status200OK)]
        public async Task<IActionResult> ObtenerTamanios()
        {
            List<TamanioDTO> tamanios = await _tamanioBL.ObtenerTamanios();
            return Ok(tamanios);
        }

        /// <summary>
        /// Obtener lista de pollos disponibles
        /// </summary>
        /// <returns>Lista de pollos</returns>
        /// <response code="200">Regresa la lista de pollos</response>
        [HttpGet("pollos")]
        [Produces("application/json")]
        [ProducesResponseType<List<ProductoDTO>>(StatusCodes.Status200OK)]
        public async Task<IActionResult> ObtenerPollos()
        {
            List<ProductoDTO> pollos = await _pollosBL.ObtenerPollos();
            return Ok(pollos);
        }

        /// <summary>
        /// Obtener lista de adicionales disponibles
        /// </summary>
        /// <returns>Lista de adicionales</returns>
        /// <response code="200">Regresa la lista de adicionales</response>
        [HttpGet("adicionales")]
        [Produces("application/json")]
        [ProducesResponseType<List<ProductoDTO>>(StatusCodes.Status200OK)]
        public async Task<IActionResult> ObtenerAdicionales()
        {
            List<ProductoDTO> adicionales = await _adicionalBL.ObtenerAdicionales();
            return Ok(adicionales);
        }

        /// <summary>
        /// Obtener lista de bebidas disponibles
        /// </summary>
        /// <returns>Lista de bebidas</returns>
        /// <response code="200">Regresa la lista de bebidas</response>
        [HttpGet("bebidas")]
        [Produces("application/json")]
        [ProducesResponseType<List<ProductoDTO>>(StatusCodes.Status200OK)]
        public async Task<IActionResult> ObtenerBebidas()
        {
            List<ProductoDTO> bebidas = await _bebidaBL.ObtenerBebidas();
            return Ok(bebidas);
        }
    }
}
