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
    public partial class Index : Form
    {
        private SqlConnection con = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        String user;


        public Index(String user)
        {
            InitializeComponent();
            this.user = user; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ToolStripMenuItem abm = new ToolStripMenuItem("ABM");

            if (con.State == ConnectionState.Closed)
                con.Open();


            String query = "Select f.idFuncionalidad, f.nombre from WEST_WORLD.Funcionalidad f " +
           "JOIN WEST_WORLD.Rol_Funcionalidad rf ON f.idFuncionalidad=rf.idFuncionalidad " +
                "JOIN WEST_WORLD.Rol r ON rf.idRol=r.idRol " +
                "JOIN WEST_WORLD.Rol_Usuario ru ON r.idRol=ru.idRol " +
               "JOIN WEST_WORLD.Usuario u ON u.idUser=ru.idUsuario " +
              " WHERE u.[user]=@Usuario";
 
            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Usuario", this.user);


        SqlDataReader dr = sqlCmd.ExecuteReader();
            while (dr.Read()){
                ToolStripMenuItem item = new ToolStripMenuItem(dr["nombre"].ToString());
                int id = Int32.Parse(dr["idFuncionalidad"].ToString());

                switch (id)
                {
                    case 1:
                        item.Click += new EventHandler(abmEmpresa_Click);
                        abm.DropDownItems.Add(item);
                        break;
                    case 2:
                        item.Click += new EventHandler(abmCliente_Click);
                        abm.DropDownItems.Add(item);
                        break;
                    case 3:
                        item.Click += new EventHandler(abmSucursal_Click);
                        abm.DropDownItems.Add(item);
                        break;
                    case 4:
                        item.Click += new EventHandler(abmRol_Click);
                        abm.DropDownItems.Add(item);
                        break;
                    case 5:
                        item.Click += new EventHandler(abmFactura_Click);
                        abm.DropDownItems.Add(item);
                        break;
                    case 6:
                        item.Click += new EventHandler(registarPago_Click);
                        this.toolStripMenuItem1.DropDownItems.Add(item);
                        break;
                    case 7:
                        item.Click += new EventHandler(rendirFacturas_Click);
                        this.toolStripMenuItem1.DropDownItems.Add(item);
                        break;
                    case 8:
                        item.Click += new EventHandler(devolverBtn_Click);
                        this.toolStripMenuItem1.DropDownItems.Add(item);
                        break;
                }

                
            }
            
            this.toolStripMenuItem1.DropDownItems.Add(abm);
         }

    private void abmCliente_Click(object sender, EventArgs e)
        {
            AbmCliente.clienteABM clienteABM = new AbmCliente.clienteABM();
            clienteABM.ShowDialog();

        }


        private void abmSucursal_Click(object sender, EventArgs e)
        {
            AbmSucursal.sucursalABM sucursalABM = new AbmSucursal.sucursalABM();
            sucursalABM.ShowDialog();
        }

        private void abmFactura_Click(object sender, EventArgs e)
        {
            AbmFactura.facturaABM facturaABM = new AbmFactura.facturaABM();
            facturaABM.ShowDialog();
        }

        private void registarPago_Click(object sender, EventArgs e)
        {
            RegistroPago.RegistroPago registroPago = new RegistroPago.RegistroPago();
            registroPago.ShowDialog();
        }

        private void rendirFacturas_Click(object sender, EventArgs e)
        {
            Rendicion.Rendicion rendicion = new Rendicion.Rendicion();
            rendicion.ShowDialog();
        }

        private void abmRol_Click(object sender, EventArgs e)
        {
            AbmRol.rolABM rolABM = new AbmRol.rolABM();
            rolABM.ShowDialog();
        }

        private void devolverBtn_Click(object sender, EventArgs e)
        {
            Devolucion.Devolucion devolucion = new Devolucion.Devolucion();
            devolucion.ShowDialog();
        }

        private void abmEmpresa_Click(object sender, EventArgs e)
        {
            AbmEmpresa.empresaABM empresaABM = new AbmEmpresa.empresaABM();
            empresaABM.ShowDialog();
        }

       
    }
}








// Select nombre,event from WEST_WORLD.Funcionalidad f JOIN WEST_WORLD.Rol_Funcionalidad rf ON f.idFuncionalidad=rf.idFuncionalidad JOIN WEST_WORLD.Rol r ON rf.idRol=r.idRol  JOIN WEST_WORLD.Rol_Usuario ru ON r.idRol=ru.idRol JOIN WEST_WORLD.Usuario u ON u.idUser=ru.idUser WHERE u.[user]='admin'