﻿namespace PagoAgilFrba.RegistroPago
{
    partial class RegistroPago
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
            this.facturasDataGridL = new System.Windows.Forms.DataGridView();
            this.cobrarGroupBox = new System.Windows.Forms.GroupBox();
            this.formaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaCobroDT = new System.Windows.Forms.DateTimePicker();
            this.formaDePagoLabel = new System.Windows.Forms.Label();
            this.clienteTxt = new System.Windows.Forms.TextBox();
            this.sucursalTextBox = new System.Windows.Forms.TextBox();
            this.clienteLabel2 = new System.Windows.Forms.Label();
            this.sucursalLabel = new System.Windows.Forms.Label();
            this.importeFilterLabel = new System.Windows.Forms.Label();
            this.cobrarBtn = new System.Windows.Forms.Button();
            this.importeCobroTextBox = new System.Windows.Forms.TextBox();
            this.filtrarGroupBox = new System.Windows.Forms.GroupBox();
            this.clienteGroupBox = new System.Windows.Forms.GroupBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.seleccionarClienteBtn = new System.Windows.Forms.Button();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.numFactLabelL = new System.Windows.Forms.Label();
            this.numFactFilterTextBoxL = new System.Windows.Forms.TextBox();
            this.empresaFilterComboBox = new System.Windows.Forms.ComboBox();
            this.searchBtnL = new System.Windows.Forms.Button();
            this.empresaFilterLabel = new System.Windows.Forms.Label();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.facturasLabel = new System.Windows.Forms.Label();
            this.limpiarFiltrosBtn = new System.Windows.Forms.Button();
            this.limpiarCobroBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGridL)).BeginInit();
            this.cobrarGroupBox.SuspendLayout();
            this.filtrarGroupBox.SuspendLayout();
            this.clienteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // facturasDataGridL
            // 
            this.facturasDataGridL.AllowUserToAddRows = false;
            this.facturasDataGridL.AllowUserToDeleteRows = false;
            this.facturasDataGridL.AllowUserToResizeRows = false;
            this.facturasDataGridL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasDataGridL.Location = new System.Drawing.Point(47, 154);
            this.facturasDataGridL.Name = "facturasDataGridL";
            this.facturasDataGridL.ReadOnly = true;
            this.facturasDataGridL.Size = new System.Drawing.Size(770, 197);
            this.facturasDataGridL.TabIndex = 15;
            // 
            // cobrarGroupBox
            // 
            this.cobrarGroupBox.Controls.Add(this.limpiarCobroBtn);
            this.cobrarGroupBox.Controls.Add(this.formaPagoComboBox);
            this.cobrarGroupBox.Controls.Add(this.label1);
            this.cobrarGroupBox.Controls.Add(this.fechaCobroDT);
            this.cobrarGroupBox.Controls.Add(this.formaDePagoLabel);
            this.cobrarGroupBox.Controls.Add(this.clienteTxt);
            this.cobrarGroupBox.Controls.Add(this.sucursalTextBox);
            this.cobrarGroupBox.Controls.Add(this.clienteLabel2);
            this.cobrarGroupBox.Controls.Add(this.sucursalLabel);
            this.cobrarGroupBox.Controls.Add(this.importeFilterLabel);
            this.cobrarGroupBox.Controls.Add(this.cobrarBtn);
            this.cobrarGroupBox.Controls.Add(this.importeCobroTextBox);
            this.cobrarGroupBox.Location = new System.Drawing.Point(47, 357);
            this.cobrarGroupBox.Name = "cobrarGroupBox";
            this.cobrarGroupBox.Size = new System.Drawing.Size(770, 143);
            this.cobrarGroupBox.TabIndex = 14;
            this.cobrarGroupBox.TabStop = false;
            this.cobrarGroupBox.Text = "Cobrar Facturas";
            // 
            // formaPagoComboBox
            // 
            this.formaPagoComboBox.FormattingEnabled = true;
            this.formaPagoComboBox.Location = new System.Drawing.Point(102, 29);
            this.formaPagoComboBox.Name = "formaPagoComboBox";
            this.formaPagoComboBox.Size = new System.Drawing.Size(121, 21);
            this.formaPagoComboBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha de Cobro";
            // 
            // fechaCobroDT
            // 
            this.fechaCobroDT.Enabled = false;
            this.fechaCobroDT.Location = new System.Drawing.Point(339, 70);
            this.fechaCobroDT.Name = "fechaCobroDT";
            this.fechaCobroDT.Size = new System.Drawing.Size(200, 20);
            this.fechaCobroDT.TabIndex = 23;
            // 
            // formaDePagoLabel
            // 
            this.formaDePagoLabel.AutoSize = true;
            this.formaDePagoLabel.Location = new System.Drawing.Point(17, 29);
            this.formaDePagoLabel.Name = "formaDePagoLabel";
            this.formaDePagoLabel.Size = new System.Drawing.Size(79, 13);
            this.formaDePagoLabel.TabIndex = 22;
            this.formaDePagoLabel.Text = "Forma de Pago";
            // 
            // clienteTxt
            // 
            this.clienteTxt.Enabled = false;
            this.clienteTxt.Location = new System.Drawing.Point(102, 67);
            this.clienteTxt.Name = "clienteTxt";
            this.clienteTxt.Size = new System.Drawing.Size(121, 20);
            this.clienteTxt.TabIndex = 20;
            // 
            // sucursalTextBox
            // 
            this.sucursalTextBox.Enabled = false;
            this.sucursalTextBox.Location = new System.Drawing.Point(339, 30);
            this.sucursalTextBox.Name = "sucursalTextBox";
            this.sucursalTextBox.Size = new System.Drawing.Size(200, 20);
            this.sucursalTextBox.TabIndex = 19;
            // 
            // clienteLabel2
            // 
            this.clienteLabel2.AutoSize = true;
            this.clienteLabel2.Location = new System.Drawing.Point(54, 70);
            this.clienteLabel2.Name = "clienteLabel2";
            this.clienteLabel2.Size = new System.Drawing.Size(42, 13);
            this.clienteLabel2.TabIndex = 18;
            this.clienteLabel2.Text = "Cliente:";
            // 
            // sucursalLabel
            // 
            this.sucursalLabel.AutoSize = true;
            this.sucursalLabel.Location = new System.Drawing.Point(282, 33);
            this.sucursalLabel.Name = "sucursalLabel";
            this.sucursalLabel.Size = new System.Drawing.Size(51, 13);
            this.sucursalLabel.TabIndex = 14;
            this.sucursalLabel.Text = "Sucursal:";
            // 
            // importeFilterLabel
            // 
            this.importeFilterLabel.AutoSize = true;
            this.importeFilterLabel.Location = new System.Drawing.Point(594, 32);
            this.importeFilterLabel.Name = "importeFilterLabel";
            this.importeFilterLabel.Size = new System.Drawing.Size(42, 13);
            this.importeFilterLabel.TabIndex = 1;
            this.importeFilterLabel.Text = "Importe";
            // 
            // cobrarBtn
            // 
            this.cobrarBtn.Location = new System.Drawing.Point(597, 66);
            this.cobrarBtn.Name = "cobrarBtn";
            this.cobrarBtn.Size = new System.Drawing.Size(145, 32);
            this.cobrarBtn.TabIndex = 10;
            this.cobrarBtn.Text = "Cobrar";
            this.cobrarBtn.UseVisualStyleBackColor = true;
            this.cobrarBtn.Click += new System.EventHandler(this.cobrarBtn_Click);
            // 
            // importeCobroTextBox
            // 
            this.importeCobroTextBox.Enabled = false;
            this.importeCobroTextBox.Location = new System.Drawing.Point(642, 29);
            this.importeCobroTextBox.Name = "importeCobroTextBox";
            this.importeCobroTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeCobroTextBox.TabIndex = 0;
            // 
            // filtrarGroupBox
            // 
            this.filtrarGroupBox.Controls.Add(this.limpiarFiltrosBtn);
            this.filtrarGroupBox.Controls.Add(this.clienteGroupBox);
            this.filtrarGroupBox.Controls.Add(this.numFactLabelL);
            this.filtrarGroupBox.Controls.Add(this.numFactFilterTextBoxL);
            this.filtrarGroupBox.Controls.Add(this.empresaFilterComboBox);
            this.filtrarGroupBox.Controls.Add(this.searchBtnL);
            this.filtrarGroupBox.Controls.Add(this.empresaFilterLabel);
            this.filtrarGroupBox.Location = new System.Drawing.Point(47, 12);
            this.filtrarGroupBox.Name = "filtrarGroupBox";
            this.filtrarGroupBox.Size = new System.Drawing.Size(770, 125);
            this.filtrarGroupBox.TabIndex = 18;
            this.filtrarGroupBox.TabStop = false;
            this.filtrarGroupBox.Text = "Criterio de Búsqueda";
            // 
            // clienteGroupBox
            // 
            this.clienteGroupBox.Controls.Add(this.idClienteTextBox);
            this.clienteGroupBox.Controls.Add(this.seleccionarClienteBtn);
            this.clienteGroupBox.Controls.Add(this.clienteTextBox);
            this.clienteGroupBox.Location = new System.Drawing.Point(66, 61);
            this.clienteGroupBox.Name = "clienteGroupBox";
            this.clienteGroupBox.Size = new System.Drawing.Size(291, 54);
            this.clienteGroupBox.TabIndex = 26;
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
            this.seleccionarClienteBtn.TabIndex = 24;
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
            this.numFactLabelL.Location = new System.Drawing.Point(81, 28);
            this.numFactLabelL.Name = "numFactLabelL";
            this.numFactLabelL.Size = new System.Drawing.Size(98, 13);
            this.numFactLabelL.TabIndex = 17;
            this.numFactLabelL.Text = "Número de Factura";
            // 
            // numFactFilterTextBoxL
            // 
            this.numFactFilterTextBoxL.Location = new System.Drawing.Point(192, 25);
            this.numFactFilterTextBoxL.Name = "numFactFilterTextBoxL";
            this.numFactFilterTextBoxL.Size = new System.Drawing.Size(121, 20);
            this.numFactFilterTextBoxL.TabIndex = 16;
            // 
            // empresaFilterComboBox
            // 
            this.empresaFilterComboBox.FormattingEnabled = true;
            this.empresaFilterComboBox.Location = new System.Drawing.Point(470, 27);
            this.empresaFilterComboBox.Name = "empresaFilterComboBox";
            this.empresaFilterComboBox.Size = new System.Drawing.Size(142, 21);
            this.empresaFilterComboBox.TabIndex = 19;
            // 
            // searchBtnL
            // 
            this.searchBtnL.Location = new System.Drawing.Point(420, 71);
            this.searchBtnL.Name = "searchBtnL";
            this.searchBtnL.Size = new System.Drawing.Size(192, 35);
            this.searchBtnL.TabIndex = 18;
            this.searchBtnL.Text = "Buscar";
            this.searchBtnL.UseVisualStyleBackColor = true;
            this.searchBtnL.Click += new System.EventHandler(this.searchBtnL_Click);
            // 
            // empresaFilterLabel
            // 
            this.empresaFilterLabel.AutoSize = true;
            this.empresaFilterLabel.Location = new System.Drawing.Point(407, 30);
            this.empresaFilterLabel.Name = "empresaFilterLabel";
            this.empresaFilterLabel.Size = new System.Drawing.Size(48, 13);
            this.empresaFilterLabel.TabIndex = 20;
            this.empresaFilterLabel.Text = "Empresa";
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(324, 506);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(111, 31);
            this.limpiarBtn.TabIndex = 19;
            this.limpiarBtn.Text = "Limpiar Todo";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // facturasLabel
            // 
            this.facturasLabel.AutoSize = true;
            this.facturasLabel.Location = new System.Drawing.Point(53, 138);
            this.facturasLabel.Name = "facturasLabel";
            this.facturasLabel.Size = new System.Drawing.Size(91, 13);
            this.facturasLabel.TabIndex = 20;
            this.facturasLabel.Text = "Facturas sin pago";
            // 
            // limpiarFiltrosBtn
            // 
            this.limpiarFiltrosBtn.Location = new System.Drawing.Point(695, 102);
            this.limpiarFiltrosBtn.Name = "limpiarFiltrosBtn";
            this.limpiarFiltrosBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarFiltrosBtn.TabIndex = 27;
            this.limpiarFiltrosBtn.Text = "Limpiar";
            this.limpiarFiltrosBtn.UseVisualStyleBackColor = true;
            this.limpiarFiltrosBtn.Click += new System.EventHandler(this.limpiarFiltrosBtn_Click);
            // 
            // limpiarCobroBtn
            // 
            this.limpiarCobroBtn.Location = new System.Drawing.Point(695, 120);
            this.limpiarCobroBtn.Name = "limpiarCobroBtn";
            this.limpiarCobroBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarCobroBtn.TabIndex = 29;
            this.limpiarCobroBtn.Text = "Limpiar";
            this.limpiarCobroBtn.UseVisualStyleBackColor = true;
            this.limpiarCobroBtn.Click += new System.EventHandler(this.limpiarCobroBtn_Click);
            // 
            // RegistroPago
            // 
            this.ClientSize = new System.Drawing.Size(856, 559);
            this.Controls.Add(this.facturasLabel);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.filtrarGroupBox);
            this.Controls.Add(this.facturasDataGridL);
            this.Controls.Add(this.cobrarGroupBox);
            this.Name = "RegistroPago";
            this.Text = "Registrar Pago";
            this.Load += new System.EventHandler(this.RegistroPago_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGridL)).EndInit();
            this.cobrarGroupBox.ResumeLayout(false);
            this.cobrarGroupBox.PerformLayout();
            this.filtrarGroupBox.ResumeLayout(false);
            this.filtrarGroupBox.PerformLayout();
            this.clienteGroupBox.ResumeLayout(false);
            this.clienteGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView facturasDataGridL;
        private System.Windows.Forms.GroupBox cobrarGroupBox;
        private System.Windows.Forms.ComboBox formaPagoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaCobroDT;
        private System.Windows.Forms.Label formaDePagoLabel;
        private System.Windows.Forms.TextBox sucursalTextBox;
        private System.Windows.Forms.Label sucursalLabel;
        private System.Windows.Forms.Label importeFilterLabel;
        private System.Windows.Forms.Button cobrarBtn;
        private System.Windows.Forms.TextBox importeCobroTextBox;
        private System.Windows.Forms.GroupBox filtrarGroupBox;
        private System.Windows.Forms.GroupBox clienteGroupBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.Button seleccionarClienteBtn;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.Label numFactLabelL;
        private System.Windows.Forms.TextBox numFactFilterTextBoxL;
        private System.Windows.Forms.ComboBox empresaFilterComboBox;
        private System.Windows.Forms.Button searchBtnL;
        private System.Windows.Forms.Label empresaFilterLabel;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.TextBox clienteTxt;
        private System.Windows.Forms.Label clienteLabel2;
        private System.Windows.Forms.Label facturasLabel;
        private System.Windows.Forms.Button limpiarCobroBtn;
        private System.Windows.Forms.Button limpiarFiltrosBtn;
    }
}