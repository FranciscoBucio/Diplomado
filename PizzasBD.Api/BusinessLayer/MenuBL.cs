using Microsoft.EntityFrameworkCore;
using Pizzas.Api.DTOs;
using PizzasBD.Api.Data;
using PizzasBD.Api.Interfaces;

namespace PizzasBD.Api.BusinessLayer
{
    public class MenuBL : IMenuBL
    {
        private readonly AppDbContext _appDbContext;

        public MenuBL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<MenuDTO>> ObtenerMenus()
        {
            var entities = await _appDbContext.Menus.ToListAsync();

            return entities.Select(e => new MenuDTO
            {
                Id = e.Id,
                Titulo = e.Titulo,
                Subtitulo = e.Subtitulo,
                Ruta = e.Ruta
            }).ToList();
        }
    }
}