using System;
using System.ComponentModel.DataAnnotations;

public class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Range(0, 120, ErrorMessage = "La edad debe estar entre 0 y 120")]
    public int Edad { get; set; }  

    [Required]
    [EmailAddress(ErrorMessage = "Ingrese un correo válido")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime FechaRegistro { get; set; } /

    public bool EsActivo { get; set; } 

    [Range(0, 10000)]
    public decimal Saldo { get; set; } // decimal
}
