using Pizzas.Api.DTOs;
namespace Pizzas.Api.Services
{
    public class PizzaService
    {
        public List<ProductoDTO> ObtenerPizzas()
        {
            var pizzas = new List<ProductoDTO>
            {
                new ProductoDTO
                {
                    Id = 1,
                    Nombre = "Carbonara",
                    Descripcion = "Queso crema, mozzarella, champiñones frescos, tocino y cebolla: la combinación perfecta para una pizza tan cremosa como irresistible",
                    Ingredientes = null,
                    Ruta = "/images/pizzas/022238e3-ac62-45af-b765-379a077a9b26.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 2,
                    Nombre = "Triple peperoni",
                    Descripcion = "Disfruta tres veces mas de tu ingrediente favorito en esta especialidad",
                    Ingredientes = null,
                    Ruta = "/images/pizzas/00455854-40f9-45e2-a241-b03e70dfe6cc.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 3,
                    Nombre = "Peperoni",
                    Descripcion = "Tu ingrediente favorito en una masa fresca y hecha a mano. (290 Cal)",
                    Ingredientes = null,
                    Ruta = "/images/pizzas/be242cad-08db-4b00-becd-be48a9fb86a4.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 4,
                    Nombre = "Hawaiina",
                    Descripcion = "La pizza que unos cuestionan pero todos aman. Jamón, piña. (290 Cal)",
                    Ingredientes = null,
                    Ruta = "/images/pizzas/75b89c2b-2c59-4225-8478-4e9ab4432ec9.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 5,
                    Nombre = "Mexicana",
                    Descripcion = "La pizza con los sabores auténticos de nuestro país. Chorizo, carne molida, jalapeño, cebolla. (310 Cal)",
                    Ingredientes = null,
                    Ruta = "/images/pizzas/7f339d0c-bf13-4839-a9dc-de6721210a5b.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 6,
                    Nombre = "Texas bbq",
                    Descripcion = "¡Ajúaa! Arre por esta pizza con salsa BBQ, queso mozzarella, tocino, pollo fresco y carne molida bien cocida, sabores que te harán amarla. (320 Cal)",
                    Ingredientes = "Salsa BBQ, Salsa de tomate, Carne molida, Pollo, Tocino",
                    Ruta = "/images/pizzas/67734d82-5c38-40f8-a311-255c0d157bd5.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 7,
                    Nombre = "Cuatro quesos",
                    Descripcion = null,
                    Ingredientes = null,
                    Ruta = "images/pizzas/0ad30a1e-d7ed-4384-9b1e-b8a5c9587174.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 8,
                    Nombre = "Pepperoni especial",
                    Descripcion = null,
                    Ingredientes = null,
                    Ruta = "images/pizzas/8be27c50-bb3c-4774-ac8f-a41f42029617.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 9,
                    Nombre = "Carnes frias",
                    Descripcion = null,
                    Ingredientes = null,
                    Ruta = "images/pizzas/f8748c06-e178-4d38-b99c-a522ad450a86.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 10,
                    Nombre = "Chicken hawaiina",
                    Descripcion = null,
                    Ingredientes = null,
                    Ruta = "images/pizzas/49249843-d9af-4356-bcac-ae94e3357742.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 11,
                    Nombre = "Honolulu",
                    Descripcion = null,
                    Ingredientes = null,
                    Ruta = "images/pizzas/cdcef20a-407a-488e-9751-6f481a871048.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 12,
                    Nombre = "Veggie",
                    Descripcion = null,
                    Ingredientes = null,
                    Ruta = "images/pizzas/3f362b55-3f56-47f9-b67a-ff49eb10f66a.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 13,
                    Nombre = "Extravaganzza",
                    Descripcion = null,
                    Ingredientes = null,
                    Ruta = "images/pizzas/db99ef86-f2b8-4a8e-8afb-5ad4409e4233.jpg",
                    Menu = "Pizza",
                    Precio = 0
                },
                new ProductoDTO
                {
                    Id = 14,
                    Nombre = "Deluxe",
                    Descripcion = null,
                    Ingredientes = null,
                    Ruta = "images/pizzas/9614b6f3-0def-4ace-8c5d-e0954d899a5b.jpg",
                    Menu = "Pizza",
                    Precio = 0
                }
            };
            return pizzas;

        }
    }
}
