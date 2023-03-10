using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

using Domain.Models;

using SL.Settings;

namespace SL.Tools
{
    public class ExcelGenerator
    {
        #region singleton

        private readonly static ExcelGenerator _instance = new ExcelGenerator();

        public static ExcelGenerator Current
        {
            get
            {
                return _instance;
            }
        }

        private ExcelGenerator()
        {
            //Implent here the initialization of your singleton
        }

        /// <summary>
        /// El método "Generate" se encarga de generar un archivo de Excel a partir de una lista de objetos "PedidoModel".
        /// </summary>
        /// <param name="data"></param>
        #endregion
        public void Generate(List<PedidoModel> data)
        {
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(ApplicationSettings.ExcelPath, SpreadsheetDocumentType.Workbook))
            {
                // Agrega una hoja de cálculo al archivo.
                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                // Escribe los datos en la hoja de cálculo.
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                int row = 1;
                decimal TOTALtotal = 0;
                sheetData.AppendChild(new Row(
                    new Cell() { CellReference = "A" + row, DataType = CellValues.String, CellValue = new CellValue("Nombre Cliente") },
                    new Cell() { CellReference = "B" + row, DataType = CellValues.String, CellValue = new CellValue("Dirección") },
                    new Cell() { CellReference = "C" + row, DataType = CellValues.String, CellValue = new CellValue("Telefono") },
                    new Cell() { CellReference = "D" + row, DataType = CellValues.String, CellValue = new CellValue("Fecha") },
                    new Cell() { CellReference = "E" + row, DataType = CellValues.String, CellValue = new CellValue("Estado") },
                    new Cell() { CellReference = "F" + row, DataType = CellValues.String, CellValue = new CellValue("Total") })
                );
                row++;

                var dataRows = data.Select((item, index) =>
                    new Row(
                        new Cell() { CellReference = "A" + (index + 2), DataType = CellValues.String, CellValue = new CellValue(item.Cliente.Nombre) },
                        new Cell() { CellReference = "B" + (index + 2), DataType = CellValues.String, CellValue = new CellValue(item.Dirección) },
                        new Cell() { CellReference = "C" + (index + 2), DataType = CellValues.Number, CellValue = new CellValue(item.TelefonoContacto) },
                        new Cell() { CellReference = "D" + (index + 2), DataType = CellValues.String, CellValue = new CellValue(item.FechaHora.ToShortDateString()) },
                        new Cell() { CellReference = "E" + (index + 2), DataType = CellValues.String, CellValue = new CellValue(item.Estado) },
                        new Cell() { CellReference = "F" + (index + 2), DataType = CellValues.Number, CellValue = new CellValue((double)item.Total) })
                );
                foreach (var dataRow in dataRows)
                {
                    sheetData.AppendChild(dataRow);
                }


                // Agrega la hoja de cálculo al libro de trabajo.
                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Hoja1" };
                sheets.Append(sheet);

                // Guarda el archivo de Excel.
                workbookPart.Workbook.Save();
                spreadsheetDocument.Close();
            }
        
        }
    }
}
