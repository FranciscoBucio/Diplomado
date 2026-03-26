using Pizzas.Api.DTOs;

namespace PizzasBD.Api.Interfaces
{
    public interface IBebidaBL
    {
        Task<List<ProductoDTO>> ObtenerBebidas();
    }
}
