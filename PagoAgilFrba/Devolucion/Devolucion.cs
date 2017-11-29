using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

                if (string.IsNullOrWhiteSpace(idClienteTextBox.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", utils.convertirAValor(idClienteTextBox));

                sqlDa.SelectCommand.Parameters.AddWithValue("@mes", 0);

                DataTable dtbl = new DataTable();
                facturasDataGrid.DataSource = dtbl;
                sqlDa.Fill(dtbl);
                sqlCon.Close();
            }
        }

        private void agregarABtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturasDataGrid.CurrentRow == null) throw new Exception("Seleccione una factura de la tabla facturas pagadas");

                facturasADevolverDataGrid.ColumnHeadersVisible = true;
                var numFact = facturasDataGrid.CurrentRow.Cells["Num Fact"].Value;

                if (!numFactList.Contains(Convert.ToInt32(numFact)))
                {
                    facturasADevolverDataGrid.Rows.Add(new object[] {numFact,
                                    facturasDataGrid.CurrentRow.Cells["Empresa"].Value,
                                    facturasDataGrid.CurrentRow.Cells["Total"].Value,
                                    facturasDataGrid.CurrentRow.Cells["Fecha Alta"].Value,
                                    facturasDataGrid.CurrentRow.Cells["Fecha Venc"].Value
                                    });

                    numFactList.Add(Convert.ToInt32(numFact));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturasADevolverDataGrid.CurrentRow == null) throw new Exception("Seleccione una factura de la tabla Facturas a pagar");

                var numFact = facturasADevolverDataGrid.CurrentRow.Cells[0].Value;
                int index = numFactList.IndexOf(Convert.ToInt32(numFact));
                numFactList.RemoveAt(index);

                facturasADevolverDataGrid.Rows.Remove(facturasADevolverDataGrid.CurrentRow);

                if (!numFactList.Any()) facturasADevolverDataGrid.ColumnHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

    }
}
