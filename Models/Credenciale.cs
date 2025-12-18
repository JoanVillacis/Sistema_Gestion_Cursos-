using System;
using System.Collections.Generic;

namespace Gestion_Cursos.Models;

public partial class Credenciale
{
    public int CredencialId { get; set; }

    public int UsuarioId { get; set; }

    public string Correo { get; set; } = null!;

    public string Contrasenia { get; set; } = null!;

    public string Rol { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
