using Pizzas.Api.DTOs;

namespace Pizzas.Api.Services
{
    public class MasaService
    {
        public List<MasaDTO> ObtenerMasas()
        {
            var masas = new List<MasaDTO>
            {
                new MasaDTO
                {
                    Id = 1,
                    Nombre = "Original",
                    Descripcion = "La original y clásica masa fresca hecha al momento con orilla dorada y espolvoreada de especias que le dan nuestro toque único."
                },
                new MasaDTO
                {
                    Id = 2,
                    Nombre = "Orilla rellena de queso",
                    Descripcion = "Masa fresca hecha al momento con deliciosa orilla dorada rellena de queso mozzarella derretido y espolvoreada con especias."
                },
                new MasaDTO
                {
                    Id = 3,
                    Nombre = "Sartén",
                    Descripcion = "Masa dorada y esponjosa con toque de mantequilla, doble capa de queso (provolone y mozzarella) e ingredientes hasta la orilla."
                },
                new MasaDTO
                {
                    Id = 4,
                    Nombre = "Crunchy",
                    Descripcion = "Masa delgada y crujiente con borde dorado, perfecta para resaltar el sabor de los ingredientes y ofrecer una experiencia más ligera."
                }
            };
            return masas;
        }
    }
}
