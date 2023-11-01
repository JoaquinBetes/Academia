using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

namespace Informe
{
    public class Program
    {
        
        public static void InformeArbol(int idEspecialidad)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            Entities.Especialidad especialidad = Business.Especialidad.Get(idEspecialidad);

            List<Entities.Plan> planes = Business.Plan.getAll();
            List<Entities.Materia> materias = Business.Materia.getAll();
            List<Entities.Comision> comisiones = Business.Comision.GetAll();
            List<Entities.Curso> cursos = Business.Curso.getAll();

            planes = planes.Where(x => x.IdEspecialidad == idEspecialidad).ToList();
            materias = materias.Where(x => planes.Any(y => y.IdPlan == x.IdPlan)).ToList();
            comisiones = comisiones.Where(x => planes.Any(y => y.IdPlan == x.IDPlan)).ToList();
            cursos = cursos.Where(x => comisiones.Any(y => y.IdComision == x.IdComision)).ToList();

            Document.Create(container =>
             {
                 container.Page(page =>
                 {
                     page.Header().AlignCenter().Text($"Informe árbol de especialidad: {especialidad.Descripcion}").Bold().FontSize(20);
                     page.Content().Column(col1 =>
                     {
                         col1.Spacing(10);
                         col1.Item().Text("Planes").Bold().FontSize(15);
                         col1.Item().Table(table =>
                         {

                             table.ColumnsDefinition(columns =>
                             {

                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                             });
                             // Encabezados de la tabla
                             table.Header(header =>
                             {
                                 header.Cell().Background("#257272").Padding(2).Text("ID").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("Descripcion").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("ID Especialidad").FontColor("#fff");
                             });

                             // Filas de datos
                             foreach (var plan in planes)
                             {
                                 var id = plan.IdPlan.ToString();
                                 var descripcion = plan.Descripcion;
                                 var idEspecialidad = plan.IdEspecialidad.ToString();

                                 //table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(Placeholders.Label()).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(id).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(descripcion).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(idEspecialidad).FontSize(10);

                             }
                         });
                         col1.Item().Text("Materias").Bold().FontSize(15);
                         col1.Item().Table(table =>
                         {

                             table.ColumnsDefinition(columns =>
                             {

                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                             });
                             // Encabezados de la tabla
                             table.Header(header =>
                             {
                                 header.Cell().Background("#257272").Padding(2).Text("ID").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("Descripcion").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("Hs Semanales").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("Hs Totales").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("ID Plan").FontColor("#fff");
                             });

                             // Filas de datos
                             foreach (var materia in materias)
                             {
                                 var id = materia.IdMateria.ToString();
                                 var descripcion = materia.Descripcion;
                                 var hsSemanales = materia.HsSemanales.ToString();
                                 var hsTotales = materia.HsTotales.ToString();
                                 var idPlan = materia.IdPlan.ToString();

                                 //table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(Placeholders.Label()).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(id).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(descripcion).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(hsSemanales).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(hsTotales).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(idPlan).FontSize(10);

                             }
                         });
                         col1.Item().Text("Comisiones").Bold().FontSize(15);
                         col1.Item().Table(table =>
                         {

                             table.ColumnsDefinition(columns =>
                             {

                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                                 columns.RelativeColumn();

                             });
                             // Encabezados de la tabla
                             table.Header(header =>
                             {
                                 header.Cell().Background("#257272").Padding(2).Text("ID").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("Descripcion").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("Año Especialidad").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("ID Plan").FontColor("#fff");

                             });

                             // Filas de datos
                             foreach (var comision in comisiones)
                             {
                                 var id = comision.IdComision.ToString();
                                 var descripcion = comision.Descripcion;
                                 var anioEspecialidad = comision.AnioEspecialidad.ToString();
                                 var idPlan = comision.IDPlan.ToString();

                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(id).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(descripcion).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(anioEspecialidad).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(idPlan).FontSize(10);


                             }
                         });
                         col1.Item().Text("Cursos").Bold().FontSize(15);
                         col1.Item().Table(table =>
                         {

                             table.ColumnsDefinition(columns =>
                             {

                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                                 columns.RelativeColumn();
                             });
                             // Encabezados de la tabla
                             table.Header(header =>
                             {
                                 header.Cell().Background("#257272").Padding(2).Text("ID").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("IdMateria").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("IdComision").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("Cupo").FontColor("#fff");
                                 header.Cell().Background("#257272").Padding(2).Text("Año Calendario").FontColor("#fff");

                             });

                             // Filas de datos
                             foreach (var cursos in cursos)
                             {
                                 var id = cursos.IdCurso.ToString();
                                 var idMateria = cursos.IdMateria.ToString();
                                 var idComision = cursos.IdComision.ToString();
                                 var cupo = cursos.Cupo.ToString();
                                 var anioCalendario = cursos.AnioCalendario.ToString();

                                 //table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(Placeholders.Label()).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(id).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(idMateria).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(idComision).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(cupo).FontSize(10);
                                 table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(anioCalendario).FontSize(10);

                             }
                         });
                     });
                     //page.Footer().AlignCenter().PageNumber("Page {number}");
                 });

             }).GeneratePdf(@"../../../../Informes/InformeArbol.pdf");//.ShowInPreviewer();
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            InformeArbol(4);
        }
    }
}