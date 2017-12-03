using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class empresaABM : Form

    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();

        public empresaABM()
        {
            InitializeComponent();
            llenarCombosRubro();
        }

        public void llenarCombosRubro()
        {
            List<KeyValuePair<int, string>> rubros = Utils.GetRubros();
            utils.llenar(rubroComboBox, rubros);
            utils.llenar(rubroFilterComboBox, rubros);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    if (btnGuardar.Text == "Guardar")
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.EmpresaCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@idEmpresa", 0);

                        utils.validarYAgregarParam(sqlCmd, "@nombre", nombreTextBox);
                        utils.validarYAgregarParam(sqlCmd, "@cuit", cuitTextBox);
                        utils.validarYAgregarParam(sqlCmd, "@direccion", direccionTextBox);

                        if (rubroComboBox.SelectedIndex == -1) throw new Exception("Complete los campos obligatorios");
                        else sqlCmd.Parameters.AddWithValue("@idRubro", rubroComboBox.SelectedIndex);

                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);

                        Byte dia = Byte.Parse(diaRendicionTextBox.Text.Trim());
                        if ((string.IsNullOrWhiteSpace(diaRendicionTextBox.Text.Trim()))) throw new Exception("Complete los campos obligatorios");
                        else if(dia<=0 | dia >28) throw new Exception("Ingrese un dia de rendición entre 1 y 28");
                        else sqlCmd.Parameters.AddWithValue("@diaRendicion", dia);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Empresa creada");

                        if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                        btnBuscar_Click_1(sender, e);
                    }
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.EmpresaCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");

                        sqlCmd.Parameters.AddWithValue("@idEmpresa", Convert.ToInt32(empresaDataGrid.CurrentRow.Cells[0].Value.ToString()));
                        utils.validarYAgregarParam(sqlCmd, "@nombre", nombreTextBox);
                        utils.validarYAgregarParam(sqlCmd, "@cuit", cuitTextBox);
                        utils.validarYAgregarParam(sqlCmd, "@direccion", direccionTextBox);

                        if (rubroComboBox.SelectedIndex == -1) throw new Exception("Complete los campos obligatorios");
                        else sqlCmd.Parameters.AddWithValue("@idRubro", rubroComboBox.SelectedIndex);
                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);

                        Byte dia = Byte.Parse(diaRendicionTextBox.Text.Trim());
                        if ((string.IsNullOrWhiteSpace(diaRendicionTextBox.Text.Trim()))) throw new Exception("Complete los campos obligatorios");
                        else if (dia <= 0 | dia > 28) throw new Exception("Ingrese un dia de rendición entre 1 y 28");
                        else sqlCmd.Parameters.AddWithValue("@diaRendicion", dia);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Empresa modificada correctamente");
                        if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                        cuitFilter.Text = cuitTextBox.Text;
                        limpiarCamposObligatorios();
                        btnGuardar.Text = "Guardar";
                        btnBuscar_Click_1(sender, e);


                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;
                    if (sqlException.Number == 2627) MessageBox.Show("No pueden existir 2 empresas con el mismo cuit", "Error Message");
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
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        private void empresaDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (empresaDataGrid.CurrentRow.Index != -1)
            {
                cuitTextBox.Text = empresaDataGrid.CurrentRow.Cells[1].Value.ToString();
                nombreTextBox.Text = empresaDataGrid.CurrentRow.Cells[2].Value.ToString();
                direccionTextBox.Text = empresaDataGrid.CurrentRow.Cells[3].Value.ToString();
                rubroComboBox.SelectedIndex = Convert.ToInt32(empresaDataGrid.CurrentRow.Cells[4].Value.ToString());
                habilitadoCheck.Checked = (bool)empresaDataGrid.CurrentRow.Cells[5].Value;
                diaRendicionTextBox.Text = empresaDataGrid.CurrentRow.Cells[6].Value.ToString();

                btnGuardar.Text = "Actualizar";
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
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
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        void fillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.EmpresaViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@nombre", nombreFilterTextBox.Text.Trim());

                utils.validarYAgregarParam(sqlDa, "@cuit", cuitFilter);
                
                if (rubroFilterComboBox.SelectedIndex == -1)
                    sqlDa.SelectCommand.Parameters.AddWithValue("@idRubro", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idRubro", rubroFilterComboBox.SelectedIndex);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                empresaDataGrid.DataSource = dtbl;
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        private void rubroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rubroComboBox.SelectedIndex == 0) rubroComboBox.SelectedIndex = -1;
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            limpiarCamposObligatorios();
            nombreFilterTextBox.Text = cuitFilter.Text = "";
            rubroFilterComboBox.SelectedIndex = -1;


            btnGuardar.Text = "Guardar";

            empresaDataGrid.DataSource = new DataTable();
        }

        private void limpiarCamposObligatorios()
        {
            nombreTextBox.Text = direccionTextBox.Text = cuitTextBox.Text = diaRendicionTextBox.Text = "";
            rubroComboBox.SelectedIndex = -1;
            habilitadoCheck.Checked = false;
        }

        private void rubroFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rubroFilterComboBox.SelectedIndex == 0) rubroFilterComboBox.SelectedIndex = -1;
        }

        private void diaRendicionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoNumerico(e);
        }

        private void empresaABM_Activated(object sender, EventArgs e)
        {
            btnBuscar.Focus();
        }


    }
}
