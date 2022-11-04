using System.ComponentModel.DataAnnotations;

namespace Vehiculos20191413.Data.Models;
public class Vehiculo
{
    [Key]
    public int VehiculoId { get; set; }
    public string Marca { get; set; } 
    public string Modelo { get; set; }
    public int Año { get; set; }
    public string Color { get; set; }

}