namespace PagoAgilFrba.AbmRol
{
    partial class rolABM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FuncionalidadAAgregar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreRol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaFuncionalidadrs = new System.Windows.Forms.ListView();
            this.CrearOUpdatear = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.ListaDeRoles = new System.Windows.Forms.DataGridView();
            this.BuscarRol = new System.Windows.Forms.Button();
            this.RolABuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Habilitado = new System.Windows.Forms.CheckBox();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.QuitarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDeRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncionalidadAAgregar
            // 
            this.FuncionalidadAAgregar.FormattingEnabled = true;
            this.FuncionalidadAAgregar.Location = new System.Drawing.Point(317, 44);
            this.FuncionalidadAAgregar.Name = "FuncionalidadAAgregar";
            this.FuncionalidadAAgregar.Size = new System.Drawing.Size(121, 37);
            this.FuncionalidadAAgregar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionalidades";
            // 
            // NombreRol
            // 
            this.NombreRol.Location = new System.Drawing.Point(119, 44);
            this.NombreRol.Name = "NombreRol";
            this.NombreRol.Size = new System.Drawing.Size(100, 35);
            this.NombreRol.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rol";
            // 
            // listaFuncionalidadrs
            // 
            this.listaFuncionalidadrs.GridLines = true;
            this.listaFuncionalidadrs.Location = new System.Drawing.Point(317, 84);
            this.listaFuncionalidadrs.Name = "listaFuncionalidadrs";
            this.listaFuncionalidadrs.Size = new System.Drawing.Size(121, 97);
            this.listaFuncionalidadrs.TabIndex = 4;
            this.listaFuncionalidadrs.UseCompatibleStateImageBehavior = false;
            this.listaFuncionalidadrs.View = System.Windows.Forms.View.List;
            // 
            // CrearOUpdatear
            // 
            this.CrearOUpdatear.Location = new System.Drawing.Point(363, 187);
            this.CrearOUpdatear.Name = "CrearOUpdatear";
            this.CrearOUpdatear.Size = new System.Drawing.Size(75, 23);
            this.CrearOUpdatear.TabIndex = 5;
            this.CrearOUpdatear.Text = "Crear";
            this.CrearOUpdatear.UseVisualStyleBackColor = true;
            this.CrearOUpdatear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(445, 41);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 6;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListaDeRoles
            // 
            this.ListaDeRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDeRoles.Location = new System.Drawing.Point(93, 275);
            this.ListaDeRoles.Name = "ListaDeRoles";
            this.ListaDeRoles.Size = new System.Drawing.Size(427, 150);
            this.ListaDeRoles.TabIndex = 7;
            this.ListaDeRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDeRoles_CellDoubleClick);
            // 
            // BuscarRol
            // 
            this.BuscarRol.Location = new System.Drawing.Point(230, 233);
            this.BuscarRol.Name = "BuscarRol";
            this.BuscarRol.Size = new System.Drawing.Size(139, 23);
            this.BuscarRol.TabIndex = 8;
            this.BuscarRol.Text = "Buscar";
            this.BuscarRol.UseVisualStyleBackColor = true;
            this.BuscarRol.Click += new System.EventHandler(this.BuscarRol_Click);
            // 
            // RolABuscar
            // 
            this.RolABuscar.Location = new System.Drawing.Point(122, 235);
            this.RolABuscar.Name = "RolABuscar";
            this.RolABuscar.Size = new System.Drawing.Size(97, 35);
            this.RolABuscar.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rol";
            // 
            // Habilitado
            // 
            this.Habilitado.AutoSize = true;
            this.Habilitado.Location = new System.Drawing.Point(119, 84);
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.Size = new System.Drawing.Size(154, 33);
            this.Habilitado.TabIndex = 11;
            this.Habilitado.Text = "Habilitado";
            this.Habilitado.UseVisualStyleBackColor = true;
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Location = new System.Drawing.Point(375, 233);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(145, 23);
            this.LimpiarBtn.TabIndex = 12;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // QuitarBtn
            // 
            this.QuitarBtn.Location = new System.Drawing.Point(445, 84);
            this.QuitarBtn.Name = "QuitarBtn";
            this.QuitarBtn.Size = new System.Drawing.Size(75, 23);
            this.QuitarBtn.TabIndex = 13;
            this.QuitarBtn.Text = "Quitar";
            this.QuitarBtn.UseVisualStyleBackColor = true;
            this.QuitarBtn.Click += new System.EventHandler(this.QuitarBtn_Click);
            // 
            // rolABM
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(649, 520);
            this.Controls.Add(this.QuitarBtn);
            this.Controls.Add(this.LimpiarBtn);
            this.Controls.Add(this.Habilitado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RolABuscar);
            this.Controls.Add(this.BuscarRol);
            this.Controls.Add(this.ListaDeRoles);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.CrearOUpdatear);
            this.Controls.Add(this.listaFuncionalidadrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FuncionalidadAAgregar);
            this.Name = "rolABM";
            ((System.ComponentModel.ISupportInitialize)(this.ListaDeRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FuncionalidadAAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listaFuncionalidadrs;
        private System.Windows.Forms.Button CrearOUpdatear;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.DataGridView ListaDeRoles;
        private System.Windows.Forms.Button BuscarRol;
        private System.Windows.Forms.TextBox RolABuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Habilitado;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Button QuitarBtn;
    }
}
