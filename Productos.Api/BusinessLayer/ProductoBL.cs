using Microsoft.EntityFrameworkCore;
using Productos.Api.Context;
using Productos.Api.DTOs;
using Productos.Api.Entities;
using Productos.Api.Interfaces;

namespace Productos.Api.BusinessLayer
{
    public class ProductoBL : IProductoBL
    {
        private readonly AppDbContext _appDbContext;
        public ProductoBL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<ProductoDTO>> ObtenerProductos()
        {
            List<ProductoDTO> productos;
            var entities = await _appDbContext.Producto.ToListAsync();
            productos = entities.Select(e => new ProductoDTO
            {
                Id = e.Id,
                Encodedkey = e.Encodedkey,
                Nombre = e.Nombre,
                Descripcion = e.Descripcion,
                Precio = e.Precio,
                ImagenUrl = e.ImagenUrl
            }).ToList();
            return productos;
        }

        public async Task<IdDTO> CrearProducto(ProductoDTOIn producto)
        {
            var entity = new ProductoEntity
            {
                Encodedkey = producto.Encodedkey,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                Precio = producto.Precio,
                ImagenUrl = producto.ImagenUrl
            };
            _appDbContext.Producto.Add(entity);
            await _appDbContext.SaveChangesAsync();
            IdDTO idDTO = new IdDTO { Id = entity.Id, Mensaje = "Producto agregado" };
            return idDTO;
        }

        public async Task<ProductoDTO> ObtenerProductoPorId(int id)
        {
            var entity = await _appDbContext.Producto.FindAsync(id);
            if (entity == null)
            {
                return null;
            }
            ProductoDTO producto = new ProductoDTO
            {
                Id = entity.Id,
                Encodedkey = entity.Encodedkey,
                Nombre = entity.Nombre,
                Descripcion = entity.Descripcion,
                Precio = entity.Precio,
                ImagenUrl = entity.ImagenUrl
            };
            return producto;
        }

    }
}
