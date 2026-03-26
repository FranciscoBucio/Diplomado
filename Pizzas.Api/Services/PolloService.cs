using Pizzas.Api.DTOs;

namespace Pizzas.Api.Services
{
    public class PolloService
    {
        public List<ProductoDTO> ObtenerPollos()
        {
            var pollos = new List<ProductoDTO>
            {
                new ProductoDTO
                {
                    Id = 21,
                    Nombre = "Alitas cayene",
                    Descripcion = "Salsa picosita con un toque de diferentes chiles (490 Cal)",
                    Ingredientes = null,
                    Ruta = "images/pollos/1ecf11f9-4e5d-460a-bead-521c53502a30.jpg",
                    Menu = "pollos",
                    Precio = 139
                },
                new ProductoDTO
                {
                    Id = 22,
                    Nombre = "Alitas BBQ",
                    Descripcion = "Con el sabor tradicional dulce ahumado que ya canoces (490 Cal)",
                    Ingredientes = null,
                    Ruta = "images/pollos/48365980-9741-410e-87db-57b760d6c941.jpg",
                    Menu = "pollos",
                    Precio = 139
                },
                new ProductoDTO
                {
                    Id = 23,
                    Nombre = "Alitas Mango habanero",
                    Descripcion = "Una mezcla picosita de sabores dulce con habanero (490 Cal)",
                    Ingredientes = null,
                    Ruta = "images/pollos/fa57713d-549f-45c8-9d5c-9ba97f103c69.jpg",
                    Menu = "pollos",
                    Precio = 139
                },
                new ProductoDTO
                {
                    Id = 24,
                    Nombre = "Alitas Naturales",
                    Descripcion = "Deliciosas y horneadas con gran sabor al natural (490 Cal)",
                    Ingredientes = null,
                    Ruta = "images/pollos/61b65a6c-ae9c-44a1-8f9e-b54a0a83ffd2.jpg",
                    Menu = "pollos",
                    Precio = 139
                },
                new ProductoDTO
                {
                    Id = 25,
                    Nombre = "Boneless Cayenne",
                    Descripcion = "Salsa picosita con un toque de diferentes chiles (360 Cal)",
                    Ingredientes = null,
                    Ruta = "images/pollos/1ecf11f9-4e5d-460a-bead-521c53502a30.jpg",
                    Menu = "pollos",
                    Precio = 139
                },
                new ProductoDTO
                {
                    Id = 26,
                    Nombre = "Boneless BBQ",
                    Descripcion = "Con el sabor tradicional dulce ahumado que ya canoces (390 Cal)",
                    Ingredientes = null,
                    Ruta = "images/pollos/0287fd68-2857-418e-b672-64a253107531.jpg",
                    Menu = "pollos",
                    Precio = 139
                },
                new ProductoDTO
                {
                    Id = 27,
                    Nombre = "Boneless Mango habanero",
                    Descripcion = "Una mezcla picosita de sabores dulce con habanero (390 Cal)",
                    Ingredientes = null,
                    Ruta = "images/pollos/09959116-b5ef-4bbf-802f-85c57025226e.jpg",
                    Menu = "pollos",
                    Precio = 139
                },
                new ProductoDTO
                {
                    Id = 28,
                    Nombre = "Boneless Naturales",
                    Descripcion = "Deliciosas y horneadas con gran sabor al natural (490 Cal)",
                    Ingredientes = null,
                    Ruta = "images/pollos/fafc0900-9fb2-4c12-9a85-f15830e0bfd0.jpg",
                    Menu = "pollos",
                    Precio = 139
                }
            };
            return pollos;
        }
    }
}
