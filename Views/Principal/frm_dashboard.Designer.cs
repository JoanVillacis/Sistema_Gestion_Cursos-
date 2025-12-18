namespace Sistema_Gestion_Cursos.Views.Principal
{
    partial class frm_dashboard
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            listaDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            editarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            eliminarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            estudiantesToolStripMenuItem = new ToolStripMenuItem();
            listaDeEstudiantesToolStripMenuItem = new ToolStripMenuItem();
            agregarEstudianteToolStripMenuItem = new ToolStripMenuItem();
            editarEstudianteToolStripMenuItem = new ToolStripMenuItem();
            eliminarEstudianteToolStripMenuItem = new ToolStripMenuItem();
            inscripcionesToolStripMenuItem = new ToolStripMenuItem();
            listaDeInscripcionesToolStripMenuItem = new ToolStripMenuItem();
            agregarInscripciónToolStripMenuItem = new ToolStripMenuItem();
            editarInscripciónToolStripMenuItem = new ToolStripMenuItem();
            eliminarInscripciónToolStripMenuItem = new ToolStripMenuItem();
            profesoresToolStripMenuItem = new ToolStripMenuItem();
            listaDeProfesoresToolStripMenuItem = new ToolStripMenuItem();
            agregarProfesorToolStripMenuItem = new ToolStripMenuItem();
            editarProfesorToolStripMenuItem = new ToolStripMenuItem();
            eliminarProfesorToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            listaDeCursosToolStripMenuItem = new ToolStripMenuItem();
            agregarCursoToolStripMenuItem = new ToolStripMenuItem();
            editarCursoToolStripMenuItem = new ToolStripMenuItem();
            eliminarCursoToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            cursosInscritosPorEstudianteToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 552);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 10);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(202, 240, 248);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, estudiantesToolStripMenuItem, profesoresToolStripMenuItem, cursosToolStripMenuItem, inscripcionesToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(829, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeUsuariosToolStripMenuItem, agregarUsuarioToolStripMenuItem, editarUsuarioToolStripMenuItem, eliminarUsuarioToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(79, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // listaDeUsuariosToolStripMenuItem
            // 
            listaDeUsuariosToolStripMenuItem.Name = "listaDeUsuariosToolStripMenuItem";
            listaDeUsuariosToolStripMenuItem.Size = new Size(203, 26);
            listaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios";
            listaDeUsuariosToolStripMenuItem.Click += listaDeUsuariosToolStripMenuItem_Click;
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            agregarUsuarioToolStripMenuItem.Size = new Size(203, 26);
            agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            agregarUsuarioToolStripMenuItem.Click += agregarUsuarioToolStripMenuItem_Click;
            // 
            // editarUsuarioToolStripMenuItem
            // 
            editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            editarUsuarioToolStripMenuItem.Size = new Size(203, 26);
            editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            editarUsuarioToolStripMenuItem.Click += editarUsuarioToolStripMenuItem_Click;
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            eliminarUsuarioToolStripMenuItem.Size = new Size(203, 26);
            eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            eliminarUsuarioToolStripMenuItem.Click += eliminarUsuarioToolStripMenuItem_Click;
            // 
            // estudiantesToolStripMenuItem
            // 
            estudiantesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeEstudiantesToolStripMenuItem, agregarEstudianteToolStripMenuItem, editarEstudianteToolStripMenuItem, eliminarEstudianteToolStripMenuItem });
            estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            estudiantesToolStripMenuItem.Size = new Size(98, 24);
            estudiantesToolStripMenuItem.Text = "Estudiantes";
            // 
            // listaDeEstudiantesToolStripMenuItem
            // 
            listaDeEstudiantesToolStripMenuItem.Name = "listaDeEstudiantesToolStripMenuItem";
            listaDeEstudiantesToolStripMenuItem.Size = new Size(222, 26);
            listaDeEstudiantesToolStripMenuItem.Text = "Lista de Estudiantes";
            listaDeEstudiantesToolStripMenuItem.Click += listaDeEstudiantesToolStripMenuItem_Click;
            // 
            // agregarEstudianteToolStripMenuItem
            // 
            agregarEstudianteToolStripMenuItem.Name = "agregarEstudianteToolStripMenuItem";
            agregarEstudianteToolStripMenuItem.Size = new Size(222, 26);
            agregarEstudianteToolStripMenuItem.Text = "Agregar Estudiante";
            agregarEstudianteToolStripMenuItem.Click += agregarEstudianteToolStripMenuItem_Click;
            // 
            // editarEstudianteToolStripMenuItem
            // 
            editarEstudianteToolStripMenuItem.Name = "editarEstudianteToolStripMenuItem";
            editarEstudianteToolStripMenuItem.Size = new Size(222, 26);
            editarEstudianteToolStripMenuItem.Text = "Editar Estudiante";
            editarEstudianteToolStripMenuItem.Click += editarEstudianteToolStripMenuItem_Click;
            // 
            // eliminarEstudianteToolStripMenuItem
            // 
            eliminarEstudianteToolStripMenuItem.Name = "eliminarEstudianteToolStripMenuItem";
            eliminarEstudianteToolStripMenuItem.Size = new Size(222, 26);
            eliminarEstudianteToolStripMenuItem.Text = "Eliminar Estudiante";
            eliminarEstudianteToolStripMenuItem.Click += eliminarEstudianteToolStripMenuItem_Click;
            // 
            // inscripcionesToolStripMenuItem
            // 
            inscripcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeInscripcionesToolStripMenuItem, agregarInscripciónToolStripMenuItem, editarInscripciónToolStripMenuItem, eliminarInscripciónToolStripMenuItem });
            inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            inscripcionesToolStripMenuItem.Size = new Size(108, 24);
            inscripcionesToolStripMenuItem.Text = "Inscripciones";
            inscripcionesToolStripMenuItem.Click += inscripcionesToolStripMenuItem_Click;
            // 
            // listaDeInscripcionesToolStripMenuItem
            // 
            listaDeInscripcionesToolStripMenuItem.Name = "listaDeInscripcionesToolStripMenuItem";
            listaDeInscripcionesToolStripMenuItem.Size = new Size(232, 26);
            listaDeInscripcionesToolStripMenuItem.Text = "Lista de Inscripciones";
            listaDeInscripcionesToolStripMenuItem.Click += listaDeInscripcionesToolStripMenuItem_Click;
            // 
            // agregarInscripciónToolStripMenuItem
            // 
            agregarInscripciónToolStripMenuItem.Name = "agregarInscripciónToolStripMenuItem";
            agregarInscripciónToolStripMenuItem.Size = new Size(232, 26);
            agregarInscripciónToolStripMenuItem.Text = "Agregar Inscripción";
            agregarInscripciónToolStripMenuItem.Click += agregarInscripciónToolStripMenuItem_Click;
            // 
            // editarInscripciónToolStripMenuItem
            // 
            editarInscripciónToolStripMenuItem.Name = "editarInscripciónToolStripMenuItem";
            editarInscripciónToolStripMenuItem.Size = new Size(232, 26);
            editarInscripciónToolStripMenuItem.Text = "Editar Inscripción";
            editarInscripciónToolStripMenuItem.Click += editarInscripciónToolStripMenuItem_Click;
            // 
            // eliminarInscripciónToolStripMenuItem
            // 
            eliminarInscripciónToolStripMenuItem.Name = "eliminarInscripciónToolStripMenuItem";
            eliminarInscripciónToolStripMenuItem.Size = new Size(232, 26);
            eliminarInscripciónToolStripMenuItem.Text = "Eliminar Inscripción";
            eliminarInscripciónToolStripMenuItem.Click += eliminarInscripciónToolStripMenuItem_Click;
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeProfesoresToolStripMenuItem, agregarProfesorToolStripMenuItem, editarProfesorToolStripMenuItem, eliminarProfesorToolStripMenuItem });
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new Size(92, 24);
            profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // listaDeProfesoresToolStripMenuItem
            // 
            listaDeProfesoresToolStripMenuItem.Name = "listaDeProfesoresToolStripMenuItem";
            listaDeProfesoresToolStripMenuItem.Size = new Size(224, 26);
            listaDeProfesoresToolStripMenuItem.Text = "Lista de Profesores";
            listaDeProfesoresToolStripMenuItem.Click += listaDeProfesoresToolStripMenuItem_Click;
            // 
            // agregarProfesorToolStripMenuItem
            // 
            agregarProfesorToolStripMenuItem.Name = "agregarProfesorToolStripMenuItem";
            agregarProfesorToolStripMenuItem.Size = new Size(224, 26);
            agregarProfesorToolStripMenuItem.Text = "Agregar Profesor";
            agregarProfesorToolStripMenuItem.Click += agregarProfesorToolStripMenuItem_Click;
            // 
            // editarProfesorToolStripMenuItem
            // 
            editarProfesorToolStripMenuItem.Name = "editarProfesorToolStripMenuItem";
            editarProfesorToolStripMenuItem.Size = new Size(224, 26);
            editarProfesorToolStripMenuItem.Text = "Editar Profesor";
            editarProfesorToolStripMenuItem.Click += editarProfesorToolStripMenuItem_Click;
            // 
            // eliminarProfesorToolStripMenuItem
            // 
            eliminarProfesorToolStripMenuItem.Name = "eliminarProfesorToolStripMenuItem";
            eliminarProfesorToolStripMenuItem.Size = new Size(224, 26);
            eliminarProfesorToolStripMenuItem.Text = "Eliminar Profesor";
            eliminarProfesorToolStripMenuItem.Click += eliminarProfesorToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeCursosToolStripMenuItem, agregarCursoToolStripMenuItem, editarCursoToolStripMenuItem, eliminarCursoToolStripMenuItem });
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(66, 24);
            cursosToolStripMenuItem.Text = "Cursos";
            // 
            // listaDeCursosToolStripMenuItem
            // 
            listaDeCursosToolStripMenuItem.Name = "listaDeCursosToolStripMenuItem";
            listaDeCursosToolStripMenuItem.Size = new Size(224, 26);
            listaDeCursosToolStripMenuItem.Text = "Lista de Cursos";
            listaDeCursosToolStripMenuItem.Click += listaDeCursosToolStripMenuItem_Click;
            // 
            // agregarCursoToolStripMenuItem
            // 
            agregarCursoToolStripMenuItem.Name = "agregarCursoToolStripMenuItem";
            agregarCursoToolStripMenuItem.Size = new Size(224, 26);
            agregarCursoToolStripMenuItem.Text = "Agregar Curso";
            agregarCursoToolStripMenuItem.Click += agregarCursoToolStripMenuItem_Click;
            // 
            // editarCursoToolStripMenuItem
            // 
            editarCursoToolStripMenuItem.Name = "editarCursoToolStripMenuItem";
            editarCursoToolStripMenuItem.Size = new Size(224, 26);
            editarCursoToolStripMenuItem.Text = "Editar Curso";
            editarCursoToolStripMenuItem.Click += editarCursoToolStripMenuItem_Click;
            // 
            // eliminarCursoToolStripMenuItem
            // 
            eliminarCursoToolStripMenuItem.Name = "eliminarCursoToolStripMenuItem";
            eliminarCursoToolStripMenuItem.Size = new Size(224, 26);
            eliminarCursoToolStripMenuItem.Text = "Eliminar Curso";
            eliminarCursoToolStripMenuItem.Click += eliminarCursoToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cursosInscritosPorEstudianteToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cursosInscritosPorEstudianteToolStripMenuItem
            // 
            cursosInscritosPorEstudianteToolStripMenuItem.Name = "cursosInscritosPorEstudianteToolStripMenuItem";
            cursosInscritosPorEstudianteToolStripMenuItem.Size = new Size(293, 26);
            cursosInscritosPorEstudianteToolStripMenuItem.Text = "Cursos Inscritos por Estudiante";
            cursosInscritosPorEstudianteToolStripMenuItem.Click += cursosInscritosPorEstudianteToolStripMenuItem_Click;
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(829, 2);
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(-1, -2);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(829, 30);
            toolStripContainer1.TabIndex = 2;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // panel2
            // 
            panel2.AccessibleRole = AccessibleRole.None;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 521);
            panel2.TabIndex = 3;
            // 
            // frm_dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 562);
            Controls.Add(toolStripContainer1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(0);
            MaximizeBox = false;
            Name = "frm_dashboard";
            ShowIcon = false;
            Text = "Menú";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem estudiantesToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private ToolStripMenuItem inscripcionesToolStripMenuItem;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private Panel panel2;
        private ToolStripMenuItem listaDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private ToolStripMenuItem listaDeEstudiantesToolStripMenuItem;
        private ToolStripMenuItem agregarEstudianteToolStripMenuItem;
        private ToolStripMenuItem editarEstudianteToolStripMenuItem;
        private ToolStripMenuItem eliminarEstudianteToolStripMenuItem;
        private ToolStripMenuItem listaDeInscripcionesToolStripMenuItem;
        private ToolStripMenuItem agregarInscripciónToolStripMenuItem;
        private ToolStripMenuItem editarInscripciónToolStripMenuItem;
        private ToolStripMenuItem eliminarInscripciónToolStripMenuItem;
        private ToolStripMenuItem listaDeProfesoresToolStripMenuItem;
        private ToolStripMenuItem agregarProfesorToolStripMenuItem;
        private ToolStripMenuItem editarProfesorToolStripMenuItem;
        private ToolStripMenuItem eliminarProfesorToolStripMenuItem;
        private ToolStripMenuItem listaDeCursosToolStripMenuItem;
        private ToolStripMenuItem agregarCursoToolStripMenuItem;
        private ToolStripMenuItem editarCursoToolStripMenuItem;
        private ToolStripMenuItem eliminarCursoToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem cursosInscritosPorEstudianteToolStripMenuItem;
    }
}