﻿namespace PagoAgilFrba.Devolucion
{
    partial class Devolucion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clienteGroupBox = new System.Windows.Forms.GroupBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.seleccionarClienteBtn = new System.Windows.Forms.Button();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.numFactLabelL = new System.Windows.Forms.Label();
            this.numFactFilterTextBoxL = new System.Windows.Forms.TextBox();
            this.empresaComboBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.facturasADevolverLabel = new System.Windows.Forms.Label();
            this.agregarABtn = new System.Windows.Forms.Button();
            this.facturasADevolverDataGrid = new System.Windows.Forms.DataGridView();
            this.NumFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturasLabel = new System.Windows.Forms.Label();
            this.facturasDataGrid = new System.Windows.Forms.DataGridView();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.devolucionGroupBox = new System.Windows.Forms.GroupBox();
            this.limpiarDevBtn = new System.Windows.Forms.Button();
            this.devolverBtn = new System.Windows.Forms.Button();
            this.motivoLabel = new System.Windows.Forms.Label();
            this.fechaRendDT = new System.Windows.Forms.DateTimePicker();
            this.fechaDevLabel = new System.Windows.Forms.Label();
            this.motivoTextBox = new System.Windows.Forms.TextBox();
            this.camposObligLabel = new System.Windows.Forms.Label();
            this.obligLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.clienteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasADevolverDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGrid)).BeginInit();
            this.devolucionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clienteGroupBox);
            this.groupBox1.Controls.Add(this.numFactLabelL);
            this.groupBox1.Controls.Add(this.numFactFilterTextBoxL);
            this.groupBox1.Controls.Add(this.empresaComboBox);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterio de Búsqueda";
            // 
            // clienteGroupBox
            // 
            this.clienteGroupBox.Controls.Add(this.idClienteTextBox);
            this.clienteGroupBox.Controls.Add(this.seleccionarClienteBtn);
            this.clienteGroupBox.Controls.Add(this.clienteTextBox);
            this.clienteGroupBox.Location = new System.Drawing.Point(62, 65);
            this.clienteGroupBox.Name = "clienteGroupBox";
            this.clienteGroupBox.Size = new System.Drawing.Size(291, 54);
            this.clienteGroupBox.TabIndex = 2;
            this.clienteGroupBox.TabStop = false;
            this.clienteGroupBox.Text = "Cliente";
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.Enabled = false;
            this.idClienteTextBox.Location = new System.Drawing.Point(6, 18);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(37, 20);
            this.idClienteTextBox.TabIndex = 27;
            // 
            // seleccionarClienteBtn
            // 
            this.seleccionarClienteBtn.Location = new System.Drawing.Point(204, 18);
            this.seleccionarClienteBtn.Name = "seleccionarClienteBtn";
            this.seleccionarClienteBtn.Size = new System.Drawing.Size(76, 20);
            this.seleccionarClienteBtn.TabIndex = 2;
            this.seleccionarClienteBtn.Text = "Seleccionar";
            this.seleccionarClienteBtn.UseVisualStyleBackColor = true;
            this.seleccionarClienteBtn.Click += new System.EventHandler(this.seleccionarClienteBtn_Click);
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Enabled = false;
            this.clienteTextBox.Location = new System.Drawing.Point(45, 18);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(158, 20);
            this.clienteTextBox.TabIndex = 23;
            // 
            // numFactLabelL
            // 
            this.numFactLabelL.AutoSize = true;
            this.numFactLabelL.Location = new System.Drawing.Point(97, 33);
            this.numFactLabelL.Name = "numFactLabelL";
            this.numFactLabelL.Size = new System.Drawing.Size(98, 13);
            this.numFactLabelL.TabIndex = 17;
            this.numFactLabelL.Text = "Número de Factura";
            // 
            // numFactFilterTextBoxL
            // 
            this.numFactFilterTextBoxL.Location = new System.Drawing.Point(208, 30);
            this.numFactFilterTextBoxL.Name = "numFactFilterTextBoxL";
            this.numFactFilterTextBoxL.Size = new System.Drawing.Size(121, 20);
            this.numFactFilterTextBoxL.TabIndex = 1;
            this.numFactFilterTextBoxL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFactFilterTextBoxL_KeyPress);
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(494, 29);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(142, 21);
            this.empresaComboBox.TabIndex = 3;
            this.empresaComboBox.SelectedIndexChanged += new System.EventHandler(this.empresaComboBox_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(452, 74);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(184, 36);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Empresa";
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.eliminarBtn.Location = new System.Drawing.Point(399, 264);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(50, 32);
            this.eliminarBtn.TabIndex = 6;
            this.eliminarBtn.Text = "X";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // facturasADevolverLabel
            // 
            this.facturasADevolverLabel.AutoSize = true;
            this.facturasADevolverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.facturasADevolverLabel.Location = new System.Drawing.Point(452, 164);
            this.facturasADevolverLabel.Name = "facturasADevolverLabel";
            this.facturasADevolverLabel.Size = new System.Drawing.Size(133, 17);
            this.facturasADevolverLabel.TabIndex = 38;
            this.facturasADevolverLabel.Text = "Facturas a devolver";
            // 
            // agregarABtn
            // 
            this.agregarABtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.agregarABtn.Location = new System.Drawing.Point(401, 221);
            this.agregarABtn.Name = "agregarABtn";
            this.agregarABtn.Size = new System.Drawing.Size(48, 37);
            this.agregarABtn.TabIndex = 5;
            this.agregarABtn.Text = "=>";
            this.agregarABtn.UseVisualStyleBackColor = true;
            this.agregarABtn.Click += new System.EventHandler(this.agregarABtn_Click);
            // 
            // facturasADevolverDataGrid
            // 
            this.facturasADevolverDataGrid.AllowUserToAddRows = false;
            this.facturasADevolverDataGrid.AllowUserToDeleteRows = false;
            this.facturasADevolverDataGrid.AllowUserToResizeColumns = false;
            this.facturasADevolverDataGrid.AllowUserToResizeRows = false;
            this.facturasADevolverDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.facturasADevolverDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasADevolverDataGrid.ColumnHeadersVisible = false;
            this.facturasADevolverDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumFact,
            this.Empresa,
            this.Total,
            this.fechaAlta,
            this.fechaVencimiento});
            this.facturasADevolverDataGrid.Location = new System.Drawing.Point(455, 184);
            this.facturasADevolverDataGrid.Name = "facturasADevolverDataGrid";
            this.facturasADevolverDataGrid.ReadOnly = true;
            this.facturasADevolverDataGrid.Size = new System.Drawing.Size(360, 159);
            this.facturasADevolverDataGrid.TabIndex = 36;
            // 
            // NumFact
            // 
            this.NumFact.HeaderText = "Num Fact";
            this.NumFact.Name = "NumFact";
            this.NumFact.ReadOnly = true;
            this.NumFact.Width = 5;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 5;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 5;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "Fecha Alta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            this.fechaAlta.Width = 5;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.HeaderText = "Fecha Venc";
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.ReadOnly = true;
            this.fechaVencimiento.Width = 5;
            // 
            // facturasLabel
            // 
            this.facturasLabel.AutoSize = true;
            this.facturasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.facturasLabel.Location = new System.Drawing.Point(42, 164);
            this.facturasLabel.Name = "facturasLabel";
            this.facturasLabel.Size = new System.Drawing.Size(122, 17);
            this.facturasLabel.TabIndex = 35;
            this.facturasLabel.Text = "Facturas pagadas";
            // 
            // facturasDataGrid
            // 
            this.facturasDataGrid.AllowUserToAddRows = false;
            this.facturasDataGrid.AllowUserToDeleteRows = false;
            this.facturasDataGrid.AllowUserToResizeRows = false;
            this.facturasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.facturasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasDataGrid.Location = new System.Drawing.Point(45, 184);
            this.facturasDataGrid.Name = "facturasDataGrid";
            this.facturasDataGrid.ReadOnly = true;
            this.facturasDataGrid.Size = new System.Drawing.Size(350, 159);
            this.facturasDataGrid.TabIndex = 34;
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(383, 535);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(111, 31);
            this.limpiarBtn.TabIndex = 10;
            this.limpiarBtn.Text = "Limpiar Todo";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // devolucionGroupBox
            // 
            this.devolucionGroupBox.Controls.Add(this.obligLabel);
            this.devolucionGroupBox.Controls.Add(this.limpiarDevBtn);
            this.devolucionGroupBox.Controls.Add(this.devolverBtn);
            this.devolucionGroupBox.Controls.Add(this.motivoLabel);
            this.devolucionGroupBox.Controls.Add(this.fechaRendDT);
            this.devolucionGroupBox.Controls.Add(this.fechaDevLabel);
            this.devolucionGroupBox.Controls.Add(this.motivoTextBox);
            this.devolucionGroupBox.Location = new System.Drawing.Point(45, 374);
            this.devolucionGroupBox.Name = "devolucionGroupBox";
            this.devolucionGroupBox.Size = new System.Drawing.Size(770, 146);
            this.devolucionGroupBox.TabIndex = 7;
            this.devolucionGroupBox.TabStop = false;
            this.devolucionGroupBox.Text = "Devolucion";
            // 
            // limpiarDevBtn
            // 
            this.limpiarDevBtn.Location = new System.Drawing.Point(695, 123);
            this.limpiarDevBtn.Name = "limpiarDevBtn";
            this.limpiarDevBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarDevBtn.TabIndex = 9;
            this.limpiarDevBtn.Text = "Limpiar";
            this.limpiarDevBtn.UseVisualStyleBackColor = true;
            this.limpiarDevBtn.Click += new System.EventHandler(this.limpiarDevBtn_Click);
            // 
            // devolverBtn
            // 
            this.devolverBtn.Enabled = false;
            this.devolverBtn.Location = new System.Drawing.Point(528, 51);
            this.devolverBtn.Name = "devolverBtn";
            this.devolverBtn.Size = new System.Drawing.Size(196, 41);
            this.devolverBtn.TabIndex = 8;
            this.devolverBtn.Text = "Devolver";
            this.devolverBtn.UseVisualStyleBackColor = true;
            this.devolverBtn.Click += new System.EventHandler(this.devolverBtn_Click);
            // 
            // motivoLabel
            // 
            this.motivoLabel.AutoSize = true;
            this.motivoLabel.Location = new System.Drawing.Point(94, 65);
            this.motivoLabel.Name = "motivoLabel";
            this.motivoLabel.Size = new System.Drawing.Size(39, 13);
            this.motivoLabel.TabIndex = 32;
            this.motivoLabel.Text = "Motivo";
            // 
            // fechaRendDT
            // 
            this.fechaRendDT.Enabled = false;
            this.fechaRendDT.Location = new System.Drawing.Point(166, 23);
            this.fechaRendDT.Name = "fechaRendDT";
            this.fechaRendDT.Size = new System.Drawing.Size(283, 20);
            this.fechaRendDT.TabIndex = 30;
            // 
            // fechaDevLabel
            // 
            this.fechaDevLabel.AutoSize = true;
            this.fechaDevLabel.Location = new System.Drawing.Point(46, 26);
            this.fechaDevLabel.Name = "fechaDevLabel";
            this.fechaDevLabel.Size = new System.Drawing.Size(107, 13);
            this.fechaDevLabel.TabIndex = 31;
            this.fechaDevLabel.Text = "Fecha de devolución";
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.Location = new System.Drawing.Point(166, 62);
            this.motivoTextBox.Multiline = true;
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(283, 78);
            this.motivoTextBox.TabIndex = 7;
            // 
            // camposObligLabel
            // 
            this.camposObligLabel.AutoSize = true;
            this.camposObligLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.camposObligLabel.Location = new System.Drawing.Point(714, 552);
            this.camposObligLabel.Name = "camposObligLabel";
            this.camposObligLabel.Size = new System.Drawing.Size(158, 17);
            this.camposObligLabel.TabIndex = 39;
            this.camposObligLabel.Text = "Campos Obligatorios (*)";
            // 
            // obligLabel
            // 
            this.obligLabel.AutoSize = true;
            this.obligLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.obligLabel.Location = new System.Drawing.Point(136, 61);
            this.obligLabel.Name = "obligLabel";
            this.obligLabel.Size = new System.Drawing.Size(24, 18);
            this.obligLabel.TabIndex = 33;
            this.obligLabel.Text = "(*)";
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 578);
            this.Controls.Add(this.camposObligLabel);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.devolucionGroupBox);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.facturasADevolverLabel);
            this.Controls.Add(this.agregarABtn);
            this.Controls.Add(this.facturasADevolverDataGrid);
            this.Controls.Add(this.facturasLabel);
            this.Controls.Add(this.facturasDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "Devolucion";
            this.Text = "Devolución";
            this.Activated += new System.EventHandler(this.Devolucion_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.clienteGroupBox.ResumeLayout(false);
            this.clienteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasADevolverDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGrid)).EndInit();
            this.devolucionGroupBox.ResumeLayout(false);
            this.devolucionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox clienteGroupBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.Button seleccionarClienteBtn;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.Label numFactLabelL;
        private System.Windows.Forms.TextBox numFactFilterTextBoxL;
        private System.Windows.Forms.ComboBox empresaComboBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Label facturasADevolverLabel;
        private System.Windows.Forms.Button agregarABtn;
        private System.Windows.Forms.DataGridView facturasADevolverDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private System.Windows.Forms.Label facturasLabel;
        private System.Windows.Forms.DataGridView facturasDataGrid;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.GroupBox devolucionGroupBox;
        private System.Windows.Forms.Button limpiarDevBtn;
        private System.Windows.Forms.Button devolverBtn;
        private System.Windows.Forms.Label motivoLabel;
        private System.Windows.Forms.DateTimePicker fechaRendDT;
        private System.Windows.Forms.Label fechaDevLabel;
        private System.Windows.Forms.TextBox motivoTextBox;
        private System.Windows.Forms.Label obligLabel;
        private System.Windows.Forms.Label camposObligLabel;
    }
}