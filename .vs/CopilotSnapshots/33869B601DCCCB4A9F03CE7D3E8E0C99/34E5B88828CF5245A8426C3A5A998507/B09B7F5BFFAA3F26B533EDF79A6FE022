using Gestion_Cursos.Controllers;
using Gestion_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cursos.Views.Profesores
{
    public partial class frm_listar_Profesores : Form
    {
        private readonly Profesor_Controller _profesorController = new Profesor_Controller();
        private List<Profesore> _profesores = new List<Profesore>();

        public frm_listar_Profesores()
        {
            InitializeComponent();
        }

        private void frm_listar_Profesores_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            _profesores = _profesorController.todos();

            var lista = new List<object>();
            // Encabezado
            lista.Add(new { ProfesorId = -1, Fila = "Nombre Completo | Cédula | Especialidad | Fecha Registro" });

            foreach (var p in _profesores)
            {
                var nombreCompleto = string.Concat(p.Nombre, " ", p.Apellido).Trim();
                var cedula = p.Cedula ?? "-";
                var especialidad = string.IsNullOrWhiteSpace(p.Especialidad) ? "-" : p.Especialidad;
                var fecha = p.FechaRegistro.HasValue ? p.FechaRegistro.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) : "-";
                var fila = $"{nombreCompleto} | {cedula} | {especialidad} | {fecha}";
                lista.Add(new { ProfesorId = p.ProfesorId, Fila = fila });
            }

            lst_lista_profesores.DataSource = lista;
            lst_lista_profesores.ValueMember = "ProfesorId";
            lst_lista_profesores.DisplayMember = "Fila";
            lst_lista_profesores.ClearSelected();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var frm = new frm_agregar_Profesor();
            var res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                CargarLista();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lst_lista_profesores.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un profesor de la lista para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            try
            {
                id = (int)lst_lista_profesores.SelectedValue;
            }
            catch
            {
                MessageBox.Show("Seleccione un profesor válido para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id == -1)
            {
                MessageBox.Show("Seleccione un profesor (no el encabezado) para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new frm_editar_Profesor(id);
            var res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                CargarLista();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_lista_profesores.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un profesor de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            try
            {
                id = (int)lst_lista_profesores.SelectedValue;
            }
            catch
            {
                MessageBox.Show("Seleccione un profesor válido para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id == -1)
            {
                MessageBox.Show("Seleccione un profesor (no el encabezado) para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var profesor = _profesores.FirstOrDefault(p => p.ProfesorId == id);
            if (profesor == null)
            {
                MessageBox.Show("Profesor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"¿Desea eliminar al profesor {profesor.Nombre} {profesor.Apellido}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var res = _profesorController.eliminar(id);
            if (res == "ok")
            {
                MessageBox.Show("Profesor eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLista();
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
