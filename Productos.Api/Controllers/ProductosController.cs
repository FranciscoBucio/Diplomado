using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Productos.Api.BusinessLayer;
using Productos.Api.Context;
using Productos.Api.DTOs;
using Productos.Api.Entities;
using Productos.Api.Interfaces;

namespace Productos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoBL _productoBL;
        public ProductosController(IProductoBL productoBL)
        {
            _productoBL = productoBL;
        }

        /// <summary>
        /// Obtener lista de productos disponibles
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Regresa la lista de productos</response>
        [ProducesResponseType<List<ProductoDTO>>(StatusCodes.Status200OK)]
        [Produces("application/json")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<ProductoDTO> productos = await _productoBL.ObtenerProductos();
            return Ok(productos);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductoDTOIn producto)
        {
            IdDTO idDTO = await _productoBL.CrearProducto(producto);
            return Created($"Productos/{idDTO.Id}", idDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            ProductoDTO producto = await _productoBL.ObtenerProductoPorId(id);
            return Ok(producto);
        }
    }
}
