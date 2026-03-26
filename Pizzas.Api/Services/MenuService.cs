using Pizzas.Api.DTOs;

namespace Pizzas.Api.Services
{
    public class MenuService
    {
        public List<MenuDTO> ObtenerMenus()
        {
            var menus = new List<MenuDTO>
            {
                new MenuDTO
                {
                    Id = 1,
                    Titulo = "pizzas",
                    Subtitulo = "Escoge tu especialidad preferida",
                    Ruta = "/images/menus/pizza.png"
                },
                new MenuDTO
                {
                    Id = 2,
                    Titulo = "pollo",
                    Subtitulo = "Jugosas y deliciosas opciones de pollo en una variedad de sabores",
                    Ruta = "/images/menus/chicken.png"
                },
                new MenuDTO
                {
                    Id = 3,
                    Titulo = "adicionales",
                    Subtitulo = "Complementa tu comida con tus adicionales favoritos",
                    Ruta = "/images/menus/breads.png"
                },
                new MenuDTO
                {
                    Id = 4,
                    Titulo = "bebidas",
                    Subtitulo = "Para saciar tu sed",
                    Ruta = "/images/menus/drinks.png"
                },
                new MenuDTO
                {
                    Id = 5,
                    Titulo = "postres",
                    Subtitulo = "Para satisfacer tus antojos",
                    Ruta = "/images/menus/desert.png"
                }
            };
            return menus;
        }
    }
}
