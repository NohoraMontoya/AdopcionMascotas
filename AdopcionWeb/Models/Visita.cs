
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdopcionWeb.Models;
public class Visita
{
    [Key]
    public long Id { get; set; }

    [Required(ErrorMessage = "La adopción es un campo obligatorio.")]
    [ForeignKey("Adopcion")]
    public long? AdopcionId { get; set; }

    [Required(ErrorMessage = "La fecha de la visita es un campo obligatorio.")]
    public DateTime? FechaVisita { get; set; }

    [Required(ErrorMessage = "La descripción es un campo obligatorio.")]
    public string? Descripcion { get; set; }

    [Required(ErrorMessage = "Debe indicar las condiciones de la mascota.")]
    public bool CondicionesMascota { get; set; }

    // Relación con Adopcion
    public Adopcion Adopcion { get; set; }
}
