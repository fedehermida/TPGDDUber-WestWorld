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
    public partial class Form1 :Form
    {

        private List<int> funcionalidades = new List<int>();


        public Form1()
        {
            InitializeComponent();
            llenarListaFuncionalidades();
        }

        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();
     

      
        public void llenarListaFuncionalidades()
        {
            List<KeyValuePair<int, string>> funcionalidades = Utils.GetFuncionalidades();
            utils.llenar(FuncionalidadAAgregar, funcionalidades);
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            listaFuncionalidadrs.Items.Add(FuncionalidadAAgregar.Text);
            funcionalidades.Add(FuncionalidadAAgregar.SelectedIndex+1);

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            if (CrearOUpdatear.Text == "Crear")
            {
                sqlCon.Open();
                SqlCommand sqlCom2 = new SqlCommand("WEST_wORLD.CreateOrUpdateRol", sqlCon);
                sqlCom2.CommandType = CommandType.StoredProcedure;

                utils.validarYAgregarParam(sqlCom2, "@nombre", NombreRol);
                int idRol = -1;
                var returnParameter = sqlCom2.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                sqlCom2.ExecuteNonQuery();
                idRol = Convert.ToInt32(returnParameter.Value);

                foreach (int id in funcionalidades)
                {
                    SqlCommand sqlCom = new SqlCommand("WEST_WORLD.AgregarFuncionalidad", sqlCon);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@IdRol", idRol);
                    sqlCom.Parameters.AddWithValue("@IdFuncionalidad", id);
                    sqlCom.ExecuteNonQuery();
                }
                listaFuncionalidadrs.Items.Clear();
                sqlCon.Close();
            }

            if (CrearOUpdatear.Text == "Actualizar")
            {
                sqlCon.Open();

                SqlCommand sqlCom2 = new SqlCommand("WEST_wORLD.ActualizarRol", sqlCon);
                sqlCom2.CommandType = CommandType.StoredProcedure;
                sqlCom2.Parameters.AddWithValue("@idRol",Convert.ToInt32(ListaDeRoles.CurrentRow.Cells[0].Value.ToString()));
                sqlCom2.Parameters.AddWithValue("@nombre",NombreRol.Text);
                sqlCom2.Parameters.AddWithValue("@habilitado", Habilitado.Checked);
                sqlCom2.ExecuteNonQuery();


                SqlCommand sqlCom3 = new SqlCommand("WEST_wORLD.ActualizarFuncionalidades", sqlCon);
                sqlCom3.CommandType = CommandType.StoredProcedure;
                sqlCom3.Parameters.AddWithValue("@idRol", Convert.ToInt32(ListaDeRoles.CurrentRow.Cells[0].Value.ToString()));
                sqlCom3.ExecuteNonQuery();


                foreach (int id in funcionalidades)
                {
                    SqlCommand sqlCom = new SqlCommand("WEST_WORLD.AgregarFuncionalidad", sqlCon);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@idRol", Convert.ToInt32(ListaDeRoles.CurrentRow.Cells[0].Value.ToString()));
                    sqlCom.Parameters.AddWithValue("@IdFuncionalidad", id);
                    sqlCom.ExecuteNonQuery();
                }


                listaFuncionalidadrs.Items.Clear();
                sqlCon.Close();
            }
        }

        private void BuscarRol_Click(object sender, EventArgs e)
        {   

            sqlCon.Open();
            SqlDataAdapter sqlCom = new SqlDataAdapter("WEST_WORLD.BuscarRoles",sqlCon);
            sqlCom.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlCom.SelectCommand.Parameters.AddWithValue("@Nombre", RolABuscar.Text);
            DataTable dtbl = new DataTable();
            sqlCom.Fill(dtbl);
            ListaDeRoles.DataSource = dtbl;
            

            sqlCon.Close();

        }

        private void ListaDeRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlCon.Open();
            SqlDataAdapter sqlCom2 = new SqlDataAdapter("WEST_wORLD.FuncionalidadesRol", sqlCon);
            sqlCom2.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlCom2.SelectCommand.Parameters.AddWithValue("@idRol",Convert.ToInt32(ListaDeRoles.CurrentRow.Cells[0].Value));
            DataTable dtbl = new DataTable();
            sqlCom2.Fill(dtbl);
            for(int i = 0;i < dtbl.Rows.Count; i++){
                DataRow dr = dtbl.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["nombre"].ToString());
                listaFuncionalidadrs.Items.Add(listitem);   
            }

            NombreRol.Text =ListaDeRoles.CurrentRow.Cells[1].Value.ToString();
            Habilitado.Checked = Convert.ToBoolean(ListaDeRoles.CurrentRow.Cells[2].Value);
            
            CrearOUpdatear.Text = "Actualizar";


            sqlCon.Close();


        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            ListaDeRoles.DataSource = new DataTable();
            NombreRol.Text = "";
            RolABuscar.Text = "";
            listaFuncionalidadrs.Clear();
            Habilitado.Checked = false;
            CrearOUpdatear.Text = "Crear";

        }

        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            listaFuncionalidadrs.Items.Remove(listaFuncionalidadrs.SelectedItems[0]);
        }
    }
}
