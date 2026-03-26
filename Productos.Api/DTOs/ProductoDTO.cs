using System.ComponentModel.DataAnnotations;

namespace Productos.Api.DTOs
{
    public class ProductoDTO
    {
        public int Id { get; set; }

        public Guid Encodedkey { get; set; } = Guid.NewGuid();

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public string ImagenUrl { get; set; }
    }
}
