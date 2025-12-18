using Gestion_Cursos.Controllers;
using Gestion_Cursos.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion_Cursos.Views.Estudiantes
{
    public partial class frm_agregar_Estudiante : Form
    {
        private readonly Estudiante_Controller _estudianteController = new Estudiante_Controller();
        private readonly Auth_Controller _authController = new Auth_Controller();

        public frm_agregar_Estudiante()
        {
            InitializeComponent();
            CargarGeneros();
        }

        private void CargarGeneros()
        {
            cmb_Genero.Items.Clear();
            cmb_Genero.Items.Add("Masculino");
            cmb_Genero.Items.Add("Femenino");
            cmb_Genero.Items.Add("Otro");
            if (cmb_Genero.Items.Count > 0) cmb_Genero.SelectedIndex = -1;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombres.Text) || string.IsNullOrWhiteSpace(txt_Apellidos.Text))
            {
                MessageBox.Show("Debe completar nombres y apellidos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Cedula.Text))
            {
                MessageBox.Show("Debe ingresar la cédula", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cedula.Focus();
                return;
            }

            var ced = txt_Cedula.Text.Trim();
            if (ced.Length != 10 || !long.TryParse(ced, out _))
            {
                MessageBox.Show("La cédula debe tener 10 dígitos", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cedula.Focus();
                return;
            }
            if (!_authController.VerificaCedula(ced.ToCharArray()))
            {
                MessageBox.Show("Cédula inválida según algoritmo", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cedula.Focus();
                return;
            }
            if (_estudianteController.CedulaExists(ced))
            {
                MessageBox.Show("La cédula ya se encuentra registrada", "Cédula duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cedula.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txt_Correo.Text))
            {
                if (!Regex.IsMatch(txt_Correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("El correo no tiene un formato válido", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Correo.Focus();
                    return;
                }
                if (_estudianteController.EmailExists(txt_Correo.Text.Trim()))
                {
                    MessageBox.Show("El correo ya se encuentra registrado", "Correo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Correo.Focus();
                    return;
                }
            }

            var estudiante = new Estudiante
            {
                Cedula = ced,
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

            var res = _estudianteController.insertar(estudiante);
            if (res == "ok")
            {
                MessageBox.Show("Estudiante guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txt_Cedula.Text = string.Empty;
            txt_Correo.Text = string.Empty;
            if (cmb_Genero.Items.Count > 0) cmb_Genero.SelectedIndex = -1;
            txt_Ciudad.Text = string.Empty;
            txt_Direccion.Text = string.Empty;
            txt_Telefono.Text = string.Empty;
            dtp_Fecha_Nacimiento.Value = DateTime.Now;
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
            if (_estudianteController.EmailExists(txt_Correo.Text.Trim()))
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
                MessageBox.Show("La cédula debe tener 10 dígitos", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cedula.Focus();
                return;
            }
            if (!_authController.VerificaCedula(ced.ToCharArray()))
            {
                MessageBox.Show("Cédula inválida según algoritmo", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cedula.Focus();
                return;
            }
            if (_estudianteController.CedulaExists(ced))
            {
                MessageBox.Show("La cédula ya se encuentra registrada", "Cédula duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cedula.Text = string.Empty;
                txt_Cedula.Focus();
            }
        }
    }
}
