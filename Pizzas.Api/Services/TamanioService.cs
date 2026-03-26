using Pizzas.Api.DTOs;

namespace Pizzas.Api.Services
{
    public class TamanioService
    {
        public List<TamanioDTO> ObtenerTamanios()
        {
            var tamanios = new List<TamanioDTO>
            {
                new TamanioDTO
                {
                    Id = 30,
                    Descripcion = "Mediana 30 cm",
                    Precio = 199
                },
                new TamanioDTO
                {
                    Id = 35,
                    Descripcion = "Grande 35 cm",
                    Precio = 229
                },
                new TamanioDTO
                {
                    Id = 40,
                    Descripcion = "Italiana 40 cm",
                    Precio = 279
                },
                new TamanioDTO
                {
                    Id = 45,
                    Descripcion = "Dominator 45 cm",
                    Precio = 379
                }
            };
            return tamanios;
        }
    }
}
