using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ABMClienteBtn_Click(object sender, EventArgs e)
        {
            AbmCliente.clienteABM clienteABM = new AbmCliente.clienteABM();
            clienteABM.ShowDialog();

        }

        private void ABMEmpresaBtn_Click(object sender, EventArgs e)
        {
            AbmEmpresa.empresaABM empresaABM = new AbmEmpresa.empresaABM();
            empresaABM.ShowDialog();
        }

        private void AbmSucursalBtn_Click(object sender, EventArgs e)
        {
            AbmSucursal.sucursalABM sucursalABM = new AbmSucursal.sucursalABM();
            sucursalABM.ShowDialog();
        }

        private void ABMFacturaBtn_Click(object sender, EventArgs e)
        {
            AbmFactura.facturaABM facturaABM = new AbmFactura.facturaABM();
            facturaABM.ShowDialog();
        }

        private void registarPagoBtn_Click(object sender, EventArgs e)
        {
            RegistroPago.RegistroPago registroPago = new RegistroPago.RegistroPago();
            registroPago.ShowDialog();
        }

        private void rendirFacturasBtn_Click(object sender, EventArgs e)
        {
            Rendicion.Rendicion rendicion = new Rendicion.Rendicion();
            rendicion.ShowDialog();
        }

        private void abmRolBtn_Click(object sender, EventArgs e)
        {
            AbmRol.rolABM rolABM = new AbmRol.rolABM();
            rolABM.ShowDialog();
        }

        private void devolverBtn_Click(object sender, EventArgs e)
        {
            Devolucion.Devolucion devolucion = new Devolucion.Devolucion();
            devolucion.ShowDialog();
        }
    }
}
