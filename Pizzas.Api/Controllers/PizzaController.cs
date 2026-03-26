using Microsoft.AspNetCore.Mvc;
using Pizzas.Api.DTOs;
using Pizzas.Api.Services;

namespace Pizzas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : Controller
    {
        PizzaService _pizzaService;
        MasaService _masaService;
        BebidaService _bebidaService;
        PolloService _polloService;
        AdicionalService _adicionalService;
        MenuService _menuService;
        TamanioService _tamanioService;

        public PizzaController(PizzaService pizzaService, MasaService masaService, BebidaService bebidaService, PolloService polloService, AdicionalService adicionalService, MenuService menuService, TamanioService tamanioService)
        {
            _pizzaService = pizzaService;
            _masaService = masaService;
            _bebidaService = bebidaService;
            _polloService = polloService;
            _adicionalService = adicionalService;
            _menuService = menuService;
            _tamanioService = tamanioService;
        }

        /// <summary>
        /// Obtener lista de menús disponibles
        /// </summary>
        /// <returns>Lista de menús</returns>
        /// <response code="200">Regresa la lista de menús</response>
        [HttpGet("menus")]
        [Produces("application/json")]
        [ProducesResponseType<List<MenuDTO>>(StatusCodes.Status200OK)]
        public ActionResult ObtenerMenus()
        {
            List<MenuDTO> menus = _menuService.ObtenerMenus();
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
        public ActionResult ObtenerPizzas()
        {
            List<ProductoDTO> pizzas = _pizzaService.ObtenerPizzas();
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
        public ActionResult ObtenerMasas()
        {
            List<MasaDTO> masas = _masaService.ObtenerMasas();
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
        public ActionResult ObtenerTamanios()
        {
            List<TamanioDTO> tamanios = _tamanioService.ObtenerTamanios();
            return Ok(tamanios);
        }

        /// <summary>
        /// Obtener lista de productos de pollo disponibles
        /// </summary>
        /// <returns>Lista de productos de pollo</returns>
        /// <response code="200">Regresa la lista de productos de pollo</response>
        [HttpGet("pollos")]
        [Produces("application/json")]
        [ProducesResponseType<List<ProductoDTO>>(StatusCodes.Status200OK)]
        public ActionResult ObtenerProductosPollo()
        {
            List<ProductoDTO> pollos = _polloService.ObtenerPollos();
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
        public ActionResult ObtenerAdicionales()
        {
            List<ProductoDTO> adicionales = _adicionalService.ObtenerAdicionales();
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
        public ActionResult ObtenerBebidas()
        {
            List<ProductoDTO> bebidas = _bebidaService.ObtenerBebidas();
            return Ok(bebidas);
        }
    }
}
