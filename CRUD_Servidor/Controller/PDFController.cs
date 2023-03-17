using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using System;
using System.Collections.Generic;
using System.Text;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.IO.Image;
using iText.Kernel.Colors;
using DataLayer;
namespace Controller
{
    public class PDFController
    {
        static VentasDAO dao = new VentasDAO();
        public static void GeneratePDFDocument()
        {
            /*Si quiero realizar tamaños personalizados , puedo hacer lo siguiente*/

            //1 pulgada = 72pt (10,14) == 720x1008
            PageSize tamanioPersonalizado = new PageSize(720, 1008);

            /*--------------------------------------------------------*/
            PdfWriter pdfEscritura = new PdfWriter("Ventas.pdf");
            PdfDocument pdf = new PdfDocument(pdfEscritura);
            //Document document = new Document(pdf,PageSize.LETTER);
            Document document = new Document(pdf, tamanioPersonalizado);
            
            document.SetMargins(80, 20, 40, 20);

            //var p = new Paragraph("Hola pai");

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.COURIER_BOLD);


            string[] columnas = {"Usuario", "Telefono", "Producto", "Precio"};
            float[] tamaniosCampos = { 3, 3, 3, 1 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamaniosCampos));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach(string c in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(c).SetFont(fontColumnas)));
            }


            List<Venta> ventas = dao.getVentasAll();

            foreach(Venta v in ventas)
            {
                tabla.AddCell(new Cell().Add(new Paragraph(v.User.UserName).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(v.User.Telephone.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(v.Product.Name).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(v.Product.Price.ToString()).SetFont(fontContenido)));

            }
            document.Add(tabla);
            document.Close();


            /*Fuentes*/
            PdfFont tituloFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fechaFont = PdfFontFactory.CreateFont(StandardFonts.COURIER_BOLD);

            /*---*/
            var logo = new Image(ImageDataFactory.Create("C:/Users/Usuario/Desktop/pdf/logo.png"));
            logo.SetWidth(60);
            logo.SetHeight(60);

            var pLogo = new Paragraph().Add(logo);
            var titulo = new Paragraph("Reporte de ventas");

            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(20);
            titulo.SetFont(tituloFont);

            var fecha = DateTime.Now.ToString("dd-MM-yy");
            var hora = DateTime.Now.ToString("hh:mm:ss");

            var fechaParagraph = new Paragraph("FECHA: " + fecha + "\nHORA: " + hora);
            fechaParagraph.SetFontSize(10);
            fechaParagraph.SetFont(fechaFont);
            fechaParagraph.SetFontColor(ColorConstants.GREEN);

            PdfDocument pdfCopia = new PdfDocument(new PdfReader("Ventas.pdf"),
                new PdfWriter("VentasCopia.pdf"));

            Document documentCopia = new Document(pdfCopia);

            int paginasNumero = pdfCopia.GetNumberOfPages();
            
            for(int i = 1; i <= paginasNumero; i++)
            {
                PdfPage pagina = pdfCopia.GetPage(i);
                float posY = pagina.GetPageSize().GetTop()-20;
                documentCopia.ShowTextAligned(pLogo, 40, posY,i,TextAlignment.CENTER, VerticalAlignment.TOP,0);
                documentCopia.ShowTextAligned(titulo, (pagina.GetPageSize().GetWidth() / 2), posY,i, TextAlignment.CENTER, VerticalAlignment.TOP,0);
                documentCopia.ShowTextAligned(fechaParagraph,720-100, posY,i,TextAlignment.CENTER, VerticalAlignment.TOP,0);
                documentCopia.ShowTextAligned(new Paragraph(String.Format("Pagina {0}/{1}", i, paginasNumero)).SetFontSize(10), pagina.GetPageSize().GetWidth()/2,
                    pagina.GetPageSize().GetBottom() + 10, i, TextAlignment.CENTER, VerticalAlignment.BOTTOM,0);
            }

            documentCopia.Close();
        }

    }
}
