using Contratos.Repositories;
using Contratos.Services;

using Domain.Entities;
using Domain.Models;

using iTextSharp.text;
using iTextSharp.text.pdf;

using SL.Tools;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class FacturaService : GenericService<FacturaModel>, IFacturaService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        public FacturaService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IFacturaRepository>())
        {

        }

        /// <summary>
        /// Crea una factura
        /// </summary>
        /// <param name="facturaModel"></param>
        public void CrearFactura(FacturaModel facturaModel)
        {
            try
            {
                var _pedidoRepository = _unitOfWork.GetRepository<IPedidoRepository>();
                var pedido = _pedidoRepository.GetById(facturaModel.Id_Pedido);
                var pedidofactura = _pedidoRepository.Get(x => x.Id_Pedido == facturaModel.Id_Pedido, includeProperties: "DetallePedido, DetallePedido.Producto").FirstOrDefault();
                facturaModel.BaseImponible = Math.Round((Convert.ToDecimal(pedido.Total) / (1 + facturaModel.IVA)),2);
                facturaModel.IVADiscriminado = Math.Round((Convert.ToDecimal(facturaModel.BaseImponible) * facturaModel.IVA), 2);
                facturaModel.FechaYHora = DateTime.Now;

                Insertar(facturaModel);

                pedido.Estado = "Facturado";
                _pedidoRepository.Update(pedido);

                string cantidad = "";
                string producto = "";
                string precio = "";
                string subtotal = "";

                byte[] fileC = null;
                Dictionary<string, string> dicBasico = new Dictionary<string, string>();
                foreach (var item in pedidofactura.DetallePedido.ToList())
                {
                    producto += item.Producto.Tipo + " - " + item.Producto.Nombre + "\n";
                    cantidad += item.Cantidad + "\n";
                    precio += "$ " + item.Producto.PrecioUnidad + "\n";
                    subtotal += "$ " + (item.Cantidad * item.Producto.PrecioUnidad) + "\n";
                }
                dicBasico.Add("txt_Servicio", producto);
                dicBasico.Add("txt_Cantidad", cantidad);
                dicBasico.Add("txt_Precio_Unit", precio);
                dicBasico.Add("txt_Subtotal", subtotal);
                dicBasico.Add("txt_impNeto", "$ " + facturaModel.BaseImponible);
                dicBasico.Add("txt_impIva", "$ " + facturaModel.IVADiscriminado);
                dicBasico.Add("txt_Imp_Total", "$ " + pedidofactura.Total.ToString());
                dicBasico.Add("txt_Campo_Nro", facturaModel.Id_Factura.ToString());
                dicBasico.Add("dt_Emision", facturaModel.FechaYHora.ToShortDateString());


                var templateFile = ConfigurationManager.AppSettings["TEMP_FILEPATH_FACTURASPDF"];
                fileC = RellenarPdf(templateFile, dicBasico, fileC);
                var strPDFPath = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["TEMP_PATH"] + ConfigurationManager.AppSettings["PDF_TEMP"] + "_Nro_" + facturaModel.Id_Factura + "-" + facturaModel.FechaYHora.ToShortDateString().ToString().Replace("/", "-") + ".pdf";
                
                File.WriteAllBytes(strPDFPath, fileC);

                _unitOfWork.Save();
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        /// <summary>
        /// obtiene la ultima factura
        /// </summary>
        /// <returns></returns>
        public FacturaModel ObtenerUltimaFactura()
        {
            try
            {
                var factura = Get().OrderByDescending(x => x.Id_Factura).FirstOrDefault();
                return factura;
            }
            catch (Exception)
            {

                throw;
            }   
        }
        private void PdfTicket()
        {
            Document document = new Document(PageSize.A4, 50, 50, 25, 25);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ticket.pdf", FileMode.Create));

            document.Open();

            // Encabezado
            Paragraph header = new Paragraph("Reporte Ventas");
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);

            // Información del cliente
            Paragraph customerInfo = new Paragraph("Nombre del cliente: Juan Pérez");
            customerInfo.SpacingBefore = 10f;
            customerInfo.SpacingAfter = 10f;
            document.Add(customerInfo);

            // Detalles de la compra
            PdfPTable table = new PdfPTable(3);
            table.AddCell("Producto");
            table.AddCell("Cantidad");
            table.AddCell("Precio");
            table.AddCell("Producto 1");
            table.AddCell("2");
            table.AddCell("$10.00");
            table.AddCell("Producto 2");
            table.AddCell("1");
            table.AddCell("$5.00");
            document.Add(table);

            // Total
            Paragraph total = new Paragraph("Total: $25.00");
            total.Alignment = Element.ALIGN_RIGHT;
            total.SpacingBefore = 10f;
            document.Add(total);
            document.Close();
        }
        /// <summary>
        /// rellena el pdf
        /// </summary>
        /// <param name="templateFile"></param>
        /// <param name="dicBasico"></param>
        /// <param name="strFileContent"></param>
        /// <param name="TipoCopia"></param>
        /// <returns></returns>
        private byte[] RellenarPdf(string templateFile, Dictionary<string, string> dicBasico, byte[] strFileContent, string TipoCopia = "Original")
        {

            strFileContent = null;
            string strFormVacioPath = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["TEMPLATE_PATH"] + templateFile;
            string strFormLlenoPath = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["TEMP_PATH"] + ConfigurationManager.AppSettings["PDF_TEMP"] + "_Nro_" + "1" + "-" + "test" + ".pdf";

            try
            {
                using (FileStream fileOutput = new FileStream(strFormLlenoPath, FileMode.Create))
                {
                    PdfReader pdfReader = new PdfReader(strFormVacioPath);
                    PdfStamper pdfStamper = new PdfStamper(pdfReader, fileOutput);

                    AcroFields pdfFormFields = pdfStamper.AcroFields;
                    PdfContentByte pdfContentByte = pdfStamper.GetOverContent(1);
                    System.Collections.Generic.IDictionary<string, AcroFields.Item> dicFields = pdfFormFields.Fields;

                    foreach (var CollectionItem in dicFields)
                    {
                        if (dicBasico.ContainsKey(CollectionItem.Key))
                        {
                            //if (CollectionItem.Key == "imgQrAfip")
                            //{
                            //    byte[] imageArray = System.IO.File.ReadAllBytes(dicBasico[CollectionItem.Key]);
                            //    string img = Convert.ToBase64String(imageArray);
                            //    pdfFormFields.SetField(CollectionItem.Key, img);
                            //}
                            //else
                            //{
                            //    pdfFormFields.SetField(CollectionItem.Key, dicBasico[CollectionItem.Key]);
                            //}
                            pdfFormFields.SetField(CollectionItem.Key, dicBasico[CollectionItem.Key]);
                        }
                    }

                    pdfStamper.FormFlattening = false;
                    pdfStamper.Close();
                    pdfReader.Close();
                    pdfContentByte.ClosePath();
                }


                if (File.Exists(strFormLlenoPath))
                {

                    strFileContent = File.ReadAllBytes(strFormLlenoPath);
                    File.Delete(strFormLlenoPath);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strFileContent;
        }
    }
}
