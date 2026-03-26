using Pizzas.Api.DTOs;

namespace PizzasBD.Api.Interfaces
{
    public interface IAdicionalBL
    {
        Task<List<ProductoDTO>> ObtenerAdicionales();
    }
}