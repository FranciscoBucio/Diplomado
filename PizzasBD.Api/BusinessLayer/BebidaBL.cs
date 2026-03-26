using Microsoft.EntityFrameworkCore;
using Pizzas.Api.DTOs;
using PizzasBD.Api.Data;
using PizzasBD.Api.Interfaces;

namespace PizzasBD.Api.BusinessLayer
{
    public class BebidaBL : IBebidaBL
    {
        private readonly AppDbContext _appDbContext;

        public BebidaBL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<ProductoDTO>> ObtenerBebidas()
        {
            var entities = await _appDbContext.Productos
                .Where(p => p.Menu == "bebidas")
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