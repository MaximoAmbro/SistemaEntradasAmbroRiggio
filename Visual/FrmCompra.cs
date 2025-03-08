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

namespace Visual
{
    public partial class FrmCompra : Form
    {
        public string NombreEvento { get; set; }
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
            lblPrecioA.Text = PrecioA;
            lblPrecioB.Text = PrecioB;
            lblPrecioC.Text = PrecioC;
        }
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            frmEventos frm = new frmEventos();
            frm.Show();
            this.Hide();
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            int cantidadA = Convert.ToInt32(NumPrimero.Text);
            int CantidadB = Convert.ToInt32(NumSegundo.Text);
            int CantidadC = Convert.ToInt32(NumTercero.Text);
            int CantidadTotal = cantidadA + CantidadB + CantidadC;
            GestorEntradas gestor = new GestorEntradas();
            gestor.RestarEntrada(NombreEvento, cantidadA, CantidadB, CantidadC, CantidadTotal);
            MessageBox.Show("Compra realizada con exito, capacidad disponible: " + gestor.TotalEntradas + " Revise documentos para recibir su entrada");
            GenerarTicket();
        }
        public void GenerarTicket()
        {
            GestorEntradas gestor = new GestorEntradas();
            int cantidadA = Convert.ToInt32(NumPrimero.Text);
            int CantidadB = Convert.ToInt32(NumSegundo.Text);
            int CantidadC = Convert.ToInt32(NumTercero.Text);
            int CantidadTickets = 0;
            int CantidadTotal = cantidadA + CantidadB + CantidadC;
            for (int i = 0; i < CantidadTotal; i++)
            {
                if (cantidadA > 0)
                {
                    gestor.GenerarTicket(NombreEvento, lblSectorA.Text);
                    string Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ticket.txt "+ CantidadTickets; ;
                    CantidadTickets++;
                    File.WriteAllText(Ruta, gestor.MensajeTicket);
                    cantidadA--;
                    CantidadTotal--;
                }
                if (CantidadB > 0)
                {
                    gestor.GenerarTicket(NombreEvento, lblSectorB.Text);
                    string Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ticket.txt " + CantidadTickets; ;
                    CantidadTickets++;
                    File.WriteAllText(Ruta, gestor.MensajeTicket);
                    CantidadB--;
                    CantidadTotal--;
                }
                if (CantidadC>0)
                {
                    gestor.GenerarTicket(NombreEvento, lblSectorC.Text);
                    string Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ticket.txt " + CantidadTickets; ;
                    CantidadTickets++; 
                    File.WriteAllText(Ruta, gestor.MensajeTicket);
                    CantidadC--;
                    CantidadTotal--;
                }
            }
        }
    }
}
