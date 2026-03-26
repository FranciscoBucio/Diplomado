using Pizzas.Api.DTOs;

namespace PizzasBD.Api.Interfaces
{
    public interface IPollosBL
    {
        Task<List<ProductoDTO>> ObtenerPollos();
    }
}