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
            this.funcionalidadesComboBox = new System.Windows.Forms.ComboBox();
            this.funcionalidadesLabel = new System.Windows.Forms.Label();
            this.rolTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.funcionalidadesListView = new System.Windows.Forms.ListView();
            this.crearOrUpdateBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.rolesDataGridView = new System.Windows.Forms.DataGridView();
            this.habilitadoCheckBox = new System.Windows.Forms.CheckBox();
            this.quitarBtn = new System.Windows.Forms.Button();
            this.habilitadoLabel = new System.Windows.Forms.Label();
            this.criterioDeBusquedaGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rolFilterTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).BeginInit();
            this.criterioDeBusquedaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcionalidadesComboBox
            // 
            this.funcionalidadesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcionalidadesComboBox.FormattingEnabled = true;
            this.funcionalidadesComboBox.Location = new System.Drawing.Point(350, 14);
            this.funcionalidadesComboBox.Name = "funcionalidadesComboBox";
            this.funcionalidadesComboBox.Size = new System.Drawing.Size(121, 21);
            this.funcionalidadesComboBox.TabIndex = 3;
            // 
            // funcionalidadesLabel
            // 
            this.funcionalidadesLabel.AutoSize = true;
            this.funcionalidadesLabel.Location = new System.Drawing.Point(260, 17);
            this.funcionalidadesLabel.Name = "funcionalidadesLabel";
            this.funcionalidadesLabel.Size = new System.Drawing.Size(84, 13);
            this.funcionalidadesLabel.TabIndex = 1;
            this.funcionalidadesLabel.Text = "Funcionalidades";
            // 
            // rolTextBox
            // 
            this.rolTextBox.Location = new System.Drawing.Point(61, 15);
            this.rolTextBox.Name = "rolTextBox";
            this.rolTextBox.Size = new System.Drawing.Size(111, 20);
            this.rolTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rol";
            // 
            // funcionalidadesListView
            // 
            this.funcionalidadesListView.GridLines = true;
            this.funcionalidadesListView.Location = new System.Drawing.Point(262, 45);
            this.funcionalidadesListView.Name = "funcionalidadesListView";
            this.funcionalidadesListView.Size = new System.Drawing.Size(209, 97);
            this.funcionalidadesListView.TabIndex = 4;
            this.funcionalidadesListView.UseCompatibleStateImageBehavior = false;
            this.funcionalidadesListView.View = System.Windows.Forms.View.List;
            // 
            // crearOrUpdateBtn
            // 
            this.crearOrUpdateBtn.Location = new System.Drawing.Point(350, 148);
            this.crearOrUpdateBtn.Name = "crearOrUpdateBtn";
            this.crearOrUpdateBtn.Size = new System.Drawing.Size(121, 27);
            this.crearOrUpdateBtn.TabIndex = 7;
            this.crearOrUpdateBtn.Text = "Crear";
            this.crearOrUpdateBtn.UseVisualStyleBackColor = true;
            this.crearOrUpdateBtn.Click += new System.EventHandler(this.Crear_Click);
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(477, 45);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(84, 25);
            this.agregarBtn.TabIndex = 5;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // rolesDataGridView
            // 
            this.rolesDataGridView.AllowUserToAddRows = false;
            this.rolesDataGridView.AllowUserToDeleteRows = false;
            this.rolesDataGridView.AllowUserToResizeColumns = false;
            this.rolesDataGridView.AllowUserToResizeRows = false;
            this.rolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesDataGridView.Location = new System.Drawing.Point(37, 259);
            this.rolesDataGridView.Name = "rolesDataGridView";
            this.rolesDataGridView.ReadOnly = true;
            this.rolesDataGridView.Size = new System.Drawing.Size(527, 118);
            this.rolesDataGridView.TabIndex = 7;
            this.rolesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDeRoles_CellDoubleClick);
            // 
            // habilitadoCheckBox
            // 
            this.habilitadoCheckBox.AutoSize = true;
            this.habilitadoCheckBox.Location = new System.Drawing.Point(87, 63);
            this.habilitadoCheckBox.Name = "habilitadoCheckBox";
            this.habilitadoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.habilitadoCheckBox.TabIndex = 2;
            this.habilitadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // quitarBtn
            // 
            this.quitarBtn.Location = new System.Drawing.Point(477, 76);
            this.quitarBtn.Name = "quitarBtn";
            this.quitarBtn.Size = new System.Drawing.Size(84, 25);
            this.quitarBtn.TabIndex = 6;
            this.quitarBtn.Text = "Quitar";
            this.quitarBtn.UseVisualStyleBackColor = true;
            this.quitarBtn.Click += new System.EventHandler(this.QuitarBtn_Click);
            // 
            // habilitadoLabel
            // 
            this.habilitadoLabel.AutoSize = true;
            this.habilitadoLabel.Location = new System.Drawing.Point(30, 64);
            this.habilitadoLabel.Name = "habilitadoLabel";
            this.habilitadoLabel.Size = new System.Drawing.Size(54, 13);
            this.habilitadoLabel.TabIndex = 14;
            this.habilitadoLabel.Text = "Habilitado";
            // 
            // criterioDeBusquedaGroupBox
            // 
            this.criterioDeBusquedaGroupBox.Controls.Add(this.label3);
            this.criterioDeBusquedaGroupBox.Controls.Add(this.rolFilterTextBox);
            this.criterioDeBusquedaGroupBox.Controls.Add(this.searchBtn);
            this.criterioDeBusquedaGroupBox.Location = new System.Drawing.Point(37, 183);
            this.criterioDeBusquedaGroupBox.Name = "criterioDeBusquedaGroupBox";
            this.criterioDeBusquedaGroupBox.Size = new System.Drawing.Size(527, 70);
            this.criterioDeBusquedaGroupBox.TabIndex = 8;
            this.criterioDeBusquedaGroupBox.TabStop = false;
            this.criterioDeBusquedaGroupBox.Text = "Criterio De Búsqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rol";
            // 
            // rolFilterTextBox
            // 
            this.rolFilterTextBox.Location = new System.Drawing.Point(127, 28);
            this.rolFilterTextBox.Name = "rolFilterTextBox";
            this.rolFilterTextBox.Size = new System.Drawing.Size(137, 20);
            this.rolFilterTextBox.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(386, 20);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(122, 34);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(249, 383);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(108, 34);
            this.limpiarBtn.TabIndex = 10;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(434, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Campos Obligatorios (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(178, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(108, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(231, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "(*)";
            // 
            // rolABM
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(601, 437);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.criterioDeBusquedaGroupBox);
            this.Controls.Add(this.habilitadoLabel);
            this.Controls.Add(this.quitarBtn);
            this.Controls.Add(this.habilitadoCheckBox);
            this.Controls.Add(this.rolesDataGridView);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.crearOrUpdateBtn);
            this.Controls.Add(this.funcionalidadesListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rolTextBox);
            this.Controls.Add(this.funcionalidadesLabel);
            this.Controls.Add(this.funcionalidadesComboBox);
            this.Name = "rolABM";
            this.Text = "ABM Rol";
            this.Activated += new System.EventHandler(this.rolABM_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).EndInit();
            this.criterioDeBusquedaGroupBox.ResumeLayout(false);
            this.criterioDeBusquedaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox funcionalidadesComboBox;
        private System.Windows.Forms.Label funcionalidadesLabel;
        private System.Windows.Forms.TextBox rolTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView funcionalidadesListView;
        private System.Windows.Forms.Button crearOrUpdateBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.DataGridView rolesDataGridView;
        private System.Windows.Forms.CheckBox habilitadoCheckBox;
        private System.Windows.Forms.Button quitarBtn;
        private System.Windows.Forms.Label habilitadoLabel;
        private System.Windows.Forms.GroupBox criterioDeBusquedaGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rolFilterTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
