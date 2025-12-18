using Gestion_Cursos.Controllers;
using Gestion_Cursos.Models;
using Sistema_Gestion_Cursos.Views.Principal;
using System.Text.RegularExpressions;

namespace Gestion_Cursos
{
    public partial class frm_login : Form
    {
        private readonly Auth_Controller _login_Controller = new Auth_Controller();
        int _contador = 3;
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Validar campos antes de llamar al controlador
            if (string.IsNullOrWhiteSpace(txt_Correo.Text) || string.IsNullOrWhiteSpace(txt_Pwd.Text))
            {
                MessageBox.Show("Debe ingresar correo y contraseña", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Credenciale cred = new Credenciale()
            {
                Correo = txt_Correo.Text.Trim(),
                Contrasenia = txt_Pwd.Text.Trim()
            };

            Credenciale resultado = _login_Controller.login(cred);

            if (resultado != null)
            {
                MessageBox.Show("Login exitoso");
                var dash = new frm_dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                _contador--;
                if (_contador == 0)
                {
                    MessageBox.Show("Usted a sobre pasado el numero de intentos");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Credenciales incorrectas, le quedan {_contador} intentos");
                }
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Correo.Text = string.Empty;
            txt_Pwd.Text = string.Empty;
        }

        private void txt_Pwd_Leave(object sender, EventArgs e)
        {
            bool ok = Regex.IsMatch(txt_Correo.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
            if (!ok)
            {
                txt_Correo.Text = "";
                txt_Correo.Focus();
                MessageBox.Show("El correo no tiene un formato válido");
            }
        }
    }
}
