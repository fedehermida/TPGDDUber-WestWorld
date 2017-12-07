using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class Login : Form
    {
        private SqlConnection con = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);

        public Login()  
        {
            InitializeComponent();
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
             
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();


            String query = "Select failedLogins from WEST_WORLD.Usuario WHERE [user]=@Usuario";
            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Usuario", userTxtBox.Text);
            int failedLogins = Convert.ToInt32(sqlCmd.ExecuteScalar());
            if(failedLogins >= 3)
            {
                MessageBox.Show("Usuario bloqueado");


            }
            else
            {
                byte[] bytes = Encoding.UTF8.GetBytes(passTxtBox.Text);
                SHA256Managed hashString = new SHA256Managed();
                byte[] hash = hashString.ComputeHash(bytes);



                query = "Select COUNT(1) from WEST_WORLD.Usuario WHERE [user]=@Usuario and pass=@Password";
                sqlCmd = new SqlCommand(query, con);
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.Parameters.AddWithValue("@Usuario", userTxtBox.Text);
                sqlCmd.Parameters.AddWithValue("@Password", hash);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    checkMultipleSucursal(userTxtBox.Text);

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");

                    query = "UPDATE WEST_WORLD.Usuario SET failedLogins=failedLogins+1 WHERE [user]=@Usuario";
                    sqlCmd = new SqlCommand(query, con);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@Usuario", userTxtBox.Text);
                    sqlCmd.ExecuteNonQuery();


                }

            } 

        }

        private void checkMultipleRols(string user, int idSucursal)
        {
            String query = "SELECT COUNT(1) from WEST_WORLD.Rol r " +
                "JOIN WEST_WORLD.Rol_Usuario ru ON (ru.idRol=r.idRol) " +
                "JOIN WEST_WORLD.Usuario u ON (ru.idUsuario=u.idUSer) " +
                "WHERE u.[user]=@Usuario " +
                "AND r.habilitado=1";
            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Usuario", user);
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            if(count == 0)
            {
                MessageBox.Show("Debe asignarle al menos un rol habilitado al usuario");
            } else if (count == 1)
            {
                query = "SELECT r.idRol from WEST_WORLD.Rol r " +
                "JOIN WEST_WORLD.Rol_Usuario ru ON (ru.idRol=r.idRol) " +
                "JOIN WEST_WORLD.Usuario u ON (ru.idUsuario=u.idUSer) " +
                "WHERE u.[user]=@Usuario " +
                "AND r.habilitado=1";
                sqlCmd = new SqlCommand(query, con);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Usuario", user);
                int idRol = Convert.ToInt32(sqlCmd.ExecuteScalar());
                con.Close();
                showIndex(idRol, idSucursal, user);


            } else
            {
                con.Close();
                showSelectRol(user, idSucursal);
            }
            
        }

        private void checkMultipleSucursal(string user)
        {
            String query = "SELECT COUNT(1) from WEST_WORLD.Sucursal s " +
                "JOIN WEST_WORLD.Sucursal_Usuario su ON (su.idSucursal=s.idSucursal) " +
                "JOIN WEST_WORLD.Usuario u ON (u.idUser=su.idUsuario) " +           
                "WHERE u.[user]=@Usuario " +
                "AND s.habilitado=1";
            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Usuario", user);
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            if (count == 0)
            {
                MessageBox.Show("No tiene sucursales activas, debe tener almenos una sucursal activa");
            }
            else if (count == 1)
            {
                query = "SELECT s.idSucursal from WEST_WORLD.Sucursal s " +
                "JOIN WEST_WORLD.Sucursal_Usuario su ON (su.idSucursal=s.idSucursal) " +
                "JOIN WEST_WORLD.Usuario u ON (u.idUser=su.idUsuario) " +
                "WHERE u.[user]=@Usuario " +
                "AND s.habilitado=1";
                sqlCmd = new SqlCommand(query, con);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Usuario", user);
                int idSucursal = Convert.ToInt32(sqlCmd.ExecuteScalar());

                checkMultipleRols(user, idSucursal);
          

            }
            else
            {
                con.Close();
                showSelectSucursal(user);
            }

        }
        private void showSelectSucursal(String user)
        {
            SelectSucursal selectSucursal = new SelectSucursal(user);
            selectSucursal.Location = this.Location;
            selectSucursal.StartPosition = FormStartPosition.Manual;
            selectSucursal.FormClosing += delegate { this.Show(); };
            selectSucursal.Show();
            this.Hide();

        }

        private void showSelectRol(String user, int idSucursal)
        {
            SelectRol selectRol = new SelectRol(user,idSucursal);
            selectRol.Location = this.Location;
            selectRol.StartPosition = FormStartPosition.Manual;
            selectRol.FormClosing += delegate { this.Show(); };
            selectRol.Show();
            this.Hide();

        }


        private void showIndex(int idRol, int idSucursal, string user)
        {
            Index index = new Index(idRol, idSucursal, user);
            index.Location = this.Location;
            index.StartPosition = FormStartPosition.Manual;
            index.FormClosing += delegate { this.Show(); };
            index.Show();
            this.Hide();

        }

        private void ExitBtn_Click(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void passTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) LoginBtn_Click(sender, e);
        }

    }
}
