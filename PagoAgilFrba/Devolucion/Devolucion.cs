using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PagoAgilFrba.Devolucion
{
    public partial class Devolucion : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();
        private List<int> numFactList = new List<int>();

        public Devolucion()
        {
            InitializeComponent();
            List<KeyValuePair<int, string>> empresas = Utils.GetEmpresas();
            utils.llenar(empresaComboBox, empresas);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
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

                if (string.IsNullOrWhiteSpace(empresaComboBox.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", empresaComboBox.SelectedIndex + 1);

                if (string.IsNullOrWhiteSpace(numFactFilterTextBoxL.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", utils.convertirAValor(numFactFilterTextBoxL));

                if (string.IsNullOrWhiteSpace(idClienteTextBox.Text)) sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", utils.convertirAValor(idClienteTextBox));

                sqlDa.SelectCommand.Parameters.AddWithValue("@mes", 0);

                DataTable dtbl = new DataTable();
                facturasDataGrid.DataSource = dtbl;
                sqlDa.Fill(dtbl);
                sqlCon.Close();
            }
        }

    }
}
