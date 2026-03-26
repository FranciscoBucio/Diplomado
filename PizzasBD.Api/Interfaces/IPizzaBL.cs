using Pizzas.Api.DTOs;

namespace PizzasBD.Api.Interfaces
{
    public interface IPizzaBL
    {
        Task<List<ProductoDTO>> ObtenerPizzas();
    }
}