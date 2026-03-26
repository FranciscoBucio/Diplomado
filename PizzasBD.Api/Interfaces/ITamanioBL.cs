using Pizzas.Api.DTOs;

namespace PizzasBD.Api.Interfaces
{
    public interface ITamanioBL
    {
        Task<List<TamanioDTO>> ObtenerTamanios();
    }
}