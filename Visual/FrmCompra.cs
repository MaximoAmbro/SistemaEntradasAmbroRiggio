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

namespace Visual
{
    public partial class FrmCompra : Form
    {
        GestorEntradas gestorE = new GestorEntradas();
        GestorClientes gestorC = new GestorClientes();
        public string NombreEvento { get; set; }
        public string NombreUsuario { get; set; }
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
            MessageBox.Show("Compra realizada con exito, capacidad disponible: " + gestorE.TotalEntradas + " Revise documentos para recibir su entrada");
        }
        public void GenerarTicket()
        {
            int cantidadA = Convert.ToInt32(NumPrimero.Text);
            int CantidadB = Convert.ToInt32(NumSegundo.Text);
            int CantidadC = Convert.ToInt32(NumTercero.Text);
            int CantidadTickets = 0;
            int CantidadTotal = cantidadA + CantidadB + CantidadC;
            for (int i = 0; i <= CantidadTotal; i++)
            {
                if (cantidadA > 0)
                {
                    gestorE.GenerarTicket(NombreEvento, lblSectorA.Text);
                    string Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ticket.txt "+ NombreEvento+ lblSectorA.Text+ CantidadTickets; ;
                    CantidadTickets++;
                    File.WriteAllText(Ruta, gestorE.MensajeTicket);
                    cantidadA--;
                    CantidadTotal--;
                }
                if (CantidadB > 0)
                {
                    gestorE.GenerarTicket(NombreEvento, lblSectorB.Text);
                    string Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ticket.txt " + NombreEvento + lblSectorB.Text + CantidadTickets; ; ;
                    CantidadTickets++;
                    File.WriteAllText(Ruta, gestorE.MensajeTicket);
                    CantidadB--;
                    CantidadTotal--;
                }
                if (CantidadC>0)
                {
                    gestorE.GenerarTicket(NombreEvento, lblSectorC.Text);
                    string Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ticket.txt " + NombreEvento + lblSectorC.Text + CantidadTickets; ;
                    CantidadTickets++; 
                    File.WriteAllText(Ruta, gestorE.MensajeTicket);
                    CantidadC--;
                    CantidadTotal--;
                }
            }
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
