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

namespace PagoAgilFrba
{
    public partial class SelectSucursal : Form
    {
        private String user;
        private SqlConnection con = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);

        public SelectSucursal(string user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void SelectSucursal_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();

            String query = "Select s.idSucursal, s.nombre from WEST_WORLD.Sucursal s " +
           "JOIN WEST_WORLD.Sucursal_Usuario su ON (su.idSucursal=s.idSucursal) " +
                "JOIN WEST_WORLD.Usuario u ON (u.idUser=su.idUsuario) " +
                "WHERE u.[user]=@Usuario " +
                "AND s.habilitado=1";

            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Usuario", this.user);


            SqlDataReader dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dr["nombre"].ToString();
                item.Value = Int32.Parse(dr["idSucursal"].ToString());
                comboSucursal.Items.Add(item);
            }

            comboSucursal.SelectedIndex = 0;
            con.Close();
        }

        private void SeleccionBtn_Click(object sender, EventArgs e)
        {
            ComboboxItem selectedItem = new ComboboxItem();
            selectedItem = (ComboboxItem)comboSucursal.SelectedItem;
            int idSucursal = selectedItem.Value;

            checkMultipleRols(this.user, idSucursal);


        }



        private void checkMultipleRols(string user, int idSucursal)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();


            String query = "SELECT COUNT(1) from WEST_WORLD.Rol_Usuario ru " +
                "JOIN WEST_WORLD.Usuario u ON (ru.idUsuario=u.idUser) " +
                "WHERE u.[user]=@Usuario";
            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Usuario", user);
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            if (count == 0)
            {
                con.Close();
                MessageBox.Show("Debe asignarle al menos un rol al usuario");
            }
            else if (count == 1)
            {
                query = "SELECT idRol from WEST_WORLD.Rol_Usuario ru " +
                "JOIN WEST_WORLD.Usuario u ON (ru.idUsuario=u.idUser) " +
                "WHERE u.[user]=@Usuario";
                sqlCmd = new SqlCommand(query, con);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Usuario", user);
                int idRol = Convert.ToInt32(sqlCmd.ExecuteScalar());
                con.Close();

                showIndex(idRol, idSucursal);

            }
            else
            {
                con.Close();

                showSelectRol(user, idSucursal);
            }

        }

        private void showSelectRol(String user, int idSucursal)
        {
            SelectRol selectRol = new SelectRol(user, idSucursal);
            selectRol.Location = this.Location;
            selectRol.StartPosition = FormStartPosition.Manual;
          //  selectRol.FormClosing += delegate { Login.Show(); };
            selectRol.Show();
            this.Hide();

        }


        private void showIndex(int idRol, int idSucursal)
        {
            Index index = new Index(idRol, idSucursal, this.user);
            index.Location = this.Location;
            index.StartPosition = FormStartPosition.Manual;
           // index.FormClosing += delegate { this.Show(); };
            index.Show();
            this.Hide();

        }




    }

}

   

