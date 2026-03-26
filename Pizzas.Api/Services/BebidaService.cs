using Pizzas.Api.DTOs;

namespace Pizzas.Api.Services
{
    public class BebidaService
    {
        public List<DTOs.ProductoDTO> ObtenerBebidas()
        {
            var bebidas = new List<ProductoDTO>
            {
                new ProductoDTO
                {
                    Id = 41,
                    Nombre = "Pepsi 600 ml",
                    Descripcion = "Experimenta todo el sabor cola, refrescando y amplificando cada momento (113 Cal)",
                    Ingredientes = null,
                    Ruta = "images/bebidas/5090ae51-956d-42b0-a51a-cf5af5636032.jpg",
                    Menu = "bebidas",
                    Precio = 25
                },
                new ProductoDTO
                {
                    Id = 42,
                    Nombre = "Pepsi 1.5 litros",
                    Descripcion = "Experimenta todo el sabor cola, refrescando y amplificando cada momento (113 Cal)",
                    Ingredientes = null,
                    Ruta = "images/bebidas/5090ae51-956d-42b0-a51a-cf5af5636032.jpg",
                    Menu = "bebidas",
                    Precio = 54
                },
                new ProductoDTO
                {
                    Id = 43,
                    Nombre = "Pepsi Ligth 600 ml",
                    Descripcion = "Experimenta y comparte el gran sabor cola, sin calorias (0 Cal)",
                    Ingredientes = null,
                    Ruta = "images/bebidas/48dc6f3f-c5be-45fa-892e-c7064994f642.jpg",
                    Menu = "bebidas",
                    Precio = 25
                },
                new ProductoDTO
                {
                    Id = 44,
                    Nombre = "Pepsi Ligth 1.5 litros",
                    Descripcion = "Experimenta y comparte el gran sabor cola, sin calorias (0 Cal)",
                    Ingredientes = null,
                    Ruta = "images/bebidas/48dc6f3f-c5be-45fa-892e-c7064994f642.jpg",
                    Menu = "bebidas",
                    Precio = 54
                },
                new ProductoDTO
                {
                    Id = 45,
                    Nombre = "7up 600 ml",
                    Descripcion = "Agua, burbujas y los refrescantes sabores naturales de la lima & limón (0 Cal)",
                    Ingredientes = null,
                    Ruta = "images/bebidas/0760521a-dcb5-4be7-b481-fa8b22ed8b88.jpg",
                    Menu = "bebidas",
                    Precio = 32
                },
                new ProductoDTO
                {
                    Id = 46,
                    Nombre = "7up 1.5 litros",
                    Descripcion = "Agua, burbujas y los refrescantes sabores naturales de la lima & limón (0 Cal)",
                    Ingredientes = null,
                    Ruta = "images/bebidas/0760521a-dcb5-4be7-b481-fa8b22ed8b88.jpg",
                    Menu = "bebidas",
                    Precio = 54
                },
                new ProductoDTO
                {
                    Id = 47,
                    Nombre = "E-Pura Natural 600 ml",
                    Descripcion = "Agua purificada que te hidrata y cuida tu corazón por no contener sodio (0 Cal)",
                    Ingredientes = null,
                    Ruta = "images/bebidas/95f1a30b-62f8-4e4a-8f11-644e8a047e79.jpg",
                    Menu = "bebidas",
                    Precio = 32
                }
            };
            return bebidas;
        }
    }
}
