namespace Gestion_Cursos.Views.Cursos
{
    partial class frm_agregar_Curso
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
            cmb_Horario = new ComboBox();
            label6 = new Label();
            btn_Salir = new Button();
            btn_Cancelar = new Button();
            btn_Guardar = new Button();
            label3 = new Label();
            txt_Apellidos = new TextBox();
            label2 = new Label();
            txt_Nombres = new TextBox();
            label1 = new Label();
            cmb_Profesor = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // cmb_Horario
            // 
            cmb_Horario.FormattingEnabled = true;
            cmb_Horario.Location = new Point(164, 307);
            cmb_Horario.Name = "cmb_Horario";
            cmb_Horario.Size = new Size(260, 39);
            cmb_Horario.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(3, 4, 94);
            label6.Location = new Point(173, 261);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 181;
            label6.Text = "Horario:";
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(0, 119, 182);
            btn_Salir.ForeColor = Color.White;
            btn_Salir.Location = new Point(14, 359);
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
            btn_Cancelar.Location = new Point(14, 282);
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
            btn_Guardar.Location = new Point(14, 207);
            btn_Guardar.Margin = new Padding(5);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(124, 49);
            btn_Guardar.TabIndex = 6;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(3, 4, 94);
            label3.Location = new Point(173, 159);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 176;
            label3.Text = "Descripción:";
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(167, 207);
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
            label2.Location = new Point(173, 51);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 175;
            label2.Text = "Nombre:";
            // 
            // txt_Nombres
            // 
            txt_Nombres.Location = new Point(167, 99);
            txt_Nombres.Margin = new Padding(5);
            txt_Nombres.MaxLength = 50;
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(257, 39);
            txt_Nombres.TabIndex = 1;
            txt_Nombres.Leave += txt_Nombres_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(110, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 174;
            label1.Text = "AGREGAR CURSO";
            // 
            // cmb_Profesor
            // 
            cmb_Profesor.FormattingEnabled = true;
            cmb_Profesor.Location = new Point(164, 407);
            cmb_Profesor.Name = "cmb_Profesor";
            cmb_Profesor.Size = new Size(260, 39);
            cmb_Profesor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(3, 4, 94);
            label4.Location = new Point(173, 361);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 183;
            label4.Text = "Profesor:";
            // 
            // frm_agregar_Curso
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 240, 248);
            ClientSize = new Size(440, 471);
            Controls.Add(cmb_Profesor);
            Controls.Add(label4);
            Controls.Add(cmb_Horario);
            Controls.Add(label6);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(label3);
            Controls.Add(txt_Apellidos);
            Controls.Add(label2);
            Controls.Add(txt_Nombres);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frm_agregar_Curso";
            ShowIcon = false;
            Text = "Agregar Curso";
            Load += frm_agregar_Curso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmb_Horario;
        private Label label6;
        private Button btn_Salir;
        private Button btn_Cancelar;
        private Button btn_Guardar;
        private Label label3;
        private TextBox txt_Apellidos;
        private Label label2;
        private TextBox txt_Nombres;
        private Label label1;
        private ComboBox cmb_Profesor;
        private Label label4;
    }
}