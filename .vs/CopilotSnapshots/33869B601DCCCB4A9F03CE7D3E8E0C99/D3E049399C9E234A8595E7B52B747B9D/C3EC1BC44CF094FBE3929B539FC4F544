using Gestion_Cursos.Controllers;
using Gestion_Cursos.Models;
using Gestion_Cursos.Data;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gestion_Cursos.Views.Usuarios
{
    public partial class frm_editar_Usuario : Form
    {
        private readonly Usuario_Controller _usuarioController = new Usuario_Controller();
        private int _id;
        private string _originalEmail = string.Empty;

        public frm_editar_Usuario(int id)
        {
            InitializeComponent();
            _id = id;
            CargarRoles();
            CargarUsuario();
        }

        private void CargarRoles()
        {
            cmb_Rol.Items.Clear();
            try
            {
                var roles = _usuarioController.todos()
                    .Select(u => u.Credenciale?.Rol)
                    .Where(r => !string.IsNullOrWhiteSpace(r))
                    .Distinct()
                    .ToList();

                if (roles != null && roles.Count > 0)
                {
                    foreach (var r in roles)
                        cmb_Rol.Items.Add(r);
                }
                else
                {
                    cmb_Rol.Items.Add("Secretaria");
                    cmb_Rol.Items.Add("Admin");
                }
            }
            catch (Exception)
            {
                cmb_Rol.Items.Add("Secretaria");
                cmb_Rol.Items.Add("Admin");
            }

            // No seleccionar por defecto; CargarUsuario establecerá la selección si corresponde
            if (cmb_Rol.Items.Count > 0) cmb_Rol.SelectedIndex = -1;
        }

        public void CargarUsuario()
        {
            var usuario = _usuarioController.uno(_id);
            if (usuario == null)
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txt_Nombres.Text = usuario.Nombre;
            txt_Apellidos.Text = usuario.Apellido;
            txt_Correo.Text = usuario.Credenciale?.Correo ?? string.Empty;
            txt_Contrasenia.Text = usuario.Credenciale?.Contrasenia ?? string.Empty;
            var rol = usuario.Credenciale?.Rol;
            if (!string.IsNullOrWhiteSpace(rol) && cmb_Rol.Items.Contains(rol))
                cmb_Rol.SelectedItem = rol;

            // almacenar email original para validación de duplicados
            _originalEmail = usuario.Credenciale?.Correo ?? string.Empty;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombres.Text) || string.IsNullOrWhiteSpace(txt_Apellidos.Text))
            {
                MessageBox.Show("Debe completar nombres y apellidos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Correo.Text) || !Regex.IsMatch(txt_Correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo válido", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Correo.Focus();
                return;
            }

            // Construir objeto Usuario para actualizar
            var usuario = new Usuario
            {
                UsuarioId = _id,
                Nombre = txt_Nombres.Text.Trim(),
                Apellido = txt_Apellidos.Text.Trim(),
                Estado = true
            };

            usuario.Credenciale = new Credenciale
            {
                Correo = txt_Correo.Text.Trim(),
                Contrasenia = txt_Contrasenia.Text.Trim(),
                Rol = cmb_Rol.SelectedItem?.ToString() ?? "Secretaria"
            };

            var res = _usuarioController.actualizar(usuario);
            if (res == "ok")
            {
                MessageBox.Show("Usuario actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Recargar datos desde BD
            CargarUsuario();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            // Validar formato
            if (!Regex.IsMatch(txt_Correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                txt_Correo.Text = string.Empty;
                txt_Correo.Focus();
                MessageBox.Show("El correo no tiene un formato válido", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar existencia en BD (evitar marcar el mismo correo del usuario actual como duplicado)
            var email = txt_Correo.Text.Trim();
            try
            {
                var exists = _usuarioController.EmailExists(email);
                if (exists && !string.Equals(_originalEmail, email, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El correo ya se encuentra registrado", "Correo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Correo.Text = string.Empty;
                    txt_Correo.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo verificar el correo en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
