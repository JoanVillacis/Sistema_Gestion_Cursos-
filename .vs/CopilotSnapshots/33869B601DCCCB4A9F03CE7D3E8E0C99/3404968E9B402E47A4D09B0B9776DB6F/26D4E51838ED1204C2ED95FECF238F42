using Gestion_Cursos.Data;
using Gestion_Cursos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cursos.Controllers
{
    public class Profesor_Controller
    {
        private readonly Gestion_Curso_DbContext _Profesor_DbContext = new Gestion_Curso_DbContext();

        public List<Profesore> todos()
        {
            try
            {
                return _Profesor_DbContext.Profesores
                    .Include(p => p.Cursos)
                    .AsNoTracking()
                    .Where(p => p.Estado == true)
                    .ToList();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(msg, "Error al obtener profesores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Profesore>();
            }
        }

        public Profesore uno(int id)
        {
            try
            {
                return _Profesor_DbContext.Profesores
                    .Include(p => p.Cursos)
                    .AsNoTracking()
                    .FirstOrDefault(p => p.ProfesorId == id && p.Estado == true);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(msg, "Error al obtener profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string insertar(Profesore profesor)
        {
            if (profesor == null)
            {
                return "Debe completar las cajas de texto para guardar el profesor";
            }

            try
            {
                // Validaciones básicas
                if (!string.IsNullOrWhiteSpace(profesor.Email) && EmailExists(profesor.Email))
                {
                    return "El correo ya se encuentra registrado";
                }
                if (!string.IsNullOrWhiteSpace(profesor.Cedula) && CedulaExists(profesor.Cedula))
                {
                    return "La cédula ya se encuentra registrada";
                }

                _Profesor_DbContext.Profesores.Add(profesor);
                _Profesor_DbContext.SaveChanges();

                return "ok";
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException?.Message ?? ex.Message;
                return msg;
            }
        }

        public string actualizar(Profesore profesor)
        {
            if (profesor == null)
            {
                return "Debe completar las cajas de texto para actualizar el profesor";
            }

            try
            {
                var existente = _Profesor_DbContext.Profesores.FirstOrDefault(p => p.ProfesorId == profesor.ProfesorId);
                if (existente == null)
                {
                    return "El profesor no fue encontrado";
                }

                // Validar email y cédula si cambian
                if (!string.IsNullOrWhiteSpace(profesor.Email) && profesor.Email != existente.Email && EmailExists(profesor.Email))
                {
                    return "El correo ya se encuentra registrado";
                }
                if (!string.IsNullOrWhiteSpace(profesor.Cedula) && profesor.Cedula != existente.Cedula && CedulaExists(profesor.Cedula))
                {
                    return "La cédula ya se encuentra registrada";
                }

                // Actualizar campos
                existente.Cedula = profesor.Cedula;
                existente.Nombre = profesor.Nombre;
                existente.Apellido = profesor.Apellido;
                existente.FechaNacimiento = profesor.FechaNacimiento;
                existente.Genero = profesor.Genero;
                existente.Ciudad = profesor.Ciudad;
                existente.Direccion = profesor.Direccion;
                existente.Email = profesor.Email;
                existente.Telefono = profesor.Telefono;
                existente.Especialidad = profesor.Especialidad;
                if (profesor.Estado.HasValue)
                    existente.Estado = profesor.Estado;

                _Profesor_DbContext.SaveChanges();

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
                var existente = _Profesor_DbContext.Profesores.FirstOrDefault(p => p.ProfesorId == id);
                if (existente == null)
                {
                    return "El profesor no fue encontrado";
                }

                existente.Estado = false;
                _Profesor_DbContext.SaveChanges();

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
                return _Profesor_DbContext.Profesores.Any(p => p.Email == email);
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
                return _Profesor_DbContext.Profesores.Any(p => p.Cedula == cedula);
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
