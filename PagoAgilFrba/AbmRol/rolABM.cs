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
        private List<KeyValuePair<int, string>> funcionalidades = new List<KeyValuePair<int, string>>();

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

    }
}
