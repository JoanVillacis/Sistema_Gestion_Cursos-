namespace Gestion_Cursos.Views.Inscripciones
{
    partial class frm_editar_Incripcion
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
            chk_Estado = new CheckBox();
            label6 = new Label();
            label4 = new Label();
            lst_lista_estudiantes = new ListBox();
            lst_lista_cursos = new ListBox();
            btn_Salir = new Button();
            btn_Cancelar = new Button();
            btn_Guardar = new Button();
            label5 = new Label();
            label3 = new Label();
            txt_Estudiante = new TextBox();
            label2 = new Label();
            txt_Curso = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // chk_Estado
            // 
            chk_Estado.AutoSize = true;
            chk_Estado.Location = new Point(170, 323);
            chk_Estado.Name = "chk_Estado";
            chk_Estado.Size = new Size(18, 17);
            chk_Estado.TabIndex = 3;
            chk_Estado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(3, 4, 94);
            label6.Location = new Point(469, 59);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(206, 32);
            label6.TabIndex = 172;
            label6.Text = "Listado de Cursos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(3, 4, 94);
            label4.Location = new Point(1091, 59);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(256, 32);
            label4.TabIndex = 171;
            label4.Text = "Listado de Estudiantes:";
            // 
            // lst_lista_estudiantes
            // 
            lst_lista_estudiantes.FormattingEnabled = true;
            lst_lista_estudiantes.ItemHeight = 31;
            lst_lista_estudiantes.Location = new Point(1091, 107);
            lst_lista_estudiantes.Name = "lst_lista_estudiantes";
            lst_lista_estudiantes.Size = new Size(583, 345);
            lst_lista_estudiantes.TabIndex = 1;
            // 
            // lst_lista_cursos
            // 
            lst_lista_cursos.FormattingEnabled = true;
            lst_lista_cursos.ItemHeight = 31;
            lst_lista_cursos.Location = new Point(469, 107);
            lst_lista_cursos.Name = "lst_lista_cursos";
            lst_lista_cursos.Size = new Size(583, 345);
            lst_lista_cursos.TabIndex = 2;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(0, 119, 182);
            btn_Salir.ForeColor = Color.White;
            btn_Salir.Location = new Point(15, 317);
            btn_Salir.Margin = new Padding(5);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(124, 49);
            btn_Salir.TabIndex = 6;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(0, 180, 216);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(15, 240);
            btn_Cancelar.Margin = new Padding(5);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(124, 49);
            btn_Cancelar.TabIndex = 5;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(0, 119, 182);
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.Location = new Point(15, 165);
            btn_Guardar.Margin = new Padding(5);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(124, 49);
            btn_Guardar.TabIndex = 4;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(3, 4, 94);
            label5.Location = new Point(174, 268);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 170;
            label5.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(3, 4, 94);
            label3.Location = new Point(174, 165);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 169;
            label3.Text = "Estudiante:";
            // 
            // txt_Estudiante
            // 
            txt_Estudiante.Location = new Point(168, 213);
            txt_Estudiante.Margin = new Padding(5);
            txt_Estudiante.MaxLength = 50;
            txt_Estudiante.Name = "txt_Estudiante";
            txt_Estudiante.ReadOnly = true;
            txt_Estudiante.Size = new Size(257, 39);
            txt_Estudiante.TabIndex = 166;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(3, 4, 94);
            label2.Location = new Point(174, 59);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 168;
            label2.Text = "Curso:";
            // 
            // txt_Curso
            // 
            txt_Curso.Location = new Point(168, 107);
            txt_Curso.Margin = new Padding(5);
            txt_Curso.MaxLength = 50;
            txt_Curso.Name = "txt_Curso";
            txt_Curso.ReadOnly = true;
            txt_Curso.Size = new Size(257, 39);
            txt_Curso.TabIndex = 165;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(662, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 32);
            label1.TabIndex = 167;
            label1.Text = "EDITAR INSCRIPCIÓN";
            // 
            // frm_editar_Incripcion
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 240, 248);
            ClientSize = new Size(1688, 463);
            Controls.Add(chk_Estado);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lst_lista_estudiantes);
            Controls.Add(lst_lista_cursos);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txt_Estudiante);
            Controls.Add(label2);
            Controls.Add(txt_Curso);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_editar_Incripcion";
            ShowIcon = false;
            Text = "Editar Inscripción";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chk_Estado;
        private Label label6;
        private Label label4;
        private ListBox lst_lista_estudiantes;
        private ListBox lst_lista_cursos;
        private Button btn_Salir;
        private Button btn_Cancelar;
        private Button btn_Guardar;
        private Label label5;
        private Label label3;
        private TextBox txt_Estudiante;
        private Label label2;
        private TextBox txt_Curso;
        private Label label1;
    }
}