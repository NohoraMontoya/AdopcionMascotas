using System.ComponentModel.DataAnnotations;

namespace AdopcionWeb.Models;

public class Persona
{
    [Key]
    public long Id { get; set; }

    [Required(ErrorMessage = "La cédula es un campo obligatorio.")]
    [MaxLength(255, ErrorMessage = "La cédula no puede tener más de 255 caracteres.")]
    public string? Cedula { get; set; }

    [Required(ErrorMessage = "El nombre es un campo obligatorio.")]
    [MaxLength(255, ErrorMessage = "El nombre no puede tener más de 255 caracteres.")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "Los apellidos son un campo obligatorio.")]
    [MaxLength(255, ErrorMessage = "Los apellidos no pueden tener más de 255 caracteres.")]
    public string? Apellidos { get; set; }

    [Required(ErrorMessage = "El correo es un campo obligatorio.")]
    [MaxLength(255, ErrorMessage = "El correo no puede tener más de 255 caracteres.")]
    [EmailAddress(ErrorMessage = "Debe ingresar un correo electrónico válido.")]
    public string? Correo { get; set; }

    [Required(ErrorMessage = "El teléfono es un campo obligatorio.")]
    [MaxLength(255, ErrorMessage = "El teléfono no puede tener más de 255 caracteres.")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "La dirección es un campo obligatorio.")]
    [MaxLength(255, ErrorMessage = "La dirección no puede tener más de 255 caracteres.")]
    public string? Direccion { get; set; }

    [Required(ErrorMessage = "La descripción del hogar es un campo obligatorio.")]
    [MaxLength(255, ErrorMessage = "La descripción del hogar no puede tener más de 255 caracteres.")]
    public string? DescripcionHogar { get; set; }

    [Required(ErrorMessage = "Debe indicarse si la persona es válida.")]
    public bool EsValido { get; set; } = true;

    // Relación con Adopciones
    public ICollection<Adopcion> Adopciones { get; set; }
}

