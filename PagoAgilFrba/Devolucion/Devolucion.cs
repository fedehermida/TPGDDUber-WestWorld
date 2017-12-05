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
                //limpiarTablaFacturasADevolver();
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
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", empresaComboBox.SelectedIndex);

                if (string.IsNullOrWhiteSpace(numFactFilterTextBoxL.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", utils.convertirABigInt(numFactFilterTextBoxL));

                if (string.IsNullOrWhiteSpace(idClienteTextBox.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", utils.convertirABigInt(idClienteTextBox));

                sqlDa.SelectCommand.Parameters.AddWithValue("@mes", 0);
                sqlDa.SelectCommand.Parameters.AddWithValue("@anio", 0);

                DataTable dtbl = new DataTable();
                facturasDataGrid.DataSource = dtbl;
                sqlDa.Fill(dtbl);
                sqlCon.Close();
            }
        }

        private void limpiarTablaFacturasADevolver()
        {
            facturasADevolverDataGrid.ColumnHeadersVisible = false;
            facturasADevolverDataGrid.Rows.Clear();
            numFactList = new List<int>();
            facturasADevolverDataGrid.Text = 0.ToString();
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
                else 
                    throw new Exception("Ya existe la factura seleccionada en la tabla facturas a devolver");
                if (!devolverBtn.Enabled) devolverBtn.Enabled = true;
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

                if (!numFactList.Any())
                {
                    facturasADevolverDataGrid.ColumnHeadersVisible = false;
                    devolverBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void limpiarDevBtn_Click(object sender, EventArgs e)
        {
            motivoTextBox.Text = "";
        }

        private void empresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(empresaComboBox.SelectedIndex == 0) empresaComboBox.SelectedIndex = -1;
        }

        private void seleccionarClienteBtn_Click(object sender, EventArgs e)
        {
            BuscarCliente busquedaDeCliente = new BuscarCliente();
            busquedaDeCliente.ShowDialog();

            if (!string.IsNullOrWhiteSpace(busquedaDeCliente.clienteTextBox.Text) & !string.IsNullOrWhiteSpace(busquedaDeCliente.idClienteTextBox.Text))
            {
                idClienteTextBox.Text = busquedaDeCliente.idClienteTextBox.Text;
                clienteTextBox.Text = busquedaDeCliente.clienteTextBox.Text;
            }
        }

        private void numFactFilterTextBoxL_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

        private void Devolucion_Activated(object sender, EventArgs e)
        {
            searchBtn.Focus();
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            limpiarDevBtn_Click(sender, e);
            limpiarTablaFacturasADevolver();
            DataTable dtbl = new DataTable();
            facturasDataGrid.DataSource = dtbl;
            numFactFilterTextBoxL.Text = idClienteTextBox.Text = clienteTextBox.Text = "";
            empresaComboBox.SelectedIndex = -1;
            devolverBtn.Enabled = false;
        }

        private void devolverBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                foreach (int numFact in numFactList)
                {
                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.DevolucionDeFactura", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@numeroFactura", numFact);
                    utils.validarYAgregarParam(sqlCmd, "@motivo", motivoTextBox);

                    sqlCmd.ExecuteNonQuery();
                }
                sqlCon.Close();

                searchBtn_Click(sender, e);
                limpiarTablaFacturasADevolver();
                devolverBtn.Enabled = false;
                MessageBox.Show("Se efectuo la devolucion de las facturas seleccionadas", "Mensaje");
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

     

    }
}
