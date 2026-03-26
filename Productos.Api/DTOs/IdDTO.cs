namespace Productos.Api.DTOs;

public class IdDTO
{
    public int Id { get; set; }
    public string Mensaje { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;

}
