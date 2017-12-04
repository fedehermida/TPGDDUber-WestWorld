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
    public partial class SelectRol : Form
    {
        private String user;
        private int idSucursal;
        private SqlConnection con = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);

        public SelectRol(string user, int idSucursal)
        {
            InitializeComponent();

            this.user = user;
            this.idSucursal = idSucursal;
        }

        private void SelectRol_Load(object sender, EventArgs e)
        {

            if(con.State == ConnectionState.Closed)
                con.Open();

            String query = "Select r.idRol, r.nombre from WEST_WORLD.Rol r " +
           "JOIN WEST_WORLD.Rol_Usuario ru ON ru.idRol=r.idRol " +
                "JOIN WEST_WORLD.Usuario u ON ru.idUsuario=u.idUser " +
                " WHERE u.[user]=@User " +
                "AND r.habilitado=1";

            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@User", this.user);


            SqlDataReader dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dr["nombre"].ToString();
                item.Value = Int32.Parse(dr["idRol"].ToString());
                comboRol.Items.Add(item);
            }

            comboRol.SelectedIndex = 0;
        }

        private void SeleccionBtn_Click(object sender, EventArgs e)
        {
            ComboboxItem selectedItem = new ComboboxItem();
               selectedItem = (ComboboxItem) comboRol.SelectedItem;
            int idRol = selectedItem.Value;
            con.Close();
            showIndex(idRol, this.idSucursal);
            

        }

        private void showIndex(int idRol, int idSucursal)
        {
            Index index = new Index(idRol, idSucursal, this.user);
            index.Location = this.Location;
            index.StartPosition = FormStartPosition.Manual;
          //  index.FormClosing += delegate { this.Show(); };
            index.Show();
            this.Hide();

        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
