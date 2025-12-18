using Gestion_Cursos.Controllers;
using Gestion_Cursos.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion_Cursos.Views.Estudiantes
{
    public partial class frm_editar_Estudiante : Form
    {
        private readonly Estudiante_Controller _estudianteController = new Estudiante_Controller();
        private readonly Auth_Controller _authController = new Auth_Controller();
        private int _id;
        private string _originalEmail = string.Empty;
        private string _originalCedula = string.Empty;

        public frm_editar_Estudiante(int id)
        {
            InitializeComponent();
            _id = id;
            CargarGeneros();
            CargarEstudiante();
        }

        private void CargarGeneros()
        {
            cmb_Genero.Items.Clear();
            cmb_Genero.Items.Add("Masculino");
            cmb_Genero.Items.Add("Femenino");
            cmb_Genero.Items.Add("Otro");
            if (cmb_Genero.Items.Count > 0) cmb_Genero.SelectedIndex = -1;
        }

        public void CargarEstudiante()
        {
            var estudiante = _estudianteController.uno(_id);
            if (estudiante == null)
            {
                MessageBox.Show("Estudiante no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txt_Nombres.Text = estudiante.Nombre;
            txt_Apellidos.Text = estudiante.Apellido;
            txt_Cedula.Text = estudiante.Cedula;
            txt_Correo.Text = estudiante.Email;
            if (estudiante.FechaNacimiento.HasValue)
                dtp_Fecha_Nacimiento.Value = estudiante.FechaNacimiento.Value.ToDateTime(new TimeOnly(0));
            else
                dtp_Fecha_Nacimiento.Value = DateTime.Now;
            cmb_Genero.SelectedItem = estudiante.Genero;
            txt_Ciudad.Text = estudiante.Ciudad;
            txt_Direccion.Text = estudiante.Direccion;
            txt_Telefono.Text = estudiante.Telefono;

            _originalEmail = estudiante.Email ?? string.Empty;
            _originalCedula = estudiante.Cedula ?? string.Empty;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombres.Text) || string.IsNullOrWhiteSpace(txt_Apellidos.Text))
            {
                MessageBox.Show("Debe completar nombres y apellidos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var estudiante = new Estudiante
            {
                EstudianteId = _id,
                Cedula = txt_Cedula.Text.Trim(),
                Nombre = txt_Nombres.Text.Trim(),
                Apellido = txt_Apellidos.Text.Trim(),
                FechaNacimiento = DateOnly.FromDateTime(dtp_Fecha_Nacimiento.Value.Date),
                Genero = cmb_Genero.SelectedItem?.ToString(),
                Ciudad = txt_Ciudad.Text.Trim(),
                Direccion = txt_Direccion.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(txt_Correo.Text) ? null : txt_Correo.Text.Trim(),
                Telefono = txt_Telefono.Text.Trim(),
                Estado = true
            };

            var res = _estudianteController.actualizar(estudiante);
            if (res == "ok")
            {
                MessageBox.Show("Estudiante actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            CargarEstudiante();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Correo.Text)) return;
            if (!Regex.IsMatch(txt_Correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo no tiene un formato válido", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Correo.Text = string.Empty;
                txt_Correo.Focus();
                return;
            }
            var email = txt_Correo.Text.Trim();
            if (!string.Equals(_originalEmail, email, StringComparison.OrdinalIgnoreCase) && _estudianteController.EmailExists(email))
            {
                MessageBox.Show("El correo ya se encuentra registrado", "Correo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Correo.Text = string.Empty;
                txt_Correo.Focus();
            }
        }

        private void txt_Cedula_Leave(object sender, EventArgs e)
        {
            var ced = txt_Cedula.Text.Trim();
            if (string.IsNullOrWhiteSpace(ced)) return;
            if (ced.Length != 10 || !long.TryParse(ced, out _))
            {
                MessageBox.Show("La cédula debe tener10 dígitos", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cedula.Focus();
                return;
            }
            if (!_authController.VerificaCedula(ced.ToCharArray()))
            {
                MessageBox.Show("Cédula inválida según algoritmo", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cedula.Focus();
                return;
            }
            if (!string.Equals(_originalCedula, ced, StringComparison.OrdinalIgnoreCase) && _estudianteController.CedulaExists(ced))
            {
                MessageBox.Show("La cédula ya se encuentra registrada", "Cédula duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cedula.Text = string.Empty;
                txt_Cedula.Focus();
            }
        }
    }
}
