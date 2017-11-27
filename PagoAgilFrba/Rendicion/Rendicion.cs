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
using System.Globalization;
using System.Web;

namespace PagoAgilFrba.Rendicion
{
    public partial class Rendicion : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();
        private List<int> numFactList = new List<int>();

        public Rendicion()
        {
            InitializeComponent();
            List<KeyValuePair<int, string>> empresas = Utils.GetEmpresas();
            utils.llenar(empresaFilterComboBox, empresas);

            List<KeyValuePair<int, string>> meses = llenarMeses();
            utils.llenar(mesesComboBox, meses);
        }

        public List<KeyValuePair<int, string>> llenarMeses()
        {
            List<KeyValuePair<int, string>> meses = new List<KeyValuePair<int, string>>();
            List<string> nombreMes = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();
            var listaMeses = nombreMes.Select(m => new
            {
                Id = nombreMes.IndexOf(m) + 1,
                Name = m
            });

            foreach (var mes in listaMeses)
            {
                meses.Add(new KeyValuePair<int, string>(mes.Id, mes.Name));
            }
            return meses;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(empresaFilterComboBox.Text) | string.IsNullOrWhiteSpace(mesesComboBox.Text)) throw new Exception("Debe seleccionar una empresa y un mes");

                fillDataGridViewFacturas();

                cantFactTextBox.Text = facturasDataGrid.RowCount.ToString();
                empresaTextBox.Text = empresaFilterComboBox.Text;
                importeTotalTextBox.Text = utils.calcularColumna(5, facturasDataGrid);
                importeNetoTextBox.Text = (Convert.ToDecimal(importeTotalTextBox.Text) * (1 - (Convert.ToDecimal(porcentajeComisionTextBox.Text) / 100))).ToString();

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
        public void fillDataGridViewFacturas()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.FacturaViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@estado", "Con Pago Y Sin Rendicion");

                if (string.IsNullOrWhiteSpace(empresaFilterComboBox.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", empresaFilterComboBox.SelectedIndex + 1);

                sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", 0);
                sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", 0);

                sqlDa.SelectCommand.Parameters.AddWithValue("@mes", mesesComboBox.SelectedIndex + 1);

                DataTable dtbl = new DataTable();
                facturasDataGrid.DataSource = dtbl;
                sqlDa.Fill(dtbl);
                sqlCon.Close();

                foreach (DataRow dataRow in dtbl.Rows)
                {
                    if (!numFactList.Contains(Convert.ToInt32(dataRow["Num Fact"])))
                    numFactList.Add(Convert.ToInt32(dataRow["Num Fact"]));
                }
            }
        }

        private void limpiarRendBtn_Click(object sender, EventArgs e)
        {
            cantFactTextBox.Text = empresaTextBox.Text = importeNetoTextBox.Text = importeTotalTextBox.Text = 
                porcentajeComisionTextBox.Text = "";
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            limpiarRendBtn_Click(sender, e);
            facturasDataGrid.DataSource = new DataTable();
            empresaFilterComboBox.Text = mesesComboBox.Text = "";
            numFactList = new List<int>();
        }

        private void rendirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idRendicion = rendirFacturas();
                if (idRendicion == -1) throw new Exception("No se pudo rendir las facturas");
                sqlCon.Open();
                foreach (int numFact in numFactList)
                {
                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaAsignarRendicion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@numFactura", numFact);
                    sqlCmd.Parameters.AddWithValue("@rendicion", idRendicion);

                    sqlCmd.ExecuteNonQuery();
                }

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

        private int rendirFacturas()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.RendicionCreate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@fecha_rendicion", DateTime.Now);
                sqlCmd.Parameters.AddWithValue("@idEmpresa", empresaFilterComboBox.SelectedIndex + 1);
                utils.validarYAgregarParam(sqlCmd, "@cant_facturas", cantFactTextBox);

                utils.validarImporteYAgregar(sqlCmd, "@importe_neto", importeNetoTextBox);
                utils.validarImporteYAgregar(sqlCmd, "@importe_total", importeTotalTextBox);

                utils.validarYAgregarParam(sqlCmd, "@porcentaje_comision", porcentajeComisionTextBox);

                int idRendicion = -1;
                var returnParameter = sqlCmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                sqlCmd.ExecuteNonQuery();
                idRendicion = Convert.ToInt32(returnParameter.Value);

                MessageBox.Show("Se registró la rendicion " + idRendicion.ToString() + " correctamente");
                sqlCon.Close();
                return idRendicion;
            }
            return -1;
        }

    }
}
