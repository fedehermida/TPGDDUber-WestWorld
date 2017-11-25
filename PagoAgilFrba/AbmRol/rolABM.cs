using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoAgilFrba.AbmRol
{
    public partial class rolABM : Form
    {

        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();
        private List<KeyValuePair<int,String>> funcionalidades = new List<KeyValuePair<int,String>>();

        public rolABM()
        {
            InitializeComponent();
            llenarListaFuncionalidades();
        }

        public void llenarListaFuncionalidades()
        {
            List<KeyValuePair<int, string>> funcionalidades = Utils.GetFuncionalidades();
            utils.llenar(comboBox1, funcionalidades);
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    if (button1.Text == "Crear")
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.CreateOrUpdateRol", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;


                        utils.validarYAgregarParam(sqlCmd, "@nombre", textBox2);

                        var returnParameter = sqlCmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;


                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Rol Creado");
                        foreach (KeyValuePair<int, String> keyvalue in funcionalidades)
                        {
                            SqlCommand sqlCmd1 = new SqlCommand("GD2C2017.WEST_WORLD.AgregarFuncionalidad", sqlCon);
                            sqlCmd1.CommandType = CommandType.StoredProcedure;



                            utils.validarYAgregarParam(sqlCmd1, "@IdRol", returnParameter);
                            utils.validarYAgregarParam(sqlCmd1, "@IdFuncionalidad", keyvalue.Key);

                            sqlCmd.ExecuteNonQuery();
                        }
                        if (sqlCon.State == ConnectionState.Open) sqlCon.Close();

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rolABM_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new KeyValuePair<int, String>(comboBox1.SelectedIndex + 1, comboBox1.Text);
            funcionalidades.Add(new KeyValuePair<int, String>(comboBox1.SelectedIndex + 1, comboBox1.Text));
            listView1.Items.Add(comboBox1.Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    if (button3.Text == "Crear")
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.BuscarRoles", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        if (!String.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            utils.validarYAgregarParam(sqlCmd, "@nombre", textBox3);
                        }else
                        {
                            sqlCmd.Parameters.AddWithValue("@nombre",DBNull.Value);
                        }
                        var returnParameter = sqlCmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;


                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Rol Creado");
                   
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
    }
}
