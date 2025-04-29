using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;
using iText;
using iText.IO.Image;
using iText.Kernel;
using iText.Layout;
using iText.Layout.Properties;
using iText.Layout.Element;
using QRCoder;
using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using iText.Layout.Element;

namespace Visual
{
    public partial class FrmCompra : Form
    {
        public string NombreEvento { get; set; }
        public string NombreUsuario { get; set; }
        GestorEntradas gestorE = new GestorEntradas();
        GestorClientes gestorC = GestorClientes.Instance;
        public FrmCompra()
        {
            frmEventos frm = new frmEventos();

            InitializeComponent();
        }
        private void FrmCompra_Load(object sender, EventArgs e)
        {
            label1.Text = NombreEvento;
            string SectorA, SectorB, SectorC, PrecioA, PrecioB, PrecioC;
            GestorEntradas gestor = new GestorEntradas();
            gestor.BuscarLista(NombreEvento);
            SectorA = gestor.SectorA.ToString();
            SectorB = gestor.SectorB.ToString();
            SectorC = gestor.SectorC.ToString();
            PrecioA = gestor.PrecioA.ToString();
            PrecioB = gestor.PrecioB.ToString();
            PrecioC = gestor.PrecioC.ToString();
            lblSectorA.Text = SectorA;
            lblSectorB.Text = SectorB;
            lblSectorC.Text = SectorC;
            lblPrecioA.Text = PrecioA + "$";
            lblPrecioB.Text = PrecioB + "$";
            lblPrecioC.Text = PrecioC + "$";
        }
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            frmEventos frm = new frmEventos();
            frm.NombreUsuario= NombreUsuario;
            frm.Show();
            this.Hide();
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            int cantidadA = Convert.ToInt32(NumPrimero.Text);
            int CantidadB = Convert.ToInt32(NumSegundo.Text);
            int CantidadC = Convert.ToInt32(NumTercero.Text);
            int CantidadTotal = cantidadA + CantidadB + CantidadC;
            gestorE.RestarEntrada(NombreEvento, cantidadA, CantidadB, CantidadC, CantidadTotal);
            CargarEntrada();
            GenerarTicket();
            MessageBox.Show("Compra realizada con exito,"+ "revise documentos para recibir su entrada");
        }
        public void GenerarTicket()
        {
            GestorEntradas gestor = new GestorEntradas();
            int cantidadA = Convert.ToInt32(NumPrimero.Text);
            int CantidadB = Convert.ToInt32(NumSegundo.Text);
            int CantidadC = Convert.ToInt32(NumTercero.Text);
            int CantidadTickets = 0;
            int CantidadTotal = cantidadA + CantidadB + CantidadC;
            string carpetaTickets = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\A1.Tickets EVENTAURA";
            if (!Directory.Exists(carpetaTickets))
            {
                Directory.CreateDirectory(carpetaTickets);
            }

            for (int i = 0; i <= CantidadTotal; i++)
            {
                if (cantidadA > 0)
                {
                    gestor.GenerarTicket(NombreEvento, lblSectorA.Text);
                    string Ruta = System.IO.Path.Combine(carpetaTickets, $"Ticket_{NombreEvento}_{lblSectorA.Text}_{CantidadTickets}.PDF" );
                    CantidadTickets++;
                    GenerarPDF(Ruta, gestor.MensajeTicket, gestor.QRCodeImage);
                    cantidadA--;
                    CantidadTotal--;
                }
                if (CantidadB > 0)
                {
                    gestor.GenerarTicket(NombreEvento, lblSectorB.Text);
                    string Ruta = System.IO.Path.Combine(carpetaTickets, $"Ticket_{NombreEvento}_{lblSectorB.Text}_{CantidadTickets}.PDF");
                    CantidadTickets++;
                    GenerarPDF(Ruta, gestor.MensajeTicket, gestor.QRCodeImage);
                    CantidadB--;
                    CantidadTotal--;
                }
                if (CantidadC>0)
                {
                    gestor.GenerarTicket(NombreEvento, lblSectorC.Text);
                    string Ruta =  System.IO.Path.Combine(carpetaTickets, $"Ticket_{NombreEvento}_{lblSectorC.Text}_{CantidadTickets}.PDF");
                    CantidadTickets++;
                    GenerarPDF(Ruta, gestor.MensajeTicket, gestor.QRCodeImage);
                    CantidadC--;
                    CantidadTotal--;
                }
            }
        }
        public void GenerarPDF(string ruta, string mensaje, byte[] QR )
        {
           PdfWriter pw = new PdfWriter(ruta);
           PdfDocument pdf = new PdfDocument(pw);
           Document doc = new Document(pdf, PageSize.DEFAULT);
           doc.Add(new Paragraph(mensaje));
           var img = new iText.Layout.Element.Image(ImageDataFactory.Create(QR));
           img.ScaleAbsolute(100, 100);
           doc.Add(img);
           doc.Close();
        }
        public void CargarEntrada()
        {
            List<Evento> listaEventos = gestorE.ObtenerListaEventos();

            foreach (Evento _evento in listaEventos)
            {
                if (_evento.Nombre == NombreEvento)
                {
                    gestorC.AgregarEntrada(_evento, NombreUsuario);
                    break;
                }
            }
        }
    }
}
