using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{
    public partial class facturaABM : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();
        private List<Item> itemsList = new List<Item>();

        public facturaABM()
        {
            InitializeComponent();
            llenarCombos();

        }

        public void llenarCombos()
        {
            List<KeyValuePair<int, string>> empresas = Utils.GetEmpresas();
            utils.llenar(empresaComboBox, empresas);
            utils.llenar(empresaComboBoxNF, empresas);
            utils.llenar(empresaFilterComboBox, empresas);

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (empresaComboBoxNF.SelectedIndex == -1) throw new Exception("Complete los campos obligatorios");
                if (itemsList.Count == 0) throw new Exception("Ingrese items");
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaCreateOrUpdate", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");

                    utils.validarYAgregarParam(sqlCmd, "@cliente", idClienteTextBox2NF);
                    sqlCmd.Parameters.AddWithValue("@Empresa", empresaComboBoxNF.SelectedIndex);

                    utils.validarYAgregarParam(sqlCmd, "@numeroFactura", numFactTextBoxNF);
                    sqlCmd.Parameters.AddWithValue("@fecha_alta", fechaAltaFactDT_NF.Value);

                    validarFechaVencimientoYAgregar(sqlCmd);

                    utils.validarImporteYAgregar(sqlCmd, "@total", totalTextBoxNF);

                    sqlCmd.ExecuteNonQuery();

                    SqlCommand sqlCmdItem;
                    int c = 0;
                    foreach (Item i in itemsList)
                    {
                        sqlCmdItem = new SqlCommand("GD2C2017.WEST_WORLD.ItemCreateOrUpdate", sqlCon);
                        sqlCmdItem.CommandType = CommandType.StoredProcedure;
                        sqlCmdItem.Parameters.AddWithValue("@mode", "Add");
                        sqlCmdItem.Parameters.AddWithValue("@idItem", 0);
                        sqlCmdItem.Parameters.AddWithValue("@monto", i.Monto);
                        sqlCmdItem.Parameters.AddWithValue("@cantidad", i.Cantidad);

                        utils.validarYAgregarParam(sqlCmdItem, "@numeroFactura", numFactTextBoxNF);

                        sqlCmdItem.ExecuteNonQuery();
                        c++;
                    }
                    MessageBox.Show("Factura creada");

                    if (sqlCon.State == ConnectionState.Open) sqlCon.Close();

                    numFactFilterTextBoxL.Text = numFactTextBoxNF.Text.Trim();
                    searchBtnL_Click(sender, e);
                    facturaTabControl.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;
                    if (sqlException.Number == 2627) MessageBox.Show("No pueden existir 2 facturas con el mismo numero-factura", "Error Message");
                    else if (sqlException.Number == 8114) MessageBox.Show("Complete los campos obligatorios", "Error Message");
                    else MessageBox.Show(ex.Message, "Mensaje de Error");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Mensaje de Error");
                }
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                actualizarFactura();

                numFactFilterTextBoxL.Text = numFactTextBox.Text.Trim();
                searchBtnL_Click(sender, e);
                facturaTabControl.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;
                    if (sqlException.Number == 8114) MessageBox.Show("Complete los campos obligatorios", "Error Message");
                    else MessageBox.Show(ex.Message, "Mensaje de Error");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Mensaje de Error");
                }
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        public void actualizarFactura()
        {
            if (empresaComboBox.SelectedIndex == -1) throw new Exception("Complete los campos obligatorios");

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaCreateOrUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Edit");

                utils.validarYAgregarParam(sqlCmd, "@cliente", idClienteTextBox2);
                sqlCmd.Parameters.AddWithValue("@Empresa", empresaComboBox.SelectedIndex);

                utils.validarYAgregarParam(sqlCmd, "@numeroFactura", numFactTextBox);
                sqlCmd.Parameters.AddWithValue("@fecha_alta", fechaAltaFactDT.Value);
                validarFechaVencimientoYAgregar(sqlCmd);

                utils.validarImporteYAgregar(sqlCmd, "@total", totalTextBox);

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Factura actualizada");

                sqlCon.Close();
            }
        }

        public void validarFechaVencimientoYAgregar(SqlCommand sqlCmd)
        {
            DateTime fechaVenc = Convert.ToDateTime(fechaVencDT.Value);
            if (fechaVenc.Date > DateTime.Now.Date) throw new Exception("La fecha de vencimiento no debe ser mayor a la fecha de hoy");
            else sqlCmd.Parameters.AddWithValue("@fecha_venc", fechaVencDT.Value);
        }

        private void agregarItemBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(montoTextBox.Text) | string.IsNullOrWhiteSpace(cantTextBox.Text)) throw new Exception("Debe ingresar Monto y Cantidad");

                if (agregarItemBtn.Text == "Agregar Item")
                {
                    insertarItem(sender, e);
                    fillDataGridViewItems();
                }
                else
                {
                    actualizarItem();
                    fillDataGridViewItems();
                }
                actualizarImporteDeFactura();
                actualizarFactura();
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;
                    MessageBox.Show(ex.Message, "Mensaje de Error");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        public void actualizarImporteDeFactura()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaImporteUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                utils.validarYAgregarParam(sqlCmd, "@numeroFactura", numFactTextBox);
                utils.validarImporteYAgregar(sqlCmd, "@total", totalTextBox);

                sqlCmd.ExecuteNonQuery();

                sqlCon.Close();
            }
        }

        void insertarItem(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemCreateOrUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@idItem", 0);

                utils.validarConvYAgregarParam(sqlCmd, "@monto", montoTextBox);
                utils.validarConvYAgregarParam(sqlCmd, "@cantidad", cantTextBox);

                if ((string.IsNullOrWhiteSpace(numFactTextBox.Text.Trim()))) throw new Exception("Ingrese un Numero de Factura");
                else sqlCmd.Parameters.AddWithValue("@numeroFactura", numFactTextBox.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Item creado");

                sqlCon.Close();
            }
        }


        private void actualizarItem()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemCreateOrUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                sqlCmd.Parameters.AddWithValue("@idItem", Convert.ToInt64(itemsDataGrid.CurrentRow.Cells[0].Value.ToString()));
                sqlCmd.Parameters.AddWithValue("@numeroFactura", Convert.ToInt64(numFactLabel2.Text.Trim()));

                utils.validarConvYAgregarParam(sqlCmd, "@monto", montoTextBox);
                utils.validarConvYAgregarParam(sqlCmd, "@cantidad", cantTextBox);

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Item actualizado");

                sqlCon.Close();
            }
        }

        private void fillDataGridViewItems()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.ItemView", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (string.IsNullOrWhiteSpace(numFactTextBox.Text.Trim())) throw new Exception("Ingrese un Numero de Factura para ver sus items");
                else sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", utils.convertirADecimal(numFactTextBox));

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                itemsDataGrid.DataSource = dtbl;

                totalTextBox.Text = utils.calcularColumna("importe", dtbl);
                numFactLabel2.Text = numFactTextBox.Text;

                sqlCon.Close();
            }
        }

        private void actualizarTablaItemsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridViewItems();
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

        private void limpiarBtn_Click_1(object sender, EventArgs e)
        {
            numFactTextBox.Text = fechaAltaFactDT.Text = idClienteTextBox2.Text = clienteTextBox2.Text
                  = fechaVencDT.Text = totalTextBox.Text = montoTextBox.Text = cantTextBox.Text = numFactLabel2.Text = "";
            empresaComboBox.SelectedIndex = -1;
            agregarItemBtn.Text = "Agregar Item";

            itemsDataGrid.DataSource = new DataTable();
        }

        private void itemsDataGrid_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (itemsDataGrid.CurrentRow.Index != -1)
            {
                montoTextBox.Text = itemsDataGrid.CurrentRow.Cells[1].Value.ToString();
                cantTextBox.Text = itemsDataGrid.CurrentRow.Cells[2].Value.ToString();
                numFactLabel2.Text = numFactTextBox.Text;

                agregarItemBtn.Text = "Actualizar Item";
            }
        }

        private void searchBtnL_Click(object sender, EventArgs e)
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

        private void fillDataGridViewFacturas()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.FacturaViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@estado", "Todas");

                if (string.IsNullOrWhiteSpace(numFactFilterTextBoxL.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", utils.convertirADecimal(numFactFilterTextBoxL));

                if (string.IsNullOrWhiteSpace(empresaFilterComboBox.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", empresaFilterComboBox.SelectedIndex);

                if (string.IsNullOrWhiteSpace(idClienteTextBox.Text)) sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", utils.convertirADecimal(idClienteTextBox));

                sqlDa.SelectCommand.Parameters.AddWithValue("@mes", 0);

                DataTable dtbl = new DataTable();

                sqlDa.Fill(dtbl);
                facturasDataGridL.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void facturasDataGridL_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(facturasDataGridL.CurrentRow.Cells[7].Value.ToString())))
                    throw new Exception("No se puede actualizar una factura pagada");

                if (facturasDataGridL.CurrentRow.Index != -1)
                {
                    numFactTextBox.Text = facturasDataGridL.CurrentRow.Cells[0].Value.ToString();
                    idClienteTextBox2.Text = facturasDataGridL.CurrentRow.Cells[1].Value.ToString();

                    if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandText = "SELECT nombre + ' ' + apellido FROM WEST_WORLD.Cliente WHERE idCliente = " + idClienteTextBox2.Text;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Connection = sqlCon;
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read()) clienteTextBox2.Text = reader.GetString(0);
                    sqlCon.Close();

                    empresaComboBox.SelectedIndex = Convert.ToInt32(facturasDataGridL.CurrentRow.Cells[2].Value.ToString());

                    fechaAltaFactDT.Text = facturasDataGridL.CurrentRow.Cells[3].Value.ToString();
                    fechaVencDT.Text = facturasDataGridL.CurrentRow.Cells[4].Value.ToString();
                    totalTextBox.Text = facturasDataGridL.CurrentRow.Cells[5].Value.ToString();

                    numFactLabel2.Text = numFactTextBox.Text;

                    facturaTabControl.SelectedIndex = 1;

                    actualizarTablaItemsBtn_Click(sender, e); //actualiza DataGridView items

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

        private void limpiarBtnL_Click(object sender, EventArgs e)
        {
            numFactFilterTextBoxL.Text = clienteTextBox.Text = idClienteTextBox.Text = "";
            empresaFilterComboBox.SelectedIndex = -1;

            facturasDataGridL.DataSource = new DataTable();
        }

        private void eliminarBtnL_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaDelete", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (facturasDataGridL.CurrentRow == null) throw new Exception("No se selecciono ninguna factura");
                    sqlCmd.Parameters.AddWithValue("@numerofactura", Convert.ToInt64(facturasDataGridL.CurrentRow.Cells[0].Value.ToString()));

                    int exitCode = sqlCmd.ExecuteNonQuery();
                    if (exitCode == -1) MessageBox.Show("No se puede eliminar una factura pagada");
                    else
                    {
                        MessageBox.Show("Factura " + facturasDataGridL.CurrentRow.Cells[0].Value.ToString() + " Eliminada");
                        facturasDataGridL.Rows.RemoveAt(facturasDataGridL.CurrentRow.Index);
                    }

                    if (sqlCon.State == ConnectionState.Open) sqlCon.Close();

                    searchBtnL_Click(sender, e);
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

        private void eliminarItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemDelete", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    if (itemsDataGrid.CurrentRow == null) throw new Exception("No se selecciono ningun Item");
                    sqlCmd.Parameters.AddWithValue("@numeroFactura", Convert.ToInt64(numFactLabel2.Text));
                    sqlCmd.Parameters.AddWithValue("@idItem", Convert.ToInt64(itemsDataGrid.CurrentRow.Cells[0].Value.ToString()));

                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Item " + itemsDataGrid.CurrentRow.Cells[0].Value.ToString() + " Eliminado");
                    itemsDataGrid.Rows.RemoveAt(itemsDataGrid.CurrentRow.Index);

                    sqlCon.Close();

                    actualizarTablaItemsBtn_Click(sender, e);
                    actualizarImporteDeFactura();
                    actualizarFactura();
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

        private void limpiarItemBtn_Click(object sender, EventArgs e)
        {
            montoTextBox.Text = cantTextBox.Text = "";
            agregarItemBtn.Text = "Agregar Item";
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

        private void seleccionarClienteBtn_Click_NF(object sender, EventArgs e)
        {
            BuscarCliente busquedaDeCliente = new BuscarCliente();
            busquedaDeCliente.ShowDialog();

            if (!string.IsNullOrWhiteSpace(busquedaDeCliente.clienteTextBox.Text) & !string.IsNullOrWhiteSpace(busquedaDeCliente.idClienteTextBox.Text))
            {
                idClienteTextBox2NF.Text = busquedaDeCliente.idClienteTextBox.Text;
                clienteTextBox2NF.Text = busquedaDeCliente.clienteTextBox.Text;
            }
        }

        private void seleccionarClienteBtn_Click_Actualizar(object sender, EventArgs e)
        {
            BuscarCliente busquedaDeCliente = new BuscarCliente();
            busquedaDeCliente.ShowDialog();

            if (!string.IsNullOrWhiteSpace(busquedaDeCliente.clienteTextBox.Text) & !string.IsNullOrWhiteSpace(busquedaDeCliente.idClienteTextBox.Text))
            {
                idClienteTextBox2.Text = busquedaDeCliente.idClienteTextBox.Text;
                clienteTextBox2.Text = busquedaDeCliente.clienteTextBox.Text;
            }
        }

        private void fechaVencDT_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaVenc = Convert.ToDateTime(fechaVencDT.Value);
            if (fechaVenc.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de vencimiento no debe ser mayor a la fecha de hoy", "Error Message");
                fechaVencDT.Value = Convert.ToDateTime(DateTime.Now.Date);
            }
        }

        private void agregarItemBtnNF_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(montoTextBoxNF.Text) | string.IsNullOrWhiteSpace(cantTextBoxNF.Text)) throw new Exception("Debe ingresar Monto y Cantidad");

                Item item = new Item(Math.Round(Convert.ToDecimal(montoTextBoxNF.Text), 2), Convert.ToInt16(cantTextBoxNF.Text));
                utils.validarMontoOCant(item.Monto, montoTextBoxNF);
                utils.validarMontoOCant(item.Cantidad, cantTextBoxNF);

                if (!itemsList.Any(x => x.Monto == item.Monto & x.Cantidad == item.Cantidad))
                {
                    itemsDataGridNF.Rows.Add(new object[] {item.Monto,
                                    item.Cantidad,
                                    item.Importe
                                    });

                    itemsList.Add(item);

                    totalTextBoxNF.Text = utils.calcularColumna(2, itemsDataGridNF);
                    if (!itemsDataGridNF.ColumnHeadersVisible) itemsDataGridNF.ColumnHeadersVisible = true;

                }
                else throw new Exception("Ya existe el item ingresado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void eliminarItemBtnNF_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemsDataGridNF.CurrentRow == null) throw new Exception("Seleccione un item a eliminar");

                Item item = new Item(Convert.ToDecimal(itemsDataGridNF.CurrentRow.Cells[0].Value), Convert.ToInt16(itemsDataGridNF.CurrentRow.Cells[1].Value));

                int index = itemsList.FindIndex(i => i.Cantidad == item.Cantidad & i.Monto == item.Monto);
                itemsList.RemoveAt(index);

                itemsDataGridNF.Rows.Remove(itemsDataGridNF.CurrentRow);

                if (!itemsList.Any()) itemsDataGridNF.ColumnHeadersVisible = false;

                totalTextBoxNF.Text = utils.calcularColumna(2, itemsDataGridNF);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void LimpiarNF_Click(object sender, EventArgs e)
        {
            numFactTextBoxNF.Text = idClienteTextBox2NF.Text = clienteTextBox2NF.Text = cantTextBoxNF.Text = montoTextBoxNF.Text =
                totalTextBoxNF.Text = fechaAltaFactDT_NF.Text = fechaVencDT_NF.Text = "";
            empresaComboBoxNF.SelectedIndex = -1;
            itemsDataGridNF.ColumnHeadersVisible = false;
            itemsDataGridNF.Rows.Clear();
            itemsList = new List<Item>();
        }

        private void limpiarItemBtnNF_Click(object sender, EventArgs e)
        {
            montoTextBoxNF.Text = cantTextBoxNF.Text = "";
        }

        private void numFactFilterTextBoxL_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

        private void numFactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

        private void cantTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

        private void cantTextBoxNF_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

        private void numFactTextBoxNF_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

        private void montoTextBoxNF_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoDecimal(e);
        }

        private void montoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoDecimal(e);
        }

        private void empresaFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empresaFilterComboBox.SelectedIndex == 0) empresaFilterComboBox.SelectedIndex = -1;
        }

        private void empresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empresaComboBox.SelectedIndex == 0) empresaComboBox.SelectedIndex = -1;
        }

        private void empresaComboBoxNF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empresaComboBoxNF.SelectedIndex == 0) empresaComboBoxNF.SelectedIndex = -1;
        }

    }
}
