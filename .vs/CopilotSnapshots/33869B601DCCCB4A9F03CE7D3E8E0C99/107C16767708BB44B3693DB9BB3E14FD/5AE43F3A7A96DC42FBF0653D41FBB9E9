using Gestion_Cursos.Data;
using Gestion_Cursos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cursos.Controllers
{
    public class Estudiante_Controller
    {
        private readonly Gestion_Curso_DbContext _Estudiante_DBContext = new Gestion_Curso_DbContext();

        public List<Estudiante> todos()
        {
            try
            {
                return _Estudiante_DBContext.Estudiantes
                    .Include(e => e.Inscripciones)
                    .AsNoTracking()
                    .Where(e => e.Estado == true)
                    .ToList();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(msg, "Error al obtener estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Estudiante>();
            }
        }

        public Estudiante uno(int id)
        {
            try
            {
                return _Estudiante_DBContext.Estudiantes
                    .Include(e => e.Inscripciones)
                    .AsNoTracking()
                    .FirstOrDefault(e => e.EstudianteId == id && e.Estado == true);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(msg, "Error al obtener estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string insertar(Estudiante estudiante)
        {
            if (estudiante == null)
            {
                return "Debe completar las cajas de texto para guardar al estudiante";
            }

            try
            {
                // Validaciones simples
                if (!string.IsNullOrWhiteSpace(estudiante.Email) && EmailExists(estudiante.Email))
                {
                    return "El correo ya se encuentra registrado";
                }
                if (!string.IsNullOrWhiteSpace(estudiante.Cedula) && CedulaExists(estudiante.Cedula))
                {
                    return "La cédula ya se encuentra registrada";
                }

                _Estudiante_DBContext.Estudiantes.Add(estudiante);
                _Estudiante_DBContext.SaveChanges();

                return "ok";
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                return msg;
            }
        }

        public string actualizar(Estudiante estudiante)
        {
            if (estudiante == null)
            {
                return "Debe completar las cajas de texto para actualizar al estudiante";
            }

            try
            {
                var existente = _Estudiante_DBContext.Estudiantes.FirstOrDefault(e => e.EstudianteId == estudiante.EstudianteId);
                if (existente == null)
                {
                    return "El estudiante no fue encontrado";
                }

                // Validar email y cédula si cambian
                if (!string.IsNullOrWhiteSpace(estudiante.Email) && estudiante.Email != existente.Email && EmailExists(estudiante.Email))
                {
                    return "El correo ya se encuentra registrado";
                }
                if (!string.IsNullOrWhiteSpace(estudiante.Cedula) && estudiante.Cedula != existente.Cedula && CedulaExists(estudiante.Cedula))
                {
                    return "La cédula ya se encuentra registrada";
                }

                // Actualizar campos
                existente.Cedula = estudiante.Cedula;
                existente.Nombre = estudiante.Nombre;
                existente.Apellido = estudiante.Apellido;
                existente.FechaNacimiento = estudiante.FechaNacimiento;
                existente.Genero = estudiante.Genero;
                existente.Ciudad = estudiante.Ciudad;
                existente.Direccion = estudiante.Direccion;
                existente.Email = estudiante.Email;
                existente.Telefono = estudiante.Telefono;
                if (estudiante.FechaRegistro.HasValue)
                    existente.FechaRegistro = estudiante.FechaRegistro;
                if (estudiante.Estado.HasValue)
                    existente.Estado = estudiante.Estado;

                _Estudiante_DBContext.SaveChanges();

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
                var existente = _Estudiante_DBContext.Estudiantes.FirstOrDefault(e => e.EstudianteId == id);
                if (existente == null)
                {
                    return "El estudiante no fue encontrado";
                }

                existente.Estado = false;
                _Estudiante_DBContext.SaveChanges();

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
                return _Estudiante_DBContext.Estudiantes.Any(e => e.Email == email);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(msg, "Error al verificar email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CedulaExists(string cedula)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cedula)) return false;
                return _Estudiante_DBContext.Estudiantes.Any(e => e.Cedula == cedula);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(msg, "Error al verificar cédula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
