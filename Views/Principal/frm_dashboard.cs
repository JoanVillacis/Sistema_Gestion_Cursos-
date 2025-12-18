
using Gestion_Cursos.Views.Cursos;
using Gestion_Cursos.Views.Estudiantes;
using Gestion_Cursos.Views.Inscripciones;
using Gestion_Cursos.Views.Profesores;
using Gestion_Cursos.Views.Usuarios;
using Gestion_Cursos_Copia.Views.Reportes;

namespace Sistema_Gestion_Cursos.Views.Principal
{
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_usuarios = new frm_listar_Usuarios();
            frm_lista_usuarios.ShowDialog();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_agregar_usuario = new frm_agregar_Usuario();
            frm_agregar_usuario.ShowDialog();
        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_usuarios = new frm_listar_Usuarios();
            frm_lista_usuarios.ShowDialog();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_usuarios = new frm_listar_Usuarios();
            frm_lista_usuarios.ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_estudiantes = new frm_listar_Estudiantes();
            frm_lista_estudiantes.ShowDialog();
        }

        private void agregarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_agregar_estudiante = new frm_agregar_Estudiante();
            frm_agregar_estudiante.ShowDialog();
        }

        private void editarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_estudiantes = new frm_listar_Estudiantes();
            frm_lista_estudiantes.ShowDialog();
        }

        private void eliminarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_estudiantes = new frm_listar_Estudiantes();
            frm_lista_estudiantes.ShowDialog();
        }

        private void listaDeInscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_inscripciones = new frm_listar_incripciones();
            frm_lista_inscripciones.ShowDialog();
        }

        private void agregarInscripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_agregar_inscripcion = new frm_agregar_Incripcion();
            frm_agregar_inscripcion.ShowDialog();
        }

        private void editarInscripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_inscripciones = new frm_listar_incripciones();
            frm_lista_inscripciones.ShowDialog();
        }

        private void eliminarInscripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_inscripciones = new frm_listar_incripciones();
            frm_lista_inscripciones.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_profesores = new frm_listar_Profesores();
            frm_lista_profesores.ShowDialog();
        }

        private void agregarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_agregar_profesor = new frm_agregar_Profesor();
            frm_agregar_profesor.ShowDialog();
        }

        private void editarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_profesores = new frm_listar_Profesores();
            frm_lista_profesores.ShowDialog();
        }

        private void eliminarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_profesores = new frm_listar_Profesores();
            frm_lista_profesores.ShowDialog();
        }

        private void listaDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_cursos = new frm_listar_Cursos();
            frm_lista_cursos.ShowDialog();
        }

        private void agregarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_agregar_curso = new frm_agregar_Curso();
            frm_agregar_curso.ShowDialog();
        }

        private void editarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_cursos = new frm_listar_Cursos();
            frm_lista_cursos.ShowDialog();
        }

        private void eliminarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_cursos = new frm_listar_Cursos();
            frm_lista_cursos.ShowDialog();
        }

        private void cursosInscritosPorEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_reporte_cursos_est = new frm_reporte_Cursos_Est();
            frm_reporte_cursos_est.ShowDialog();

        }
    }
}
