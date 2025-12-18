namespace Gestion_Cursos.Views.Usuarios
{
    partial class frm_agregar_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Contrasenia = new TextBox();
            label8 = new Label();
            btn_Salir = new Button();
            btn_Cancelar = new Button();
            btn_Guardar = new Button();
            label5 = new Label();
            txt_Correo = new TextBox();
            label3 = new Label();
            txt_Apellidos = new TextBox();
            label2 = new Label();
            txt_Nombres = new TextBox();
            label1 = new Label();
            cmb_Rol = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txt_Contrasenia
            // 
            txt_Contrasenia.Location = new Point(167, 409);
            txt_Contrasenia.Margin = new Padding(5);
            txt_Contrasenia.MaxLength = 50;
            txt_Contrasenia.Name = "txt_Contrasenia";
            txt_Contrasenia.PasswordChar = '*';
            txt_Contrasenia.Size = new Size(257, 39);
            txt_Contrasenia.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(3, 4, 94);
            label8.Location = new Point(167, 372);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(139, 32);
            label8.TabIndex = 89;
            label8.Text = "Contraseña:";
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(0, 119, 182);
            btn_Salir.ForeColor = Color.White;
            btn_Salir.Location = new Point(14, 365);
            btn_Salir.Margin = new Padding(5);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(124, 49);
            btn_Salir.TabIndex = 8;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(0, 180, 216);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(14, 288);
            btn_Cancelar.Margin = new Padding(5);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(124, 49);
            btn_Cancelar.TabIndex = 7;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(0, 119, 182);
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.Location = new Point(14, 213);
            btn_Guardar.Margin = new Padding(5);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(124, 49);
            btn_Guardar.TabIndex = 6;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(3, 4, 94);
            label5.Location = new Point(173, 268);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 32);
            label5.TabIndex = 86;
            label5.Text = "Correo:";
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(167, 316);
            txt_Correo.Margin = new Padding(5);
            txt_Correo.MaxLength = 50;
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(257, 39);
            txt_Correo.TabIndex = 3;
            txt_Correo.Leave += txt_Correo_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(3, 4, 94);
            label3.Location = new Point(173, 165);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 84;
            label3.Text = "Apellidos:";
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(167, 213);
            txt_Apellidos.Margin = new Padding(5);
            txt_Apellidos.MaxLength = 50;
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(257, 39);
            txt_Apellidos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(3, 4, 94);
            label2.Location = new Point(173, 57);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 83;
            label2.Text = "Nombres:";
            // 
            // txt_Nombres
            // 
            txt_Nombres.Location = new Point(167, 105);
            txt_Nombres.Margin = new Padding(5);
            txt_Nombres.MaxLength = 50;
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(257, 39);
            txt_Nombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(115, 8);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 82;
            label1.Text = "AGREGAR USUARIO";
            // 
            // cmb_Rol
            // 
            cmb_Rol.FormattingEnabled = true;
            cmb_Rol.Location = new Point(164, 507);
            cmb_Rol.Name = "cmb_Rol";
            cmb_Rol.Size = new Size(260, 39);
            cmb_Rol.TabIndex = 5;
            cmb_Rol.SelectedIndexChanged += cmb_Tipo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(3, 4, 94);
            label4.Location = new Point(167, 460);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 32);
            label4.TabIndex = 91;
            label4.Text = "Rol:";
            // 
            // frm_agregar_Usuario
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 240, 248);
            ClientSize = new Size(441, 568);
            Controls.Add(label4);
            Controls.Add(cmb_Rol);
            Controls.Add(txt_Contrasenia);
            Controls.Add(label8);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(label5);
            Controls.Add(txt_Correo);
            Controls.Add(label3);
            Controls.Add(txt_Apellidos);
            Controls.Add(label2);
            Controls.Add(txt_Nombres);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frm_agregar_Usuario";
            ShowIcon = false;
            Text = "Agregar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Contrasenia;
        private Label label8;
        private Button btn_Salir;
        private Button btn_Cancelar;
        private Button btn_Guardar;
        private Label label5;
        private TextBox txt_Correo;
        private Label label3;
        private TextBox txt_Apellidos;
        private Label label2;
        private TextBox txt_Nombres;
        private Label label1;
        private ComboBox cmb_Rol;
        private Label label4;
    }
}