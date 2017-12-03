using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmRol
{
    public partial class rolABM : Form
    {
        private List<int> funcionalidades = new List<int>();
        List<KeyValuePair<int, string>> funcionalidadesKeyValue;

        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();

        public rolABM()
        {
            InitializeComponent();
            llenarListaFuncionalidades();
        }


        public void llenarListaFuncionalidades()
        {
            funcionalidadesKeyValue = Utils.GetFuncionalidades();
            utils.llenar(funcionalidadesComboBox, funcionalidadesKeyValue);
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            try
            {
                if (crearOrUpdateBtn.Text == "Crear")
                {
                    if (string.IsNullOrWhiteSpace(rolTextBox.Text.Trim())) throw new Exception("Ingrese un nombre de Rol");
                    if (funcionalidades.Count == 0) throw new Exception("Debe agregar funcionadidades");
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("WEST_WORLD.CreateOrUpdateRol", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    utils.validarYAgregarParam(sqlCmd, "@nombre", rolTextBox);
                    sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheckBox.Checked);

                    var returnParameter = sqlCmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    sqlCmd.ExecuteNonQuery();

                    int idRol = -1;
                    idRol = Convert.ToInt32(returnParameter.Value);

                    foreach (int id in funcionalidades)
                    {
                        SqlCommand sqlCom = new SqlCommand("WEST_WORLD.AgregarFuncionalidad", sqlCon);
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.Parameters.AddWithValue("@idRol", idRol);
                        sqlCom.Parameters.AddWithValue("@idFuncionalidad", id);
                        sqlCom.ExecuteNonQuery();
                    }

                    sqlCon.Close();
                    MessageBox.Show("Rol creado correctamente");
                }
                else
                {
                    sqlCon.Open();

                    SqlCommand sqlCom2 = new SqlCommand("WEST_WORLD.ActualizarRol", sqlCon);
                    sqlCom2.CommandType = CommandType.StoredProcedure;
                    sqlCom2.Parameters.AddWithValue("@idRol", Convert.ToInt32(rolesDataGridView.CurrentRow.Cells[0].Value.ToString()));
                    sqlCom2.Parameters.AddWithValue("@nombre", rolTextBox.Text);
                    sqlCom2.Parameters.AddWithValue("@habilitado", habilitadoCheckBox.Checked);
                    sqlCom2.ExecuteNonQuery();


                    SqlCommand sqlCom3 = new SqlCommand("WEST_wORLD.ActualizarFuncionalidades", sqlCon);
                    sqlCom3.CommandType = CommandType.StoredProcedure;
                    sqlCom3.Parameters.AddWithValue("@idRol", Convert.ToInt32(rolesDataGridView.CurrentRow.Cells[0].Value.ToString()));
                    sqlCom3.ExecuteNonQuery();


                    foreach (int id in funcionalidades)
                    {
                        SqlCommand sqlCmd2 = new SqlCommand("WEST_WORLD.AgregarFuncionalidad", sqlCon);
                        sqlCmd2.CommandType = CommandType.StoredProcedure;
                        sqlCmd2.Parameters.AddWithValue("@idRol", Convert.ToInt32(rolesDataGridView.CurrentRow.Cells[0].Value.ToString()));
                        sqlCmd2.Parameters.AddWithValue("@IdFuncionalidad", id);
                        sqlCmd2.ExecuteNonQuery();
                    }

                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) 
                    sqlCon.Close();
            }
        }
    
        private void ListaDeRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlCon.Open();
            SqlDataAdapter sqlCom2 = new SqlDataAdapter("WEST_WORLD.FuncionalidadesRol", sqlCon);
            sqlCom2.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlCom2.SelectCommand.Parameters.AddWithValue("@idRol", Convert.ToInt32(rolesDataGridView.CurrentRow.Cells[0].Value));
            
            DataTable dtbl = new DataTable();
            sqlCom2.Fill(dtbl);
            for (int i = 0; i < dtbl.Rows.Count; i++)
            {
                DataRow dr = dtbl.Rows[i];
                ListViewItem listItem = new ListViewItem(dr["nombre"].ToString());
                funcionalidadesListView.Items.Add(listItem);
            }

            rolTextBox.Text = rolesDataGridView.CurrentRow.Cells[1].Value.ToString();
            habilitadoCheckBox.Checked = Convert.ToBoolean(rolesDataGridView.CurrentRow.Cells[2].Value);

            crearOrUpdateBtn.Text = "Actualizar";

            sqlCon.Close();
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            funcionalidadesComboBox.SelectedIndex = -1;
            rolesDataGridView.DataSource = new DataTable();
            rolTextBox.Text = "";
            rolFilterTextBox.Text = "";
            funcionalidadesListView.Clear();
            habilitadoCheckBox.Checked = false;
            crearOrUpdateBtn.Text = "Crear";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlDataAdapter sqlCom = new SqlDataAdapter("WEST_WORLD.BuscarRoles", sqlCon);
            sqlCom.SelectCommand.CommandType = CommandType.StoredProcedure;

            utils.validarYAgregarParam(sqlCom, "@Nombre", rolFilterTextBox);
            DataTable dtbl = new DataTable();
            sqlCom.Fill(dtbl);
            rolesDataGridView.DataSource = dtbl;

            sqlCon.Close();
        }

        private void rolABM_Activated(object sender, EventArgs e)
        {
            searchBtn.Focus();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if (!funcionalidades.Contains(funcionalidadesComboBox.SelectedIndex + 1) & funcionalidadesComboBox.SelectedIndex != -1)
            {
                funcionalidadesListView.Items.Add(funcionalidadesComboBox.Text);
                funcionalidades.Add(funcionalidadesComboBox.SelectedIndex + 1);
            }
        }
        
        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem funcionalidad in funcionalidadesListView.SelectedItems)
                {
                    funcionalidadesListView.Items.Remove(funcionalidad);
                    int algo = utils.getKey(funcionalidad.Text, funcionalidadesKeyValue);
                    funcionalidades.Remove(algo);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

    }
}
