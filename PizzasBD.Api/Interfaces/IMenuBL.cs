using Pizzas.Api.DTOs;

namespace PizzasBD.Api.Interfaces
{
    public interface IMenuBL
    {
        Task<List<MenuDTO>> ObtenerMenus();
    }
}