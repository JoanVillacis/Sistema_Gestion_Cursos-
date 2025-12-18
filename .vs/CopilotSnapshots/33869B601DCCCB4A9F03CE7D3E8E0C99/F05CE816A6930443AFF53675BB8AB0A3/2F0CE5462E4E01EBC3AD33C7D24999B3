using Gestion_Cursos.Controllers;
using Gestion_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cursos.Views.Inscripciones
{
    public partial class frm_editar_Incripcion : Form
    {
        private readonly Inscripcion_Controller _inscripcionController = new Inscripcion_Controller();
        private readonly Estudiante_Controller _estudianteController = new Estudiante_Controller();
        private readonly Curso_Controller _cursoController = new Curso_Controller();
        private List<Estudiante> _estudiantes = new List<Estudiante>();
        private List<Curso> _cursos = new List<Curso>();
        private int _id;

        public frm_editar_Incripcion(int id)
        {
            InitializeComponent();
            _id = id;
            CargarListas();
            lst_lista_cursos.SelectedIndexChanged += Lst_lista_cursos_SelectedIndexChanged;
            lst_lista_estudiantes.SelectedIndexChanged += Lst_lista_estudiantes_SelectedIndexChanged;
            CargarInscripcion();
        }

        private void CargarListas()
        {
            _cursos = _cursoController.todos();
            var listaCursos = new List<object>();
            listaCursos.Add(new { CursoId = -1, Fila = "Nombre Curso | Horario | Profesor" });
            foreach (var c in _cursos)
            {
                var profesor = c.Profesor != null ? string.Concat(c.Profesor.Nombre, " ", c.Profesor.Apellido).Trim() : "-";
                var fila = $"{c.NombreCurso} | {c.Horario} | {profesor}";
                listaCursos.Add(new { CursoId = c.CursoId, Fila = fila });
            }
            lst_lista_cursos.DataSource = listaCursos;
            lst_lista_cursos.ValueMember = "CursoId";
            lst_lista_cursos.DisplayMember = "Fila";
            lst_lista_cursos.ClearSelected();

            _estudiantes = _estudianteController.todos();
            var listaEst = new List<object>();
            listaEst.Add(new { EstudianteId = -1, Fila = "Nombre Completo | Cédula | Email" });
            foreach (var s in _estudiantes)
            {
                var nombre = string.Concat(s.Nombre, " ", s.Apellido).Trim();
                var fila = $"{nombre} | {s.Cedula} | {s.Email}";
                listaEst.Add(new { EstudianteId = s.EstudianteId, Fila = fila });
            }
            lst_lista_estudiantes.DataSource = listaEst;
            lst_lista_estudiantes.ValueMember = "EstudianteId";
            lst_lista_estudiantes.DisplayMember = "Fila";
            lst_lista_estudiantes.ClearSelected();
        }

        private void CargarInscripcion()
        {
            var ins = _inscripcionController.uno(_id);
            if (ins == null)
            {
                MessageBox.Show("Inscripción no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // seleccionar curso y estudiante en listas
            if (ins.CursoId != 0) lst_lista_cursos.SelectedValue = ins.CursoId;
            if (ins.EstudianteId != 0) lst_lista_estudiantes.SelectedValue = ins.EstudianteId;

            // poner textos
            txt_Curso.Text = ins.Curso?.NombreCurso ?? string.Empty;
            txt_Estudiante.Text = string.Concat(ins.Estudiante?.Nombre, " ", ins.Estudiante?.Apellido).Trim();
            chk_Estado.Checked = ins.Estado.HasValue ? ins.Estado.Value : true;
        }

        private void Lst_lista_estudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_lista_estudiantes.SelectedItem == null) return;
            int id;
            try { id = (int)lst_lista_estudiantes.SelectedValue; } catch { return; }
            if (id == -1) return;
            var est = _estudiantes.FirstOrDefault(x => x.EstudianteId == id);
            if (est == null) return;
            txt_Estudiante.Text = string.Concat(est.Nombre, " ", est.Apellido).Trim();
        }

        private void Lst_lista_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_lista_cursos.SelectedItem == null) return;
            int id;
            try { id = (int)lst_lista_cursos.SelectedValue; } catch { return; }
            if (id == -1) return;
            var cur = _cursos.FirstOrDefault(x => x.CursoId == id);
            if (cur == null) return;
            txt_Curso.Text = cur.NombreCurso;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (lst_lista_cursos.SelectedItem == null || lst_lista_estudiantes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso y un estudiante de las listas.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int cursoId = (int)lst_lista_cursos.SelectedValue;
            int estudianteId = (int)lst_lista_estudiantes.SelectedValue;
            if (cursoId == -1 || estudianteId == -1)
            {
                MessageBox.Show("Seleccione un curso y un estudiante válidos.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ins = new Inscripcione
            {
                InscripcionId = _id,
                CursoId = cursoId,
                EstudianteId = estudianteId,
                FechaInscripcion = DateTime.Now,
                Estado = chk_Estado.Checked
            };
            var res = _inscripcionController.actualizar(ins);
            if (res == "ok")
            {
                MessageBox.Show("Inscripción actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(res, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            CargarInscripcion();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
