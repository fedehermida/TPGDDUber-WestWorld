using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class ListadoEstadistico : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);

        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            trimestreComboBox.SelectedIndex = -1;
            anioTextBox.Text = "";
            porcentajeRadioBtn.Checked = empresasRadioBtn.Checked = clientesRadioBtn.Checked = clientesCumplidoresRadioBtn.Checked = false;
            listadoDataGridView.DataSource = new DataTable();
        }

        private void listarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(anioTextBox.Text.Trim()) | trimestreComboBox.SelectedIndex == -1) throw new Exception("Seleccione un trimestre y un año");
                fillDataGridViewListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        private void fillDataGridViewListado()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                string procedure = "";
                if (porcentajeRadioBtn.Checked) procedure = "GD2C2017.WEST_WORLD.FacturasCobradasPorEmpresa";
                else if (empresasRadioBtn.Checked) procedure = "GD2C2017.WEST_WORLD.EmpresasConMayorMontoRendido";
                else if (clientesRadioBtn.Checked) procedure = "GD2C2017.WEST_WORLD.ClientesConMasPagos";
                else if (clientesCumplidoresRadioBtn.Checked) procedure = "GD2C2017.WEST_WORLD.ClientesCumplidores";

                if (procedure == "") throw new Exception("Seleccione un listado a mostrar");

                sqlCon.Open();
                SqlDataAdapter sqlDaFacturas = new SqlDataAdapter(procedure, sqlCon);
                sqlDaFacturas.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDaFacturas.SelectCommand.Parameters.AddWithValue("@anio", Convert.ToInt32(anioTextBox.Text));
                sqlDaFacturas.SelectCommand.Parameters.AddWithValue("@trimestre", trimestreComboBox.SelectedIndex);

                DataTable dtbl = new DataTable();
                sqlDaFacturas.Fill(dtbl);
                listadoDataGridView.DataSource = dtbl;

                sqlCon.Close();
            }
        }

        private void trimestreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trimestreComboBox.SelectedIndex == 0) trimestreComboBox.SelectedIndex = -1;
        }

        private void anioTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            Utils utils = new Utils();
            utils.validarCampoNumerico(e);
        }
    }
}
