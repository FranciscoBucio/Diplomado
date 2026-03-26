using Productos.Api.DTOs;

namespace Productos.Api.Interfaces
{
    public interface IProductoBL
    {
        Task<List<ProductoDTO>> ObtenerProductos();
        Task<ProductoDTO> ObtenerProductoPorId(int id);
        Task<IdDTO> CrearProducto(ProductoDTOIn producto);
    }
}
