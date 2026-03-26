using Microsoft.EntityFrameworkCore;
using Pizzas.Api.DTOs;
using PizzasBD.Api.Data;
using PizzasBD.Api.Interfaces;

namespace PizzasBD.Api.BusinessLayer
{
    public class MasaBL : IMasaBL
    {
        private readonly AppDbContext _appDbContext;

        public MasaBL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<MasaDTO>> ObtenerMasas()
        {
            var entities = await _appDbContext.Masas.ToListAsync();

            return entities.Select(e => new MasaDTO
            {
                Id = e.Id,
                Nombre = e.Nombre,
                Descripcion = e.Descripcion
            }).ToList();
        }
    }
}