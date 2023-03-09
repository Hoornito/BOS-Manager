using Contratos.Repositories;
using Contratos.Services;

//using DocumentFormat.OpenXml;
//using DocumentFormat.OpenXml.Packaging;
//using DocumentFormat.OpenXml.Spreadsheet;
using Domain.Models;

using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static iTextSharp.text.pdf.AcroFields;
using SL.Settings;
using SL.Tools;

namespace BLL.Services
{
    public class ReporteService : GenericService<ReporteModel>, IReporteService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        public ReporteService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IReporteRepository>())
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="fileName"></param>
        public void GenerateSalesReport(DateTime startDate, DateTime endDate, string fileName)
        {
            // Obtener los datos del informe
            int cantidadClientes = 0;
            decimal ingresos = 0;
            int cantidadPedidos = 0;
            int cantidadClientesNuevos = 0;


            // Crear un documento PDF
            Document document = new Document(PageSize.LETTER, 50, 50, 25, 25);

            // Crear un objeto PdfWriter para escribir el archivo PDF
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));

            // Abrir el documento PDF para escribir contenido
            document.Open();

            // Crear una tabla para mostrar los datos del informe
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 1f, 1f });

            // Agregar una celda para el título del informe
            PdfPCell cell = new PdfPCell(new Phrase("Reporte de ventas del mes", new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD)));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            // Agregar una celda para la cantidad de clientes únicos
            table.AddCell(new PdfPCell(new Phrase("Cantidad de clientes:", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));
            table.AddCell(new PdfPCell(new Phrase(cantidadClientes.ToString())));

            // Agregar una celda para la cantidad de clientes nuevos
            table.AddCell(new PdfPCell(new Phrase("Cantidad de clientes nuevos:", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));
            table.AddCell(new PdfPCell(new Phrase(cantidadClientesNuevos.ToString())));

            // Agregar una celda para la cantidad de pedidos
            table.AddCell(new PdfPCell(new Phrase("Cantidad de pedidos:", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));
            table.AddCell(new PdfPCell(new Phrase(cantidadPedidos.ToString())));

            // Agregar una celda para los ingresos totales
            table.AddCell(new PdfPCell(new Phrase("Ingresos totales:", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));
            table.AddCell(new PdfPCell(new Phrase("$" + ingresos.ToString("#,##0.00"))));

            document.Add(table);

            // Cerrar el documento PDF
            document.Close();

        }

        /// <summary>
        /// Genera un informe mensual de ventas
        /// </summary>
        public void GenerateMonthlyReport()
        {
            var _pedidoRepo = _unitOfWork.GetRepository<IPedidoRepository>();

            // Obtener los datos del informe
            var reportData = _pedidoRepo.Get()
                .GroupBy(p => new { p.FechaHora.Year, p.FechaHora.Month })
                .Select(g => new
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    Ingresos = g.Where(cp => cp.Estado == "Facturado").Sum(p => p.Total),
                    CantidadPedidos = g.Where(cp => cp.Estado == "Facturado").Count(),
                    Crecimiento = g.Sum(p =>
                                        _pedidoRepo.Get()
                                        .Where(p2 => p2.FechaHora.Year == g.Key.Year && p2.FechaHora.Month == g.Key.Month - 1 && p2.Estado == "Facturado")
                                        .Sum(p2 => p2.Total)) == 0 ? 0 : (g.Sum(p => p.Total) -
                                        _pedidoRepo.Get()
                                        .Where(p2 => p2.FechaHora.Year == g.Key.Year && p2.FechaHora.Month == g.Key.Month - 1 && p2.Estado == "Facturado")
                                        .Sum(p2 => p2.Total)) /
                                        _pedidoRepo.Get()
                                        .Where(p2 => p2.FechaHora.Year == g.Key.Year && p2.FechaHora.Month == g.Key.Month - 1 && p2.Estado == "Facturado")
                                        .Sum(p2 => p2.Total)
                })
                .OrderByDescending(r => r.Year)
                .ThenByDescending(r => r.Month)
                .ToList();

            // Crear un documento PDF
            Document document = new Document(PageSize.LETTER, 50, 50, 25, 25);

            // Crear un objeto PdfWriter para escribir el archivo PDF
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(ApplicationSettings.PDFReportPath, FileMode.Create));

            // Abrir el documento PDF para escribir contenido
            document.Open();

            // Crear una tabla para mostrar los datos del informe
            PdfPTable table = new PdfPTable(5);
            table.WidthPercentage = 100;
            table.SpacingBefore = 10f;
            table.SpacingAfter = 10f;
            table.SetWidths(new float[] { 1f, 1f, 1f, 1f, 1f });

            // Agregar una celda para el título del informe
            PdfPCell cell = new PdfPCell(new Phrase("Reporte mensual de ventas", new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD)));
            cell.Colspan = 5;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            // Agregar una celda para el encabezado de la tabla
            table.AddCell(new PdfPCell(new Phrase("Año", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));
            table.AddCell(new PdfPCell(new Phrase("Mes", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));
            table.AddCell(new PdfPCell(new Phrase("Ingresos", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));
            table.AddCell(new PdfPCell(new Phrase("Pedidos", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));
            table.AddCell(new PdfPCell(new Phrase("Crecimiento", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));

            // Agregar las filas con los datos del informe
            foreach (var row in reportData)
            {
                table.AddCell(new PdfPCell(new Phrase(row.Year.ToString())));
                table.AddCell(new PdfPCell(new Phrase(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(row.Month))));
                table.AddCell(new PdfPCell(new Phrase("$" + row.Ingresos.ToString("#,##0.00"))));
                table.AddCell(new PdfPCell(new Phrase(row.CantidadPedidos.ToString())));

                // Agregar una celda para la diferencia de crecimiento
                PdfPCell growthCell = new PdfPCell();
                growthCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                string growthText = "0";
                if (row.Crecimiento != 0)
                {
                    decimal growthPercentage = (decimal)row.Crecimiento * 100;
                    growthText = growthPercentage.ToString("#,##0.00") + "%";

                    if (row.Crecimiento > 0)
                    {
                        growthText += " \u25B2";
                    }
                    else if (row.Crecimiento < 0)
                    {
                        growthText += " \u25BC";
                    }
                }
                Phrase growthPhrase = new Phrase(growthText, new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL));

                growthCell.Phrase = growthPhrase;

                table.AddCell(growthCell);
            }

            // Agregar la tabla al documento PDF
            document.Add(table);

            // Cerrar el documento PDF y el objeto PdfWriter
            document.Close();
            writer.Close();
            
        }
        /// <summary>
        /// genera un excel con los pedidos
        /// </summary>
        public void GenerateExcelReport()
        {
            
            var _pedidoService = _unitOfWork.GetRepository<IPedidoRepository>();

            var data = _pedidoService.Get(includeProperties: "Cliente").ToList();
            ExcelGenerator.Current.Generate(data);
        }
    }
}