using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PagoAgilFrba.AbmCliente
{
    public partial class clienteABM : Form
    {
        SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        Utils utils = new Utils();

        public clienteABM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    if (guardarBtn.Text == "Guardar")
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ClienteCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@idCliente", 0);
                        sqlCmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@apellido", apellidoTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@mail", mailTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@codigoPostal", codigoPostalTxtBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@dni", dniTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@telefono", telefonoTxtBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@fec_nac", fechaNacimientoTime.Value);
                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente creado");

                        if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                        
                        searchButton_Click(sender, e);

                    }
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ClienteCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlCmd.Parameters.AddWithValue("@idCliente", Convert.ToInt32(clienteDataGrid.CurrentRow.Cells[0].Value.ToString()));
                        sqlCmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@apellido", apellidoTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@mail", mailTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@codigoPostal", codigoPostalTxtBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@dni", dniTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@telefono", telefonoTxtBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@fec_nac", fechaNacimientoTime.Value);
                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente modificado correctamente");

                        if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                        dniFilterTxt.Text = dniTextBox.Text;
                        limpiarCamposObligatorios();
                        guardarBtn.Text = "Guardar";
                        searchButton_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;

                    if (sqlException.Number == 2627) MessageBox.Show("No pueden existir 2 clientes con el mismo mail", "Error Message");
                    else if (sqlException.Number == 8114) MessageBox.Show("Todos los campos son obligatorios", "Error Message");
                    else MessageBox.Show(ex.Message, "Mensaje de Error");

                }
                else
                {
                    MessageBox.Show(ex.Message, "Mensaje de Error");
                }
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        void fillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.ClienteViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@nombre", nombreFilterTxt.Text.Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@apellido", apellidoFilterTxt.Text.Trim());
                String dniFiltertxt = dniFilterTxt.Text.Trim();
                if (string.IsNullOrWhiteSpace(dniFiltertxt))
                {
                    sqlDa.SelectCommand.Parameters.AddWithValue("@dni", DBNull.Value);
                }
                else sqlDa.SelectCommand.Parameters.AddWithValue("@dni", utils.convertirABigInt(dniFilterTxt));
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                clienteDataGrid.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        private void clienteDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (clienteDataGrid.CurrentRow.Index != -1)
            {
                nombreTextBox.Text = clienteDataGrid.CurrentRow.Cells[1].Value.ToString();
                apellidoTextBox.Text = clienteDataGrid.CurrentRow.Cells[2].Value.ToString();
                mailTextBox.Text = clienteDataGrid.CurrentRow.Cells[3].Value.ToString();
                direccionTextBox.Text = clienteDataGrid.CurrentRow.Cells[4].Value.ToString();
                codigoPostalTxtBox.Text = clienteDataGrid.CurrentRow.Cells[5].Value.ToString();
                dniTextBox.Text = clienteDataGrid.CurrentRow.Cells[6].Value.ToString();
                telefonoTxtBox.Text = clienteDataGrid.CurrentRow.Cells[7].Value.ToString();
                fechaNacimientoTime.Text = clienteDataGrid.CurrentRow.Cells[8].Value.ToString();
                habilitadoCheck.Checked = (bool)clienteDataGrid.CurrentRow.Cells[9].Value;
                guardarBtn.Text = "Actualizar";
            }
        }

        void reset()
        {
            limpiarCamposObligatorios();

            nombreFilterTxt.Text = apellidoFilterTxt.Text = dniFilterTxt.Text = "";

            guardarBtn.Text = "Guardar";

            clienteDataGrid.DataSource = new DataTable();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void limpiarCamposObligatorios()
        {
            nombreTextBox.Text = apellidoTextBox.Text = mailTextBox.Text = direccionTextBox.Text =
                codigoPostalTxtBox.Text = dniTextBox.Text = telefonoTxtBox.Text = fechaNacimientoTime.Text = "";
            habilitadoCheck.Checked = false;
        }

        private void dniFilterTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils utils = new Utils();
            utils.validarCampoNumerico(e);
        }

        private void dniTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

        private void telefonoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

        private void clienteABM_Activated(object sender, EventArgs e)
        {
            searchButton.Focus();
        }
    }
}
