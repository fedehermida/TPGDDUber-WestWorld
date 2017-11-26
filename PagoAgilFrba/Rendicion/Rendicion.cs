using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Rendicion
{
    public partial class Rendicion : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();

        public Rendicion()
        {
            InitializeComponent();
            List<KeyValuePair<int, string>> empresas = Utils.GetEmpresas();
            utils.llenar(empresaFilterComboBox, empresas);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(empresaFilterComboBox.Text)) throw new Exception("Debe seleccionar una empresa");
                fillDataGridViewFacturas();
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
        public void fillDataGridViewFacturas()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.FacturaViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@estado", "Con Pago Y Sin Rendicion");

                if (string.IsNullOrWhiteSpace(empresaFilterComboBox.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", empresaFilterComboBox.SelectedIndex + 1);

                sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", 0);
                sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", 0);

                DataTable dtbl = new DataTable();
                facturasDataGrid.DataSource = dtbl;
                sqlDa.Fill(dtbl);
                sqlCon.Close();

                cantFactTextBox.Text = facturasDataGrid.RowCount.ToString();
                empresaTextBox.Text = empresaFilterComboBox.Text;
            }
        }

        private void limpiarRendBtn_Click(object sender, EventArgs e)
        {
            cantFactTextBox.Text = empresaTextBox.Text = importeNetoTextBox.Text = importeTotalTextBox.Text = 
                conjuntoFactTextBox.Text = porcentajeComisionTextBox.Text = "";
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            limpiarRendBtn_Click(sender, e);
            facturasDataGrid.DataSource = new DataTable();
            empresaFilterComboBox.Text = "";
        }
    }
}
