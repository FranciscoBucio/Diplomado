using Microsoft.EntityFrameworkCore;
using Pizzas.Api.DTOs;
using PizzasBD.Api.Data;
using PizzasBD.Api.Interfaces;

namespace PizzasBD.Api.BusinessLayer
{
    public class TamanioBL : ITamanioBL
    {
        private readonly AppDbContext _appDbContext;

        public TamanioBL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<TamanioDTO>> ObtenerTamanios()
        {
            var entities = await _appDbContext.Tamanios.ToListAsync();

            return entities.Select(e => new TamanioDTO
            {
                Id = e.Id,
                Descripcion = e.Descripcion,
                Precio = e.Precio
            }).ToList();
        }
    }
}