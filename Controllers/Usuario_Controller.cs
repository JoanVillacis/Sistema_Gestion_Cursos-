using Gestion_Cursos.Data;
using Gestion_Cursos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cursos.Controllers
{
    public class Usuario_Controller
    {
        private readonly Gestion_Curso_DbContext _Usuario_Dbcontext = new Gestion_Curso_DbContext();

        public List<Usuario> todos()
        {
            try
            {
                return _Usuario_Dbcontext.Usuarios
                    .Include(u => u.Credenciale)
                    .AsNoTracking()
                    .Where(a => a.Estado == true)
                    .ToList();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(msg, "Error al obtener usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Usuario>();
            }
        }

        public Usuario uno(int id)
        {
            try
            {
                return _Usuario_Dbcontext.Usuarios
                    .Include(u => u.Credenciale)
                    .AsNoTracking()
                    .Where(a => a.Estado == true)
                    .FirstOrDefault(a => a.UsuarioId == id);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(msg, "Error al obtener usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string insertar(Usuario usuario)
        {
            if (usuario == null)
            {
                return "Debe completar las cajas de texto para guardar al usuario";
            }

            try
            {
                // Si viene credencial, asociarla por navegación para que EF inserte en la misma transacción
                if (usuario.Credenciale != null)
                {
                    // Asegurar que no venga valor explícito en la PK de Credencial
                    usuario.Credenciale.CredencialId =0;
                    usuario.Credenciale.Usuario = usuario;
                }

                _Usuario_Dbcontext.Usuarios.Add(usuario);
                _Usuario_Dbcontext.SaveChanges();

                return "ok";
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                return msg;
            }
        }

        public string actualizar(Usuario usuario)
        {
            if (usuario == null)
            {
                return "Debe completar las cajas de texto para actualizar al usuario";
            }

            try
            {
                var usuario_existente = _Usuario_Dbcontext.Usuarios
                    .Include(u => u.Credenciale)
                    .FirstOrDefault(u => u.UsuarioId == usuario.UsuarioId);

                if (usuario_existente == null)
                {
                    return "El usuario no fue encontrado";
                }

                // Actualizar campos del usuario
                usuario_existente.Nombre = usuario.Nombre;
                usuario_existente.Apellido = usuario.Apellido;
                // No sobreescribimos FechaRegistro
                if (usuario.Estado.HasValue)
                    usuario_existente.Estado = usuario.Estado;

                // Manejar credencial: si se envía una cred, actualizar o crear
                if (usuario.Credenciale != null)
                {
                    var cred_existente = usuario_existente.Credenciale;
                    if (cred_existente == null)
                    {
                        // Crear nueva cred asociada
                        usuario.Credenciale.UsuarioId = usuario_existente.UsuarioId;
                        _Usuario_Dbcontext.Credenciales.Add(usuario.Credenciale);
                    }
                    else
                    {
                        cred_existente.Correo = usuario.Credenciale.Correo;
                        cred_existente.Contrasenia = usuario.Credenciale.Contrasenia;
                        cred_existente.Rol = usuario.Credenciale.Rol;
                    }
                }

                _Usuario_Dbcontext.SaveChanges();

                return "ok";
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                return msg;
            }
        }

        public string eliminar(int id)
        {
            try
            {
                var _usuario_existente = _Usuario_Dbcontext.Usuarios.FirstOrDefault(u => u.UsuarioId == id);
                if (_usuario_existente == null)
                {
                    return "El usuario no fue encontrado";
                }

                _usuario_existente.Estado = false;
                _Usuario_Dbcontext.SaveChanges();

                return "ok";
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                return msg;
            }
        }

        public bool EmailExists(string email)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(email)) return false;
                return _Usuario_Dbcontext.Credenciales.Any(c => c.Correo == email);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(msg, "Error al verificar email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
