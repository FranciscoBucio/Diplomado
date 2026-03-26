using Pizzas.Api.DTOs;

namespace PizzasBD.Api.Interfaces
{
    public interface IMasaBL
    {
        Task<List<MasaDTO>> ObtenerMasas();
    }
}