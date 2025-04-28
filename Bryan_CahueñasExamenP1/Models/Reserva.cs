using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Reserva
{
    public int Id { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime FechaEntrada { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime FechaSalida { get; set; }

    [Required]
    [Range(0, 10000)]
    public decimal ValorPagar { get; set; }

    // Relación
    public int ClienteId { get; set; }
    [ForeignKey("ClienteId")]
    public Cliente Cliente { get; set; }
}
