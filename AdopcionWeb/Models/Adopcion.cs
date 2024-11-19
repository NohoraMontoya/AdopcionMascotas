using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdopcionWeb.Models;

public class Adopcion
{
    [Key]
    public long Id { get; set; }

    [Required(ErrorMessage = "La mascota es un campo obligatorio.")]
    [ForeignKey("Mascota")]
    public long? MascotaId { get; set; }

    [Required(ErrorMessage = "La persona es un campo obligatorio.")]
    [ForeignKey("Persona")]
    public long? PersonaId { get; set; }

    [Required(ErrorMessage = "La fecha de adopción es obligatoria.")]
    public DateTime? FechaAdopcion { get; set; }

    public DateTime? FechaTerminoSeguimiento { get; set; }

    // Relaciones con Mascota y Persona
    public Mascota Mascota { get; set; }
    public Persona Persona { get; set; }

    // Relación con Visitas
    public ICollection<Visita> Visitas { get; set; }
}
