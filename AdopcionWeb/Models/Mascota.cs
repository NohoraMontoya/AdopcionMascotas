using System.ComponentModel.DataAnnotations;

namespace AdopcionWeb.Models;

public class Mascota
{
    [Key]
    public long Id { get; set; }

    [Required(ErrorMessage = "El nombre de la mascota es obligatorio.")]
    [MaxLength(255, ErrorMessage = "El nombre no puede tener más de 255 caracteres.")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "La fecha en que fue encontrada la mascota es obligatoria.")]
    public DateTime? FechaEncontrado { get; set; }

    [Required(ErrorMessage = "La fecha de posible nacimiento es obligatoria.")]
    public DateTime? FechaPosibleNacimiento { get; set; }

    [Required(ErrorMessage = "El tipo de mascota es obligatorio.")]
    [MaxLength(255, ErrorMessage = "El tipo de mascota no puede tener más de 255 caracteres.")]
    public string? TipoMascota { get; set; }

    [Required(ErrorMessage = "Las posibles enfermedades son obligatorias.")]
    [MaxLength(255, ErrorMessage = "Las posibles enfermedades no pueden tener más de 255 caracteres.")]
    public string? PosiblesEnfermedades { get; set; }

    [MaxLength(255, ErrorMessage = "La raza no puede tener más de 255 caracteres.")]
    public string? Raza { get; set; }

    [MaxLength(255, ErrorMessage = "La URL de la foto no puede tener más de 255 caracteres.")]
    public string? Foto { get; set; }

    [MaxLength(255, ErrorMessage = "Las características no pueden tener más de 255 caracteres.")]
    public string? Caracteristicas { get; set; }

    [Required(ErrorMessage = "Debe indicarse si la mascota está disponible para adopción.")]
    public bool EsAdopcion { get; set; } = false;

    [Required(ErrorMessage = "Debe indicarse si la mascota es válida.")]
    public bool EsValido { get; set; } = true;

    // Relación con Adopciones
    public ICollection<Adopcion> Adopciones { get; set; }
}
