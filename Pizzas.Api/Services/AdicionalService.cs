using Pizzas.Api.DTOs;

namespace Pizzas.Api.Services
{
    public class AdicionalService
    {
        public List<ProductoDTO> ObtenerAdicionales()
        {
            var adicionales = new List<ProductoDTO>
            {
                new ProductoDTO
                {
                    Id = 31,
                    Nombre = "Papotas",
                    Descripcion = "Gajos de papa horneada, con un toque picosito(250 Cal)",
                    Ingredientes = null,
                    Ruta = "images/adicionale/f1dfde0b-b388-4b7f-9a56-f9f1df41d11b.jpg",
                    Menu = "adicionales",
                    Precio = 79
                },
                new ProductoDTO
                {
                    Id = 32,
                    Nombre = "Cheesy Bread",
                    Descripcion = "Delicioso pan horneado relleno de queso crema y mozzarella gratinado con queso mozzarella, cheddar y parmesano",
                    Ingredientes = null,
                    Ruta = "images/adicionale/893340b6-16ab-4d86-90a3-6ea90d31edb6.jpg",
                    Menu = "adicionales",
                    Precio = 99
                },
                new ProductoDTO
                {
                    Id = 33,
                    Nombre = "Cheesy Bread chorizo jalapeño",
                    Descripcion = "Delicioso pan horneado al momento, relleno de queso crema, queso mozzarella, chorizo y jalapeño con un toque de finas hierbas. Gratinado con una capa de queso mozzarella, cheddar y parmesano",
                    Ingredientes = null,
                    Ruta = "images/adicionale/7decf559-592d-4891-b655-95284358b2c5.jpg",
                    Menu = "adicionales",
                    Precio = 99
                },
                new ProductoDTO
                {
                    Id = 34,
                    Nombre = "Mango Habanero",
                    Descripcion = "Gajos de papa horneada, con un toque picosito(250 Cal)",
                    Ingredientes = null,
                    Ruta = "images/adicionale/12a5d87c-d067-47d1-a445-db77a2fbf557.jpg",
                    Menu = "adicionales",
                    Precio = 79
                },
                new ProductoDTO
                {
                    Id = 35,
                    Nombre = "Cheespeño",
                    Descripcion = "Dip sabor queso con jalapeño (213 kcal)",
                    Ingredientes = null,
                    Ruta = "images/adicionale/32996a18-c4d4-4e54-bc94-03b4db402038.jpg",
                    Menu = "adicionales",
                    Precio = 20
                },
                new ProductoDTO
                {
                    Id = 36,
                    Nombre = "Brava",
                    Descripcion = "Salsa picante (21.8 kcal)",
                    Ingredientes = null,
                    Ruta = "images/adicionale/10716b71-e4b6-4875-831f-57d934290e51.jpg",
                    Menu = "adicionales",
                    Precio = 20
                },
                new ProductoDTO
                {
                    Id = 37,
                    Nombre = "BBQ",
                    Descripcion = "Salsa de chiles con especias (31.4 kcal)",
                    Ingredientes = null,
                    Ruta = "images/adicionale/5406d44a-5607-44b0-876d-7bb931d3a28d.jpg",
                    Menu = "adicionales",
                    Precio = 20
                },
                new ProductoDTO
                {
                    Id = 38,
                    Nombre = "Ranch",
                    Descripcion = "Aderezo sabor queso parmesano y ajo (203.3 kcal)",
                    Ingredientes = null,
                    Ruta = "images/adicionales/9c5ab2c7-14cb-4cdd-8e6a-7b836ceb1411.jpg",
                    Menu = "adicionales",
                    Precio = 20
                }
            };
            return adicionales;
        }
    }
}
