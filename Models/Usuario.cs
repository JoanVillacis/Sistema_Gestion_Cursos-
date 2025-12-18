using System;
using System.Collections.Generic;

namespace Gestion_Cursos.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public bool? Estado { get; set; }

    public virtual Credenciale? Credenciale { get; set; }
}
