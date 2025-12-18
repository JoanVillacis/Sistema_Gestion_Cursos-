using Gestion_Cursos.Controllers;
using Gestion_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cursos.Views.Usuarios
{
    public partial class frm_listar_Usuarios : Form
    {
        private readonly Usuario_Controller _usuarioController = new Usuario_Controller();
        private List<Usuario> _usuarios = new List<Usuario>();

        public frm_listar_Usuarios()
        {
            InitializeComponent();
        }

        private void frm_listar_Usuarios_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            _usuarios = _usuarioController.todos();

            var lista = new List<object>();

            // primer elemento: encabezado visible en la lista
            lista.Add(new { UsuarioId = -1, Fila = "Nombre Completo | Rol | Fecha Registro" });

            foreach (var u in _usuarios)
            {
                var rol = u.Credenciale?.Rol ?? "-";
                var fecha = u.FechaRegistro.HasValue ? u.FechaRegistro.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) : "-";
                var nombreCompleto = string.Concat(u.Nombre, " ", u.Apellido).Trim();
                var fila = $"{nombreCompleto} | {rol} | {fecha}";
                lista.Add(new { UsuarioId = u.UsuarioId, Fila = fila });
            }

            lst_lista_usuarios.DataSource = lista;
            lst_lista_usuarios.ValueMember = "UsuarioId";
            lst_lista_usuarios.DisplayMember = "Fila";
            lst_lista_usuarios.ClearSelected();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var frm = new frm_agregar_Usuario();
            var res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                CargarLista();
            }
        }

        private void lst_lista_usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No se usa
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lst_lista_usuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            try
            {
                id = (int)lst_lista_usuarios.SelectedValue;
            }
            catch
            {
                MessageBox.Show("Seleccione un usuario válido para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id == -1)
            {
                MessageBox.Show("Seleccione un usuario (no el encabezado) para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new frm_editar_Usuario(id);
            var res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                CargarLista();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_lista_usuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            try
            {
                id = (int)lst_lista_usuarios.SelectedValue;
            }
            catch
            {
                MessageBox.Show("Seleccione un usuario válido para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id == -1)
            {
                MessageBox.Show("Seleccione un usuario (no el encabezado) para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = _usuarios.FirstOrDefault(u => u.UsuarioId == id);
            if (usuario == null)
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"¿Desea eliminar al usuario {usuario.Nombre} {usuario.Apellido}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var res = _usuarioController.eliminar(id);
            if (res == "ok")
            {
                MessageBox.Show("Usuario eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
