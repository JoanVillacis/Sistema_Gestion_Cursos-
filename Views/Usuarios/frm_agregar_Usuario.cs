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
    public partial class frm_agregar_Usuario : Form
    {
        private readonly Usuario_Controller _usuarioController = new Usuario_Controller();

        public frm_agregar_Usuario()
        {
            InitializeComponent();
            CargarRoles();
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
            catch
            {
                cmb_Rol.Items.Add("Secretaria");
                cmb_Rol.Items.Add("Admin");
            }

            // No seleccionar por defecto para forzar elección / evitar confusión
            if (cmb_Rol.Items.Count > 0) cmb_Rol.SelectedIndex = -1;
        }

        private void cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            if (string.IsNullOrWhiteSpace(txt_Contrasenia.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña", "Contraseña vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Contrasenia.Focus();
                return;
            }

            var rolSeleccionado = cmb_Rol.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(rolSeleccionado))
            {
                MessageBox.Show("Seleccione un rol válido", "Rol inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preparar usuario y credencial
            var usuario = new Usuario
            {
                Nombre = txt_Nombres.Text.Trim(),
                Apellido = txt_Apellidos.Text.Trim(),
                // Estado por defecto true
                Estado = true
            };

            usuario.Credenciale = new Credenciale
            {
                Correo = txt_Correo.Text.Trim(),
                Contrasenia = txt_Contrasenia.Text.Trim(),
                Rol = rolSeleccionado
            };

            var res = _usuarioController.insertar(usuario);
            if (res == "ok")
            {
                MessageBox.Show("Usuario guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(res, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Nombres.Text = string.Empty;
            txt_Apellidos.Text = string.Empty;
            txt_Correo.Text = string.Empty;
            txt_Contrasenia.Text = string.Empty;
            // Dejar el combo sin selección
            if (cmb_Rol.Items.Count > 0)
            {
                cmb_Rol.SelectedIndex = -1;
                cmb_Rol.Text = string.Empty;
            }
            else
            {
                cmb_Rol.SelectedIndex = -1;
            }
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

            // Verificar existencia en BD
            var email = txt_Correo.Text.Trim();
            try
            {
                if (_usuarioController.EmailExists(email))
                {
                    MessageBox.Show("El correo ya se encuentra registrado", "Correo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Correo.Text = string.Empty;
                    txt_Correo.Focus();
                }
            }
            catch (Exception)
            {
                // No bloquear si falla la comprobación, pero avisar
                MessageBox.Show("No se pudo verificar el correo en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
