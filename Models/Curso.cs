using System;
using System.Collections.Generic;

namespace Gestion_Cursos.Models;

public partial class Curso
{
    public int CursoId { get; set; }

    public string? NombreCurso { get; set; }

    public string? Descripcion { get; set; }

    public string? Horario { get; set; }

    public int ProfesorId { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();

    public virtual Profesore Profesor { get; set; } = null!;
}
