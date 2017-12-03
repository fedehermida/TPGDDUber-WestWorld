using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PagoAgilFrba.RegistroPago
{
    public partial class RegistroPago : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();
        private List<int> numFactList = new List<int>();

        public RegistroPago()
        {
            InitializeComponent();
            utils.llenar(empresaFilterComboBox, Utils.GetEmpresas());
            utils.llenar(formaPagoComboBox, Utils.GetFormasDePago());
            sucursalTextBox.Text = 1.ToString();//TODO sucursal harcodeada. el idSucursal sale del operador -> Usuario logueado
            importeCobroTextBox.Text = 0.ToString();

        }


        public void searchBtnL_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(clienteTextBox.Text) & string.IsNullOrWhiteSpace(idClienteTextBox.Text)) throw new Exception("Debe seleccionar un cliente");

                fillDataGridViewFacturas();
                limpiarTablaFacturasACobrar();
                clienteTxt.Text = clienteTextBox.Text;
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

        private void fillDataGridViewFacturas()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.FacturaViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@estado", "Sin Pago");

                if (string.IsNullOrWhiteSpace(numFactFilterTextBoxL.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", utils.convertirABigInt(numFactFilterTextBoxL));

                if (string.IsNullOrWhiteSpace(empresaFilterComboBox.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", empresaFilterComboBox.SelectedIndex);

                if (string.IsNullOrWhiteSpace(idClienteTextBox.Text)) sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", utils.convertirABigInt(idClienteTextBox));

                sqlDa.SelectCommand.Parameters.AddWithValue("@mes", 0);

                

                DataTable dtbl = new DataTable();

                sqlDa.Fill(dtbl);
                facturasDataGridL.DataSource = dtbl;
                
                sqlCon.Close();
            }
        }

        private int cobrar()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.PagoCreate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                utils.validarYAgregarParam(sqlCmd, "@idCliente", idClienteTextBox);

                utils.validarImporteYAgregar(sqlCmd, "@importe", importeCobroTextBox);

                utils.validarYAgregarParam(sqlCmd, "@idSucursal", sucursalTextBox);
                sqlCmd.Parameters.AddWithValue("@fechaCobro", DateTime.Now);
                if (string.IsNullOrWhiteSpace(formaPagoComboBox.Text)) throw new Exception("Seleccione una forma de pago");
                sqlCmd.Parameters.AddWithValue("@idFormaDePago", formaPagoComboBox.SelectedIndex);

                int idPago = -1;
                var returnParameter = sqlCmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                sqlCmd.ExecuteNonQuery();
                idPago = Convert.ToInt32(returnParameter.Value);

                MessageBox.Show("Se registró el pago " + idPago.ToString() + " correctamente");
                sqlCon.Close();
                return idPago;
            }
            return -1;
        }


        private void cobrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idPago = cobrar();
                if (idPago == -1) throw new Exception("No se pudo registrar el pago");
                sqlCon.Open();
                foreach (int numFact in numFactList)
                {
                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaAsignarPago", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@numFactura", numFact);
                    sqlCmd.Parameters.AddWithValue("@pago", idPago);

                    sqlCmd.ExecuteNonQuery();
                }

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

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            limpiarFiltrosBtn_Click(sender, e);

            fechaCobroDT.Value = Convert.ToDateTime(DateTime.Now.Date);

            facturasDataGridL.DataSource = new DataTable();

            limpiarTablaFacturasACobrar();
        }

        private void limpiarTablaFacturasACobrar()
        {
            facturasACobrarDataGrid.ColumnHeadersVisible = false;
            facturasACobrarDataGrid.Rows.Clear();
            numFactList = new List<int>();
            importeCobroTextBox.Text = 0.ToString();
        }

        private void limpiarFiltrosBtn_Click(object sender, EventArgs e)
        {
            numFactFilterTextBoxL.Text = clienteTextBox.Text = idClienteTextBox.Text = clienteTxt.Text = "";
            empresaFilterComboBox.SelectedIndex = -1;

            facturasDataGridL.DataSource = new DataTable();
            limpiarTablaFacturasACobrar();
        }

        private void agregarABtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturasDataGridL.CurrentRow == null) throw new Exception("Seleccione una factura de la tabla Facturas sin pago");

                facturasACobrarDataGrid.ColumnHeadersVisible = true;
                var numFact = facturasDataGridL.CurrentRow.Cells["Num Fact"].Value;

                if (!numFactList.Contains(Convert.ToInt32(numFact)))
                {
                    facturasACobrarDataGrid.Rows.Add(new object[] {numFact,
                                    facturasDataGridL.CurrentRow.Cells["Empresa"].Value,
                                    facturasDataGridL.CurrentRow.Cells["Total"].Value,
                                    facturasDataGridL.CurrentRow.Cells["Fecha Alta"].Value,
                                    facturasDataGridL.CurrentRow.Cells["Fecha Venc"].Value
                                    });

                    numFactList.Add(Convert.ToInt32(numFact));

                    importeCobroTextBox.Text = utils.calcularColumna(2, facturasACobrarDataGrid);
                }
                else
                    throw new Exception("Ya existe la factura seleccionada en la tabla facturas a pagar");
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
                if (facturasACobrarDataGrid.CurrentRow == null) throw new Exception("Seleccione una factura de la tabla Facturas a pagar");

                var numFact = facturasACobrarDataGrid.CurrentRow.Cells[0].Value;
                int index = numFactList.IndexOf(Convert.ToInt32(numFact));
                numFactList.RemoveAt(index);

                facturasACobrarDataGrid.Rows.Remove(facturasACobrarDataGrid.CurrentRow);

                if (!numFactList.Any()) facturasACobrarDataGrid.ColumnHeadersVisible = false;

                importeCobroTextBox.Text = utils.calcularColumna(2, facturasACobrarDataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void empresaFilterComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (empresaFilterComboBox.SelectedIndex == 0) empresaFilterComboBox.SelectedIndex = -1;
        }

        private void formaPagoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formaPagoComboBox.SelectedIndex == 0) formaPagoComboBox.SelectedIndex = -1;
        }

        private void numFactFilterTextBoxL_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

        private void RegistroPago_Activated(object sender, EventArgs e)
        {
            seleccionarClienteBtn.Focus();
        } 

    }
}
