using Microsoft.EntityFrameworkCore;
using Pizzas.Api.DTOs;
using PizzasBD.Api.Data;
using PizzasBD.Api.Interfaces;

namespace PizzasBD.Api.BusinessLayer
{
    public class PollosBL : IPollosBL
    {
        private readonly AppDbContext _appDbContext;

        public PollosBL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<ProductoDTO>> ObtenerPollos()
        {
            var entities = await _appDbContext.Productos
                .Where(p => p.Menu == "pollos")
                .ToListAsync();

            return entities.Select(e => new ProductoDTO
            {
                Id = e.Id,
                Nombre = e.Nombre,
                Descripcion = e.Descripcion,
                Ingredientes = e.Ingredientes,
                Ruta = e.Ruta,
                Menu = e.Menu,
                Precio = e.Precio
            }).ToList();
        }
    }
}