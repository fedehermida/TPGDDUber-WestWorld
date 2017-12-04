using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace PagoAgilFrba.Rendicion
{
    public partial class Rendicion : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();
        private List<int> numFactList = new List<int>();
        List<KeyValuePair<int, string>> empresas = Utils.GetEmpresas();

        public Rendicion()
        {
            InitializeComponent();
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
                if (string.IsNullOrWhiteSpace(empresaFilterComboBox.Text) | string.IsNullOrWhiteSpace(mesesComboBox.Text)) throw new Exception("Complete los campos obligatorios");

                fillDataGridViewFacturas();
                limpiarRendicion();

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
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", empresaFilterComboBox.SelectedIndex);

                sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", DBNull.Value);
                sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", DBNull.Value);

                sqlDa.SelectCommand.Parameters.AddWithValue("@mes", mesesComboBox.SelectedIndex);

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

        private void limpiarRendicion()
        {
            cantFactTextBox.Text = empresaTextBox.Text = importeNetoTextBox.Text = importeTotalTextBox.Text = porcDisableTxtBox.Text = "";
            rendirBtn.Enabled = false;

        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            limpiarRendicion();
            porcentajeComisionTextBox.Text = "";

            facturasDataGrid.DataSource = new DataTable();
            empresaFilterComboBox.SelectedIndex = mesesComboBox.SelectedIndex = -1;
            numFactList = new List<int>();
        }

        private void rendirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                validarFechaRendicion();

                int idRendicion = rendirFacturas();
                if (idRendicion == -1) throw new Exception("No fue posible rendir las facturas");
                
                sqlCon.Open();
                
                foreach (int numFact in numFactList)
                {
                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaAsignarRendicion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@numFactura", numFact);
                    sqlCmd.Parameters.AddWithValue("@rendicion", idRendicion);

                    sqlCmd.ExecuteNonQuery();
                }
                rendirBtn.Enabled = false;
                facturasDataGrid.DataSource = new DataTable();
                numFactList.Clear();
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

        private void validarFechaRendicion(){
            sqlCon.Open();
            
            string query = "SELECT diaRendicion FROM WEST_WORLD.Empresa WHERE idEmpresa = @idEmpresa";
            SqlCommand sqlCmdDay = new SqlCommand(query, sqlCon);
            sqlCmdDay.CommandType = CommandType.Text;

            int key = utils.getKey(empresaTextBox.Text.Trim(), empresas);
            sqlCmdDay.Parameters.AddWithValue("@idEmpresa", key);
            
            int dia = Convert.ToInt32(sqlCmdDay.ExecuteScalar());
            
            sqlCon.Close();

            if (!(fechaRendDT.Value.Day == dia)) throw new Exception("No puede realizar hoy una rendición para la empresa seleccionada. Intente modificar el día de rendición para la empresa: '" + empresaFilterComboBox.Text + "' desde el ABM de Empresas");
        }
        private int rendirFacturas()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.RendicionCreate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@fecha_rendicion", DateTime.Now);

                sqlCmd.Parameters.AddWithValue("@idEmpresa", utils.getKey(empresaTextBox.Text.Trim(), empresas));
                utils.validarYAgregarParam(sqlCmd, "@cant_facturas", cantFactTextBox);

                utils.validarImporteYAgregar(sqlCmd, "@importe_neto", importeNetoTextBox);
                utils.validarImporteYAgregar(sqlCmd, "@importe_total", importeTotalTextBox);

                utils.validarConvYAgregarParam(sqlCmd, "@porcentaje_comision", porcDisableTxtBox);

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

        private void empresaFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empresaFilterComboBox.SelectedIndex == 0) empresaFilterComboBox.SelectedIndex = -1;
        }

        private void porcentajeComisionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.validarCampoDecimal(e);
        }

        private void calcularPorcentaje() {
            utils.esDecimal(porcentajeComisionTextBox.Text.Trim()); //tira exception si no es decimal
            Decimal porcentaje = utils.convertirADecimal(porcentajeComisionTextBox);
            if (porcentaje >= 0 & porcentaje < new Decimal(101))
                importeNetoTextBox.Text = Decimal.Round(Convert.ToDecimal(importeTotalTextBox.Text) * (1 - (porcentaje / 100)), 2).ToString();
            else
               throw new Exception("Porcentaje fuera de rango");
        }

        private void Rendicion_Activated(object sender, EventArgs e)
        {
            searchBtnL.Focus();
        }

        private void calcularRendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturasDataGrid.Rows.Count == 0) throw new Exception("No es posible calcular si no hay facturas a rendir");
                if (string.IsNullOrWhiteSpace(porcentajeComisionTextBox.Text)) throw new Exception("Ingrese porcentaje");

                cantFactTextBox.Text = facturasDataGrid.RowCount.ToString();
                empresaTextBox.Text = empresaFilterComboBox.Text.Trim();
                importeTotalTextBox.Text = utils.calcularColumna(5, facturasDataGrid);
                calcularPorcentaje();
                porcDisableTxtBox.Text = porcentajeComisionTextBox.Text.Trim();
                rendirBtn.Enabled = true;
                rendirBtn.Focus();
            }
            catch (Exception ex)
            {
                limpiarRendBtn_Click(sender, e);
                MessageBox.Show(ex.Message, "Error message");
            }
        }

        private void limpiarRendBtn_Click(object sender, EventArgs e)
        {
            limpiarRendicion();
        }
    }
}
