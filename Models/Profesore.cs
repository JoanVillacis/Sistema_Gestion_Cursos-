using System;
using System.Collections.Generic;

namespace Gestion_Cursos.Models;

public partial class Profesore
{
    public int ProfesorId { get; set; }

    public string Cedula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public string? Genero { get; set; }

    public string? Ciudad { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Especialidad { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();
}
