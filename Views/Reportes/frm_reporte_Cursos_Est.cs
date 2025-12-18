using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.EntityFrameworkCore;
using Gestion_Cursos.Data; // Para acceder a DbContext
using Gestion_Cursos.Views.Reportes; // Para acceder a tu ds_cursos
using System.IO;
using System.Reflection;

namespace Gestion_Cursos_Copia.Views.Reportes
{
    public partial class frm_reporte_Cursos_Est : Form
    {
        public frm_reporte_Cursos_Est()
        {
            InitializeComponent();
        }

        private void frm_reporte_Cursos_Est_Load(object sender, EventArgs e)
        {
            try
            {
                //1. Obtener los datos usando DbContext
                using (var db = new Gestion_Curso_DbContext())
                {
                    // Entity Framework a veces genera nombres como "Inscripcione" (con e al final)
                    var listaDatos = db.Inscripciones
                        .Include(i => i.Estudiante)
                        .Include(i => i.Curso)
                        .ThenInclude(c => c.Profesor)
                        .Select(i => new
                        {
                            NombreEst = i.Estudiante.Nombre + " " + i.Estudiante.Apellido,
                            CedulaEst = i.Estudiante.Cedula,
                            NombreCur = i.Curso.NombreCurso,
                            // Accedemos a la entidad 'Profesore'
                            NombreProf = i.Curso.Profesor.Nombre + " " + i.Curso.Profesor.Apellido,
                            Fecha = i.FechaInscripcion
                        })
                        .ToList();

                    //2. Llenar el DataSet Tipado
                    ds_cursos datosReporte = new ds_cursos();

                    // Limpiamos la tabla
                    datosReporte.dtCursos.Clear();

                    foreach (var item in listaDatos)
                    {
                        // Convertimos la fecha a string
                        string fechaString = item.Fecha.HasValue ? item.Fecha.Value.ToShortDateString() : "N/A";

                        // Agregamos la fila al DataSet
                        datosReporte.dtCursos.AdddtCursosRow(
                            item.NombreEst,
                            item.CedulaEst,
                            item.NombreCur,
                            item.NombreProf,
                            fechaString
                        );
                    }

                    //3. Configurar el Report (intenta recurso embebido, si no usa archivo RDLC)
                    this.reportViewer1.LocalReport.DataSources.Clear();

                    // Intentar usar recurso embebido si existe
                    var asm = Assembly.GetExecutingAssembly();
                    var resourceNames = asm.GetManifestResourceNames();
                    var match = resourceNames.FirstOrDefault(n => n.EndsWith("rpt_inscripciones_estudiantes.rdlc", StringComparison.OrdinalIgnoreCase));
                    if (!string.IsNullOrEmpty(match))
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = match;
                    }
                    else
                    {
                        // Buscar archivo rdlc en el directorio de la aplicación
                        var baseDir = AppDomain.CurrentDomain.BaseDirectory;
                        var files = Directory.GetFiles(baseDir, "rpt_inscripciones_estudiantes.rdlc", SearchOption.AllDirectories);
                        if (files.Length >0)
                        {
                            this.reportViewer1.LocalReport.ReportPath = files[0];
                        }
                        else
                        {
                            // Como último recurso, intentar la ruta relativa al proyecto
                            var relPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Reportes", "rpt_inscripciones_estudiantes.rdlc");
                            if (File.Exists(relPath))
                                this.reportViewer1.LocalReport.ReportPath = relPath;
                            else
                                throw new FileNotFoundException("No se encontró el archivo RDLC para el reporte (rpt_inscripciones_estudiantes.rdlc). Verifica que esté marcado como recurso embebido o Copiar siempre al directorio de salida.");
                        }
                    }

                    // "dts_Cursos" del diseño de RDLC
                    ReportDataSource rds = new ReportDataSource("dts_Cursos", datosReporte.Tables["dtCursos"]);

                    this.reportViewer1.LocalReport.DataSources.Add(rds);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }
        }
    }
}
