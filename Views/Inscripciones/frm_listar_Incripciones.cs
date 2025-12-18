using Gestion_Cursos.Controllers;
using Gestion_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cursos.Views.Inscripciones
{
    public partial class frm_listar_incripciones : Form
    {
        private readonly Inscripcion_Controller _inscripcionController = new Inscripcion_Controller();
        private List<Inscripcione> _inscripciones = new List<Inscripcione>();

        public frm_listar_incripciones()
        {
            InitializeComponent();
            CargarLista();
        }

        private void CargarLista()
        {
            _inscripciones = _inscripcionController.todos();

            var lista = new List<object>();
            lista.Add(new { InscripcionId = -1, Fila = "Nombre Curso | Nombre Estudiante | Cédula | Fecha Inscripción" });

            foreach (var i in _inscripciones)
            {
                var nombreCurso = i.Curso?.NombreCurso ?? "-";
                var nombreEstudiante = string.Concat(i.Estudiante?.Nombre, " ", i.Estudiante?.Apellido).Trim();
                if (string.IsNullOrWhiteSpace(nombreEstudiante)) nombreEstudiante = "-";
                var cedula = i.Estudiante?.Cedula ?? "-";
                var fecha = i.FechaInscripcion.HasValue ? i.FechaInscripcion.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) : "-";
                var fila = $"{nombreCurso} | {nombreEstudiante} | {cedula} | {fecha}";
                lista.Add(new { InscripcionId = i.InscripcionId, Fila = fila });
            }

            lst_lista_inscripciones.DataSource = lista;
            lst_lista_inscripciones.ValueMember = "InscripcionId";
            lst_lista_inscripciones.DisplayMember = "Fila";
            lst_lista_inscripciones.ClearSelected();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var frm = new frm_agregar_Incripcion();
            var res = frm.ShowDialog();
            if (res == DialogResult.OK) CargarLista();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lst_lista_inscripciones.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una inscripción de la lista para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            try { id = (int)lst_lista_inscripciones.SelectedValue; }
            catch { MessageBox.Show("Seleccione una inscripción válida para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (id == -1) { MessageBox.Show("Seleccione una inscripción (no el encabezado) para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var frm = new frm_editar_Incripcion(id);
            var res = frm.ShowDialog();
            if (res == DialogResult.OK) CargarLista();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_lista_inscripciones.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una inscripción de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            try { id = (int)lst_lista_inscripciones.SelectedValue; }
            catch { MessageBox.Show("Seleccione una inscripción válida para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (id == -1) { MessageBox.Show("Seleccione una inscripción (no el encabezado) para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var ins = _inscripciones.FirstOrDefault(x => x.InscripcionId == id);
            if (ins == null) { MessageBox.Show("Inscripción no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            var confirm = MessageBox.Show($"¿Desea eliminar la inscripción de {ins.Estudiante?.Nombre} {ins.Estudiante?.Apellido} en {ins.Curso?.NombreCurso}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var res = _inscripcionController.eliminar(id);
            if (res == "ok") { MessageBox.Show("Inscripción eliminada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); CargarLista(); }
            else { MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
