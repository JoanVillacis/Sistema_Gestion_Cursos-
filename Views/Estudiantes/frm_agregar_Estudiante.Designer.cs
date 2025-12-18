namespace Gestion_Cursos.Views.Estudiantes
{
    partial class frm_agregar_Estudiante
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
            label11 = new Label();
            txt_Telefono = new TextBox();
            label10 = new Label();
            cmb_Genero = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txt_Direccion = new TextBox();
            label9 = new Label();
            txt_Ciudad = new TextBox();
            txt_Cedula = new TextBox();
            label4 = new Label();
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
            dtp_Fecha_Nacimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(3, 4, 94);
            label11.Location = new Point(168, 373);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(112, 32);
            label11.TabIndex = 183;
            label11.Text = "Teléfono:";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(164, 421);
            txt_Telefono.Margin = new Padding(5);
            txt_Telefono.MaxLength = 50;
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(257, 39);
            txt_Telefono.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(3, 4, 94);
            label10.Location = new Point(162, 896);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(245, 32);
            label10.TabIndex = 182;
            label10.Text = "Fecha de Nacimiento:";
            // 
            // cmb_Genero
            // 
            cmb_Genero.FormattingEnabled = true;
            cmb_Genero.Location = new Point(158, 840);
            cmb_Genero.Name = "cmb_Genero";
            cmb_Genero.Size = new Size(260, 39);
            cmb_Genero.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(3, 4, 94);
            label6.Location = new Point(167, 794);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 32);
            label6.TabIndex = 181;
            label6.Text = "Género:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(3, 4, 94);
            label7.Location = new Point(167, 691);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 32);
            label7.TabIndex = 180;
            label7.Text = "Dirección:";
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(161, 739);
            txt_Direccion.Margin = new Padding(5);
            txt_Direccion.MaxLength = 50;
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(257, 39);
            txt_Direccion.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(3, 4, 94);
            label9.Location = new Point(167, 583);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 32);
            label9.TabIndex = 179;
            label9.Text = "Ciudad:";
            // 
            // txt_Ciudad
            // 
            txt_Ciudad.Location = new Point(161, 631);
            txt_Ciudad.Margin = new Padding(5);
            txt_Ciudad.MaxLength = 50;
            txt_Ciudad.Name = "txt_Ciudad";
            txt_Ciudad.Size = new Size(257, 39);
            txt_Ciudad.TabIndex = 6;
            // 
            // txt_Cedula
            // 
            txt_Cedula.Location = new Point(164, 524);
            txt_Cedula.Margin = new Padding(5);
            txt_Cedula.MaxLength = 50;
            txt_Cedula.Name = "txt_Cedula";
            txt_Cedula.Size = new Size(257, 39);
            txt_Cedula.TabIndex = 5;
            txt_Cedula.Leave += txt_Cedula_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(3, 4, 94);
            label4.Location = new Point(164, 477);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 178;
            label4.Text = "Cedula:";
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(0, 119, 182);
            btn_Salir.ForeColor = Color.White;
            btn_Salir.Location = new Point(11, 365);
            btn_Salir.Margin = new Padding(5);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(124, 49);
            btn_Salir.TabIndex = 12;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(0, 180, 216);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(11, 288);
            btn_Cancelar.Margin = new Padding(5);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(124, 49);
            btn_Cancelar.TabIndex = 11;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(0, 119, 182);
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.Location = new Point(11, 213);
            btn_Guardar.Margin = new Padding(5);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(124, 49);
            btn_Guardar.TabIndex = 10;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(3, 4, 94);
            label5.Location = new Point(170, 268);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 32);
            label5.TabIndex = 177;
            label5.Text = "Correo:";
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(164, 316);
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
            label3.Location = new Point(170, 165);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 176;
            label3.Text = "Apellidos:";
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(164, 213);
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
            label2.Location = new Point(170, 57);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 175;
            label2.Text = "Nombres:";
            // 
            // txt_Nombres
            // 
            txt_Nombres.Location = new Point(164, 105);
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
            label1.Location = new Point(89, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 32);
            label1.TabIndex = 174;
            label1.Text = "AGREGAR ESTUDIANTE";
            // 
            // dtp_Fecha_Nacimiento
            // 
            dtp_Fecha_Nacimiento.Location = new Point(158, 945);
            dtp_Fecha_Nacimiento.Name = "dtp_Fecha_Nacimiento";
            dtp_Fecha_Nacimiento.Size = new Size(257, 39);
            dtp_Fecha_Nacimiento.TabIndex = 9;
            // 
            // frm_agregar_Estudiante
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 240, 248);
            ClientSize = new Size(435, 1002);
            Controls.Add(dtp_Fecha_Nacimiento);
            Controls.Add(label11);
            Controls.Add(txt_Telefono);
            Controls.Add(label10);
            Controls.Add(cmb_Genero);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txt_Direccion);
            Controls.Add(label9);
            Controls.Add(txt_Ciudad);
            Controls.Add(txt_Cedula);
            Controls.Add(label4);
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
            Name = "frm_agregar_Estudiante";
            ShowIcon = false;
            Text = "Agregar Estudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private TextBox txt_Telefono;
        private Label label10;
        private ComboBox cmb_Genero;
        private Label label6;
        private Label label7;
        private TextBox txt_Direccion;
        private Label label9;
        private TextBox txt_Ciudad;
        private TextBox txt_Cedula;
        private Label label4;
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
        private DateTimePicker dtp_Fecha_Nacimiento;
    }
}