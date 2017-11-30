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
            this.Close();
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
            String query = "SELECT COUNT(1) from WEST_WORLD.Rol_Usuario ru " +
                "JOIN WEST_WORLD.Usuario u ON (ru.idUsuario=u.idUser)" +
                "WHERE u.[user]=@Usuario";
            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Usuario", user);
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            if(count == 0)
            {
                MessageBox.Show("Debe asignarle al menos un rol al usuario");
            } else if (count == 1)
            {
                query = "SELECT idRol from WEST_WORLD.Rol_Usuario ru " +
                "JOIN WEST_WORLD.Usuario u ON (ru.idUsuario=u.idUser) " +
                "WHERE u.[user]=@Usuario";
                sqlCmd = new SqlCommand(query, con);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Usuario", user);
                int idRol = Convert.ToInt32(sqlCmd.ExecuteScalar());
                con.Close();
                Index index = new Index(idRol, idSucursal);
                index.ShowDialog();
                this.Close();

            } else
            {
                con.Close();
                SelectRol selectRol = new SelectRol(user, idSucursal);
                selectRol.ShowDialog();
                this.Close();
            }
            
        }

        private void checkMultipleSucursal(string user)
        {
            String query = "SELECT COUNT(1) from WEST_WORLD.Sucursal s " +
                "JOIN WEST_WORLD.Usuario u ON (s.operador=u.idUser)" +
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
                query = "SELECT idSucursal from WEST_WORLD.Sucursal s " +
                "JOIN WEST_WORLD.Usuario u ON (s.operador=u.idUser) " +
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
                SelectSucursal selectSucursal = new SelectSucursal(user);
                selectSucursal.ShowDialog();
                this.Close();
            }

        }
    }
}
