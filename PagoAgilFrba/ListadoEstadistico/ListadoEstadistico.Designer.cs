namespace PagoAgilFrba.ListadoEstadistico
{
    partial class ListadoEstadistico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listadoDataGridView = new System.Windows.Forms.DataGridView();
            this.listarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.listadosGroupBox = new System.Windows.Forms.GroupBox();
            this.clientesCumplidoresRadioBtn = new System.Windows.Forms.RadioButton();
            this.clientesRadioBtn = new System.Windows.Forms.RadioButton();
            this.empresasRadioBtn = new System.Windows.Forms.RadioButton();
            this.porcentajeRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.trimestreComboBox = new System.Windows.Forms.ComboBox();
            this.anioLabel = new System.Windows.Forms.Label();
            this.anioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.camposObligatoriosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).BeginInit();
            this.listadosGroupBox.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoDataGridView
            // 
            this.listadoDataGridView.AllowUserToAddRows = false;
            this.listadoDataGridView.AllowUserToDeleteRows = false;
            this.listadoDataGridView.AllowUserToResizeRows = false;
            this.listadoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listadoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDataGridView.Location = new System.Drawing.Point(45, 202);
            this.listadoDataGridView.Name = "listadoDataGridView";
            this.listadoDataGridView.ReadOnly = true;
            this.listadoDataGridView.Size = new System.Drawing.Size(645, 155);
            this.listadoDataGridView.TabIndex = 1;
            // 
            // listarBtn
            // 
            this.listarBtn.Location = new System.Drawing.Point(437, 99);
            this.listarBtn.Name = "listarBtn";
            this.listarBtn.Size = new System.Drawing.Size(174, 37);
            this.listarBtn.TabIndex = 8;
            this.listarBtn.Text = "LISTAR";
            this.listarBtn.UseVisualStyleBackColor = true;
            this.listarBtn.Click += new System.EventHandler(this.listarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(303, 369);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(115, 32);
            this.limpiarBtn.TabIndex = 10;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // listadosGroupBox
            // 
            this.listadosGroupBox.Controls.Add(this.clientesCumplidoresRadioBtn);
            this.listadosGroupBox.Controls.Add(this.clientesRadioBtn);
            this.listadosGroupBox.Controls.Add(this.empresasRadioBtn);
            this.listadosGroupBox.Controls.Add(this.porcentajeRadioBtn);
            this.listadosGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listadosGroupBox.Location = new System.Drawing.Point(24, 19);
            this.listadosGroupBox.Name = "listadosGroupBox";
            this.listadosGroupBox.Size = new System.Drawing.Size(390, 134);
            this.listadosGroupBox.TabIndex = 11;
            this.listadosGroupBox.TabStop = false;
            this.listadosGroupBox.Text = "Seleccionar Listado (*)";
            // 
            // clientesCumplidoresRadioBtn
            // 
            this.clientesCumplidoresRadioBtn.AutoSize = true;
            this.clientesCumplidoresRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.clientesCumplidoresRadioBtn.Location = new System.Drawing.Point(43, 96);
            this.clientesCumplidoresRadioBtn.Name = "clientesCumplidoresRadioBtn";
            this.clientesCumplidoresRadioBtn.Size = new System.Drawing.Size(156, 21);
            this.clientesCumplidoresRadioBtn.TabIndex = 13;
            this.clientesCumplidoresRadioBtn.TabStop = true;
            this.clientesCumplidoresRadioBtn.Text = "Clientes cumplidores";
            this.clientesCumplidoresRadioBtn.UseVisualStyleBackColor = true;
            // 
            // clientesRadioBtn
            // 
            this.clientesRadioBtn.AutoSize = true;
            this.clientesRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.clientesRadioBtn.Location = new System.Drawing.Point(43, 73);
            this.clientesRadioBtn.Name = "clientesRadioBtn";
            this.clientesRadioBtn.Size = new System.Drawing.Size(176, 21);
            this.clientesRadioBtn.TabIndex = 12;
            this.clientesRadioBtn.TabStop = true;
            this.clientesRadioBtn.Text = "Clientes con más pagos";
            this.clientesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // empresasRadioBtn
            // 
            this.empresasRadioBtn.AutoSize = true;
            this.empresasRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.empresasRadioBtn.Location = new System.Drawing.Point(43, 51);
            this.empresasRadioBtn.Name = "empresasRadioBtn";
            this.empresasRadioBtn.Size = new System.Drawing.Size(254, 21);
            this.empresasRadioBtn.TabIndex = 11;
            this.empresasRadioBtn.TabStop = true;
            this.empresasRadioBtn.Text = "Empresas con mayor monto rendido";
            this.empresasRadioBtn.UseVisualStyleBackColor = true;
            // 
            // porcentajeRadioBtn
            // 
            this.porcentajeRadioBtn.AutoSize = true;
            this.porcentajeRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.porcentajeRadioBtn.Location = new System.Drawing.Point(43, 28);
            this.porcentajeRadioBtn.Name = "porcentajeRadioBtn";
            this.porcentajeRadioBtn.Size = new System.Drawing.Size(316, 21);
            this.porcentajeRadioBtn.TabIndex = 10;
            this.porcentajeRadioBtn.TabStop = true;
            this.porcentajeRadioBtn.Text = "Porcentaje de facturas cobradas por empresa";
            this.porcentajeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.trimestreComboBox);
            this.groupBox.Controls.Add(this.anioLabel);
            this.groupBox.Controls.Add(this.anioTextBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.listadosGroupBox);
            this.groupBox.Controls.Add(this.listarBtn);
            this.groupBox.Location = new System.Drawing.Point(45, 25);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(645, 171);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            // 
            // trimestreComboBox
            // 
            this.trimestreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trimestreComboBox.FormattingEnabled = true;
            this.trimestreComboBox.Items.AddRange(new object[] {
            "(ninguno)",
            "1",
            "2",
            "3",
            "4"});
            this.trimestreComboBox.Location = new System.Drawing.Point(490, 37);
            this.trimestreComboBox.Name = "trimestreComboBox";
            this.trimestreComboBox.Size = new System.Drawing.Size(121, 21);
            this.trimestreComboBox.TabIndex = 12;
            this.trimestreComboBox.SelectedIndexChanged += new System.EventHandler(this.trimestreComboBox_SelectedIndexChanged);
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Location = new System.Drawing.Point(445, 67);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(39, 13);
            this.anioLabel.TabIndex = 15;
            this.anioLabel.Text = "Año (*)";
            // 
            // anioTextBox
            // 
            this.anioTextBox.Location = new System.Drawing.Point(490, 64);
            this.anioTextBox.MaxLength = 4;
            this.anioTextBox.Name = "anioTextBox";
            this.anioTextBox.Size = new System.Drawing.Size(72, 20);
            this.anioTextBox.TabIndex = 14;
            this.anioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anioTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Trimestre (*)";
            // 
            // camposObligatoriosLabel
            // 
            this.camposObligatoriosLabel.AutoSize = true;
            this.camposObligatoriosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.camposObligatoriosLabel.Location = new System.Drawing.Point(568, 387);
            this.camposObligatoriosLabel.Name = "camposObligatoriosLabel";
            this.camposObligatoriosLabel.Size = new System.Drawing.Size(158, 17);
            this.camposObligatoriosLabel.TabIndex = 33;
            this.camposObligatoriosLabel.Text = "Campos Obligatorios (*)";
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 413);
            this.Controls.Add(this.camposObligatoriosLabel);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.listadoDataGridView);
            this.Controls.Add(this.groupBox);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadístico";
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).EndInit();
            this.listadosGroupBox.ResumeLayout(false);
            this.listadosGroupBox.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoDataGridView;
        private System.Windows.Forms.Button listarBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.GroupBox listadosGroupBox;
        private System.Windows.Forms.RadioButton clientesCumplidoresRadioBtn;
        private System.Windows.Forms.RadioButton clientesRadioBtn;
        private System.Windows.Forms.RadioButton empresasRadioBtn;
        private System.Windows.Forms.RadioButton porcentajeRadioBtn;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox trimestreComboBox;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.TextBox anioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label camposObligatoriosLabel;
    }
}