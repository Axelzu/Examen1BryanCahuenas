using System;
using System.ComponentModel.DataAnnotations;

public class PlanRecompensa
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime FechaInicio { get; set; }

    public int PuntosAcumulados { get; set; }

    public string TipoRecompensa
    {
        get
        {
            return PuntosAcumulados < 500 ? "SILVER" : "GOLD";
        }
    }

    // Opcional: Relación con Cliente
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
}
