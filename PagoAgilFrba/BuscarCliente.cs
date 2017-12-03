using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoAgilFrba
{
    public partial class BuscarCliente : Form
    {
        SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        Utils utils = new Utils();

        public BuscarCliente()
        {
            InitializeComponent();
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

        private void fillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.SeleccionarCliente", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDa.SelectCommand.Parameters.AddWithValue("@nombre", nombreFilterTxt.Text.Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@apellido", apellidoFilterTxt.Text.Trim());

                String dniText = dniFilterTextBox.Text.Trim();
                if (dniText == "") sqlDa.SelectCommand.Parameters.AddWithValue("@dni", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@dni", dniText);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                clienteDataGridView.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void clienteDataGridView_Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            if (clienteDataGridView.CurrentRow == null) return;

            DataGridViewRow row = clienteDataGridView.CurrentRow;
            idClienteTextBox.Text = row.Cells[0].Value.ToString();
            clienteTextBox.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clienteTextBox.Text) & string.IsNullOrWhiteSpace(idClienteTextBox.Text)) MessageBox.Show("Debe seleccionar un cliente");
            else this.Close();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            idClienteTextBox.Text = clienteTextBox.Text = "";
            this.Close();
        }

        private void dniFilterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

    }
}
