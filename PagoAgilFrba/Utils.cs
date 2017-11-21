using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public class Utils : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);

        public void llenar(ComboBox combo, List<KeyValuePair<int, string>> items)
        {
            combo.Items.Clear();
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";

            items.ForEach(item => combo.Items.Add(item));
        }


        public void llenar(CheckedListBox list, List<KeyValuePair<int, string>> items)
        {
            list.Items.Clear();
            list.DisplayMember = "Value";
            list.ValueMember = "Key";

            items.ForEach(item => combo.Items.Add(item));
        }

        static public List<KeyValuePair<int, string>> GetEmpresas()
        {
            List<KeyValuePair<int, string>> empresas = new List<KeyValuePair<int, string>>();

            SqlCommand com = new SqlCommand("WEST_WORLD.GetEmpresas", sqlCon);
            com.CommandType = CommandType.StoredProcedure;

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                empresas.Add(new KeyValuePair<int, string>(Int32.Parse(reader["idEmpresa"].ToString()), reader["nombre"].ToString()));
            }
            reader.Close();
            sqlCon.Close();
            return empresas;
        }

        static public List<KeyValuePair<int, string>> GetRubros()
        {
            List<KeyValuePair<int, string>> rubros = new List<KeyValuePair<int, string>>();

            SqlCommand com = new SqlCommand("WEST_WORLD.GetRubros", sqlCon);
            com.CommandType = CommandType.StoredProcedure;

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                rubros.Add(new KeyValuePair<int, string>(Int32.Parse(reader["idRubro"].ToString()), reader["nombre"].ToString()));
            }
            reader.Close();
            sqlCon.Close();
            return rubros;
        }

        static public List<KeyValuePair<int, string>> GetFormasDePago()
        {
            List<KeyValuePair<int, string>> formasDePago = new List<KeyValuePair<int, string>>();

            SqlCommand com = new SqlCommand("WEST_WORLD.GetFormasDePago", sqlCon);
            com.CommandType = CommandType.StoredProcedure;

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                formasDePago.Add(new KeyValuePair<int, string>(Int32.Parse(reader["idFormaPago"].ToString()), reader["descripcion"].ToString()));
            }
            reader.Close();
            sqlCon.Close();
            return formasDePago;
        }

        static public List<KeyValuePair<int,String>> getFuncionalidades()
        {
            List<KeyValuePair<int, string>> funcionalidades = new List<KeyValuePair<int, string>>();
            SqlCommand com = new SqlCommand("WEST_WORLD.GetFuncionalidades", sqlCon);
            com.CommandType = CommandType.StoredProcedure;

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                funcionalidades.Add(new KeyValuePair<int, string>(Int32.Parse(reader["idFuncionalidad"].ToString()), reader["nombre"].ToString()));
            }
            reader.Close();
            sqlCon.Close();
            return formasDePago;

        }

        public void validarYAgregarParam(SqlCommand sqlCmd, string variable, TextBox text)
        {
            if ((string.IsNullOrWhiteSpace(text.Text.Trim()))) throw new Exception("Todos los campos correspondientes son obligatorios");
            else sqlCmd.Parameters.AddWithValue(variable, text.Text.Trim());
        }

        public void validarConvYAgregarParam(SqlCommand sqlCmd, string variable, TextBox text)
        {
            if ((string.IsNullOrWhiteSpace(text.Text.Trim()))) throw new Exception("Todos los campos correspondientes son obligatorios");
            else sqlCmd.Parameters.AddWithValue(variable, convertirAValor(text));
        }

        public Decimal convertirAValor(TextBox textBox)
        {
            return Decimal.Parse(textBox.Text.Trim());
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Utils";
            this.Load += new System.EventHandler(this.Utils_Load);
            this.ResumeLayout(false);

        }

        private void Utils_Load(object sender, EventArgs e)
        {

        }
        public void validarImporte(SqlCommand sqlCmd, string variable, TextBox text)
        {
            if (string.IsNullOrWhiteSpace(text.Text)) throw new Exception("Ingrese un importe");
            if (Convert.ToDecimal(text.Text.Trim()) <= 0) throw new Exception("El importe debe ser mayor a 0");
            else this.validarConvYAgregarParam(sqlCmd, variable, text);
        }


        public string calcularColumna(string columna, DataTable dtbl)
        {
            decimal suma = 0;
            foreach (DataRow dataRow in dtbl.Rows)
            {
                suma += Convert.ToDecimal(dataRow[columna]);
            }
            return suma.ToString();
        }

        public string calcularColumna(int indexCol, DataGridView dataGridView)
        {
            decimal suma = 0;
            foreach (DataGridViewRow dataRow in dataGridView.Rows)
            {
                suma += Convert.ToDecimal(dataRow.Cells[indexCol].Value.ToString());
            }
            return suma.ToString();
        }
    }
}
