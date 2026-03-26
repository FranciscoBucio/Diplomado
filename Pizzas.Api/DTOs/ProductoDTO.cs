namespace Pizzas.Api.DTOs;

public class ProductoDTO
{
    public int  Id { get; set; }    
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Ingredientes { get; set; }
    public string Ruta { get; set; }
    public string Menu { get; set; }
    public decimal Precio { get; set; }
}
