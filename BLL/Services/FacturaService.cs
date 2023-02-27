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
        public FacturaService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IFacturaRepository>())
        {

        }


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

                _unitOfWork.Save();

                string cantidad = "";
                string producto = "";
                string precio = "";
                string subtotal = "";

                byte[] fileC = null;
                Dictionary<string, string> dicBasico = new Dictionary<string, string>();
                foreach (var item in pedidofactura.DetallePedido.ToList())
                {
                    producto += item.Producto.Nombre + "\n";
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
            }
            catch (Exception)
            {

                throw;
            }
        }
        
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
                    //Execute(pdfStamper);
                    //Rectangle bottomTxt = pdfFormFields.GetFieldPositions("txt_Servicio").LastOrDefault().position;

                    //Rectangle txtLineaRect = pdfFormFields.GetFieldPositions("txt_linea").LastOrDefault().position;
                    //Rectangle txt2 = pdfFormFields.GetFieldPositions("txt_Total_Sin_Iva").LastOrDefault().position;
                    //Rectangle txt3 = pdfFormFields.GetFieldPositions("txt_IVA").LastOrDefault().position;
                    //Rectangle txt4 = pdfFormFields.GetFieldPositions("txt_Total").LastOrDefault().position;
                    //Rectangle txt5 = pdfFormFields.GetFieldPositions("txt_impNeto").LastOrDefault().position;
                    //Rectangle txt6 = pdfFormFields.GetFieldPositions("txt_impIva").LastOrDefault().position;
                    //Rectangle txt7 = pdfFormFields.GetFieldPositions("txt_Imp_Total").LastOrDefault().position;

                    ////txtLineaRect.Bottom = bottomTxt. - 10;
                    ////txt2.Bottom = txtLineaRect.Bottom - 10;
                    ////txt3.Bottom = txt2.Bottom - 10;
                    ////txt4.Bottom = txt3.Bottom - 10;
                    ////txt5.Bottom = txtLineaRect.Bottom - 10;
                    ////txt6.Bottom = txt5.Bottom - 10;
                    ////txt7.Bottom = txt6.Bottom - 10;

                    //pdfFormFields.RemoveField("txt_linea", 1);
                    //pdfFormFields.RemoveField("txt_Total_Sin_Iva", 1);
                    //pdfFormFields.RemoveField("txt_IVA", 1);
                    //pdfFormFields.RemoveField("txt_Total", 1);
                    //pdfFormFields.RemoveField("txt_impNeto", 1);
                    //pdfFormFields.RemoveField("txt_impIva", 1);
                    //pdfFormFields.RemoveField("txt_Imp_Total", 1);

                    //PdfFormField campotxtLinea = PdfFormField.CreateTextField(pdfStamper.Writer, true, false, 0);
                    //PdfFormField txtField2 = PdfFormField.CreateTextField(pdfStamper.Writer, true, false, 0);
                    //PdfFormField txtField3 = PdfFormField.CreateTextField(pdfStamper.Writer, true, false, 0);
                    //PdfFormField txtField4 = PdfFormField.CreateTextField(pdfStamper.Writer, true, false, 0);
                    //PdfFormField txtField5 = PdfFormField.CreateTextField(pdfStamper.Writer, true, false, 0);
                    //PdfFormField txtField6 = PdfFormField.CreateTextField(pdfStamper.Writer, true, false, 0);
                    //PdfFormField txtField7 = PdfFormField.CreateTextField(pdfStamper.Writer, true, false, 0);


                    //campotxtLinea.FieldName = "txt_linea";
                    //campotxtLinea.ValueAsString = "TOTAL SIN IVA";
                    //campotxtLinea.SetFieldFlags(PdfFormField.FF_READ_ONLY);

                    //txtField2.FieldName = "txt_Total_Sin_Iva";
                    //txtField3.FieldName = "txt_IVA";
                    //txtField4.FieldName = "txt_Total";
                    //txtField5.FieldName = "txt_impNeto";
                    //txtField6.FieldName = "txt_impIva";
                    //txtField7.FieldName = "txt_Imp_Total";

                    //campotxtLinea.SetWidget(txtLineaRect, PdfAnnotation.HIGHLIGHT_INVERT);
                    //txtField2.SetWidget(txt2, PdfAnnotation.HIGHLIGHT_INVERT);
                    //txtField3.SetWidget(txt3, PdfAnnotation.HIGHLIGHT_INVERT);
                    //txtField4.SetWidget(txt4, PdfAnnotation.HIGHLIGHT_INVERT);
                    //txtField5.SetWidget(txt5, PdfAnnotation.HIGHLIGHT_INVERT);
                    //txtField6.SetWidget(txt6, PdfAnnotation.HIGHLIGHT_INVERT);
                    //txtField7.SetWidget(txt7, PdfAnnotation.HIGHLIGHT_INVERT);

                    //pdfStamper.AddAnnotation(campotxtLinea, 1);
                    //pdfStamper.AddAnnotation(txtField2, 1);
                    //pdfStamper.AddAnnotation(txtField3, 1);
                    //pdfStamper.AddAnnotation(txtField4, 1);
                    //pdfStamper.AddAnnotation(txtField5, 1);
                    //pdfStamper.AddAnnotation(txtField6, 1);
                    //pdfStamper.AddAnnotation(txtField7, 1);

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

        private void Execute(PdfStamper pdfStamper)
        {
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            Rectangle bottomTxt = pdfFormFields.GetFieldPositions("txt_Servicio").LastOrDefault().position;
            foreach (var nombreCampo in GetLastLine())
            {
                Rectangle txtLineaRect = pdfFormFields.GetFieldPositions(nombreCampo.Key).LastOrDefault().position;

                txtLineaRect.Bottom = bottomTxt.Bottom - 10;
                txtLineaRect.Top = bottomTxt.Top - 10;

                pdfFormFields.RemoveField(nombreCampo.Key, 1);
                PdfFormField campotxtLinea = PdfFormField.CreateTextField(pdfStamper.Writer, true, false, 0);
                campotxtLinea.FieldName = nombreCampo.Key;
                campotxtLinea.ValueAsString = nombreCampo.Value;
                campotxtLinea.SetFieldFlags(PdfFormField.FF_READ_ONLY);
                campotxtLinea.SetWidget(txtLineaRect, PdfAnnotation.HIGHLIGHT_INVERT);
                pdfStamper.AddAnnotation(campotxtLinea, 1);
            }

        }

        private Dictionary<string,string> GetLastLine()
        {
            Dictionary<string, string> newList = new Dictionary<string, string>();

            newList.Add("txt_linea", "-------------------------------------------------------------");
            newList.Add("txt_Total_Sin_Iva", "Total sin I.V.A.");
            newList.Add("txt_IVA", "I.V.A.");
            newList.Add("txt_Total", "Total");
            newList.Add("txt_impNeto", "");
            newList.Add("txt_impIva", "");
            newList.Add("txt_Imp_Total", "");

            return newList;
        }
    }
}
