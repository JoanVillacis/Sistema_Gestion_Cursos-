using Gestion_Cursos.Controllers;
using Gestion_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cursos.Views.Cursos
{
    public partial class frm_listar_Cursos : Form
    {
        private readonly Curso_Controller _cursoController = new Curso_Controller();
        private List<Curso> _cursos = new List<Curso>();

        public frm_listar_Cursos()
        {
            InitializeComponent();
        }

        private void frm_listar_Cursos_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            _cursos = _cursoController.todos();
            var lista = new List<object>();
            lista.Add(new { CursoId = -1, Fila = "Nombre Curso | Descripción | Horario | Profesor" });
            foreach (var c in _cursos)
            {
                var profesor = c.Profesor != null ? string.Concat(c.Profesor.Nombre, " ", c.Profesor.Apellido).Trim() : "-";
                var fila = $"{c.NombreCurso} | {c.Descripcion} | {c.Horario} | {profesor}";
                lista.Add(new { CursoId = c.CursoId, Fila = fila });
            }
            lst_lista_cursos.DataSource = lista;
            lst_lista_cursos.ValueMember = "CursoId";
            lst_lista_cursos.DisplayMember = "Fila";
            lst_lista_cursos.ClearSelected();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var frm = new frm_agregar_Curso();
            var res = frm.ShowDialog();
            if (res == DialogResult.OK) CargarLista();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lst_lista_cursos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso de la lista para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            try { id = (int)lst_lista_cursos.SelectedValue; }
            catch { MessageBox.Show("Seleccione un curso válido para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (id == -1) { MessageBox.Show("Seleccione un curso (no el encabezado) para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var frm = new frm_editar_Curso(id);
            var res = frm.ShowDialog();
            if (res == DialogResult.OK) CargarLista();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_lista_cursos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            try { id = (int)lst_lista_cursos.SelectedValue; }
            catch { MessageBox.Show("Seleccione un curso válido para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (id == -1) { MessageBox.Show("Seleccione un curso (no el encabezado) para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var curso = _cursos.FirstOrDefault(c => c.CursoId == id);
            if (curso == null) { MessageBox.Show("Curso no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            var confirm = MessageBox.Show($"¿Desea eliminar el curso {curso.NombreCurso}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            var res = _cursoController.eliminar(id);
            if (res == "ok") { MessageBox.Show("Curso eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); CargarLista(); }
            else { MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
