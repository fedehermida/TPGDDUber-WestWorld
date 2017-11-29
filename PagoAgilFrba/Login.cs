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
                    Index index = new Index(userTxtBox.Text);
                    index.ShowDialog();
                    this.Close();
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
