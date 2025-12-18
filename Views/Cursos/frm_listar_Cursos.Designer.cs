namespace Gestion_Cursos.Views.Cursos
{
    partial class frm_listar_Cursos
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
            lst_lista_cursos = new ListBox();
            btn_salir = new Button();
            btn_eliminar = new Button();
            btn_editar = new Button();
            label1 = new Label();
            btn_agregar = new Button();
            SuspendLayout();
            // 
            // lst_lista_cursos
            // 
            lst_lista_cursos.FormattingEnabled = true;
            lst_lista_cursos.ItemHeight = 31;
            lst_lista_cursos.Location = new Point(133, 43);
            lst_lista_cursos.Name = "lst_lista_cursos";
            lst_lista_cursos.Size = new Size(731, 283);
            lst_lista_cursos.TabIndex = 33;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(0, 180, 216);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(8, 259);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 52);
            btn_salir.TabIndex = 31;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(0, 119, 182);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(8, 200);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(112, 52);
            btn_eliminar.TabIndex = 30;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.FromArgb(0, 180, 216);
            btn_editar.ForeColor = Color.White;
            btn_editar.Location = new Point(8, 136);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(112, 52);
            btn_editar.TabIndex = 29;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(418, 26);
            label1.TabIndex = 32;
            label1.Text = "CENTRO DE CONTROL DE CURSOS";
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(0, 119, 182);
            btn_agregar.ForeColor = Color.White;
            btn_agregar.Location = new Point(8, 67);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(112, 52);
            btn_agregar.TabIndex = 28;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // frm_listar_Cursos
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 240, 248);
            ClientSize = new Size(888, 346);
            Controls.Add(lst_lista_cursos);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(label1);
            Controls.Add(btn_agregar);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frm_listar_Cursos";
            ShowIcon = false;
            Text = "Listar Cursos";
            Load += frm_listar_Cursos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_lista_cursos;
        private Button btn_salir;
        private Button btn_eliminar;
        private Button btn_editar;
        private Label label1;
        private Button btn_agregar;
    }
}