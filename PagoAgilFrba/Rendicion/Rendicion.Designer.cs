namespace PagoAgilFrba.Rendicion
{
    partial class Rendicion
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
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.empresaFilterComboBox = new System.Windows.Forms.ComboBox();
            this.searchBtnL = new System.Windows.Forms.Button();
            this.empresaFilterLabel = new System.Windows.Forms.Label();
            this.facturasDataGrid = new System.Windows.Forms.DataGridView();
            this.filtrarGroupBox = new System.Windows.Forms.GroupBox();
            this.oblMesLabel = new System.Windows.Forms.Label();
            this.oblEmprLabel = new System.Windows.Forms.Label();
            this.mesLabel = new System.Windows.Forms.Label();
            this.mesesComboBox = new System.Windows.Forms.ComboBox();
            this.rendirBtn = new System.Windows.Forms.Button();
            this.limpiarRendBtn = new System.Windows.Forms.Button();
            this.rendicionGroupBox = new System.Windows.Forms.GroupBox();
            this.oblPorcLabel = new System.Windows.Forms.Label();
            this.importeTotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.cantFactLabel = new System.Windows.Forms.Label();
            this.fechaRendDT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cantFactTextBox = new System.Windows.Forms.TextBox();
            this.porcentajeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.importeNetoTextBox = new System.Windows.Forms.TextBox();
            this.porcentajeComisionTextBox = new System.Windows.Forms.TextBox();
            this.porcentajeComisionLabel = new System.Windows.Forms.Label();
            this.importeNetoLabel = new System.Windows.Forms.Label();
            this.facturasLabel = new System.Windows.Forms.Label();
            this.camposObligatoriosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGrid)).BeginInit();
            this.filtrarGroupBox.SuspendLayout();
            this.rendicionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(772, 1002);
            this.limpiarBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(259, 69);
            this.limpiarBtn.TabIndex = 28;
            this.limpiarBtn.Text = "Limpiar Todo";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // empresaFilterComboBox
            // 
            this.empresaFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaFilterComboBox.FormattingEnabled = true;
            this.empresaFilterComboBox.Location = new System.Drawing.Point(194, 67);
            this.empresaFilterComboBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.empresaFilterComboBox.Name = "empresaFilterComboBox";
            this.empresaFilterComboBox.Size = new System.Drawing.Size(326, 37);
            this.empresaFilterComboBox.TabIndex = 19;
            this.empresaFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.empresaFilterComboBox_SelectedIndexChanged);
            // 
            // searchBtnL
            // 
            this.searchBtnL.Location = new System.Drawing.Point(1181, 49);
            this.searchBtnL.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.searchBtnL.Name = "searchBtnL";
            this.searchBtnL.Size = new System.Drawing.Size(411, 78);
            this.searchBtnL.TabIndex = 18;
            this.searchBtnL.Text = "Buscar";
            this.searchBtnL.UseVisualStyleBackColor = true;
            this.searchBtnL.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // empresaFilterLabel
            // 
            this.empresaFilterLabel.AutoSize = true;
            this.empresaFilterLabel.Location = new System.Drawing.Point(47, 74);
            this.empresaFilterLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.empresaFilterLabel.Name = "empresaFilterLabel";
            this.empresaFilterLabel.Size = new System.Drawing.Size(110, 29);
            this.empresaFilterLabel.TabIndex = 20;
            this.empresaFilterLabel.Text = "Empresa";
            // 
            // facturasDataGrid
            // 
            this.facturasDataGrid.AllowUserToAddRows = false;
            this.facturasDataGrid.AllowUserToDeleteRows = false;
            this.facturasDataGrid.AllowUserToResizeRows = false;
            this.facturasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.facturasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasDataGrid.Location = new System.Drawing.Point(93, 277);
            this.facturasDataGrid.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.facturasDataGrid.Name = "facturasDataGrid";
            this.facturasDataGrid.ReadOnly = true;
            this.facturasDataGrid.Size = new System.Drawing.Size(1636, 355);
            this.facturasDataGrid.TabIndex = 26;
            // 
            // filtrarGroupBox
            // 
            this.filtrarGroupBox.Controls.Add(this.oblMesLabel);
            this.filtrarGroupBox.Controls.Add(this.oblEmprLabel);
            this.filtrarGroupBox.Controls.Add(this.mesLabel);
            this.filtrarGroupBox.Controls.Add(this.mesesComboBox);
            this.filtrarGroupBox.Controls.Add(this.empresaFilterComboBox);
            this.filtrarGroupBox.Controls.Add(this.searchBtnL);
            this.filtrarGroupBox.Controls.Add(this.empresaFilterLabel);
            this.filtrarGroupBox.Location = new System.Drawing.Point(93, 49);
            this.filtrarGroupBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.filtrarGroupBox.Name = "filtrarGroupBox";
            this.filtrarGroupBox.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.filtrarGroupBox.Size = new System.Drawing.Size(1636, 165);
            this.filtrarGroupBox.TabIndex = 27;
            this.filtrarGroupBox.TabStop = false;
            this.filtrarGroupBox.Text = "Criterio de Búsqueda";
            // 
            // oblMesLabel
            // 
            this.oblMesLabel.AutoSize = true;
            this.oblMesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.oblMesLabel.Location = new System.Drawing.Point(1004, 67);
            this.oblMesLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.oblMesLabel.Name = "oblMesLabel";
            this.oblMesLabel.Size = new System.Drawing.Size(52, 39);
            this.oblMesLabel.TabIndex = 49;
            this.oblMesLabel.Text = "(*)";
            // 
            // oblEmprLabel
            // 
            this.oblEmprLabel.AutoSize = true;
            this.oblEmprLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.oblEmprLabel.Location = new System.Drawing.Point(534, 61);
            this.oblEmprLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.oblEmprLabel.Name = "oblEmprLabel";
            this.oblEmprLabel.Size = new System.Drawing.Size(52, 39);
            this.oblEmprLabel.TabIndex = 48;
            this.oblEmprLabel.Text = "(*)";
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Location = new System.Drawing.Point(631, 73);
            this.mesLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(59, 29);
            this.mesLabel.TabIndex = 22;
            this.mesLabel.Text = "Mes";
            // 
            // mesesComboBox
            // 
            this.mesesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesesComboBox.FormattingEnabled = true;
            this.mesesComboBox.Location = new System.Drawing.Point(708, 67);
            this.mesesComboBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mesesComboBox.Name = "mesesComboBox";
            this.mesesComboBox.Size = new System.Drawing.Size(277, 37);
            this.mesesComboBox.TabIndex = 21;
            // 
            // rendirBtn
            // 
            this.rendirBtn.Location = new System.Drawing.Point(226, 201);
            this.rendirBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.rendirBtn.Name = "rendirBtn";
            this.rendirBtn.Size = new System.Drawing.Size(457, 71);
            this.rendirBtn.TabIndex = 10;
            this.rendirBtn.Text = "Rendir";
            this.rendirBtn.UseVisualStyleBackColor = true;
            this.rendirBtn.Click += new System.EventHandler(this.rendirBtn_Click);
            // 
            // limpiarRendBtn
            // 
            this.limpiarRendBtn.Location = new System.Drawing.Point(1461, 274);
            this.limpiarRendBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.limpiarRendBtn.Name = "limpiarRendBtn";
            this.limpiarRendBtn.Size = new System.Drawing.Size(175, 51);
            this.limpiarRendBtn.TabIndex = 29;
            this.limpiarRendBtn.Text = "Limpiar";
            this.limpiarRendBtn.UseVisualStyleBackColor = true;
            this.limpiarRendBtn.Click += new System.EventHandler(this.limpiarRendBtn_Click);
            // 
            // rendicionGroupBox
            // 
            this.rendicionGroupBox.Controls.Add(this.oblPorcLabel);
            this.rendicionGroupBox.Controls.Add(this.importeTotalTextBox);
            this.rendicionGroupBox.Controls.Add(this.label3);
            this.rendicionGroupBox.Controls.Add(this.empresaTextBox);
            this.rendicionGroupBox.Controls.Add(this.limpiarRendBtn);
            this.rendicionGroupBox.Controls.Add(this.rendirBtn);
            this.rendicionGroupBox.Controls.Add(this.cantFactLabel);
            this.rendicionGroupBox.Controls.Add(this.fechaRendDT);
            this.rendicionGroupBox.Controls.Add(this.label1);
            this.rendicionGroupBox.Controls.Add(this.cantFactTextBox);
            this.rendicionGroupBox.Controls.Add(this.porcentajeLabel);
            this.rendicionGroupBox.Controls.Add(this.label2);
            this.rendicionGroupBox.Controls.Add(this.importeNetoTextBox);
            this.rendicionGroupBox.Controls.Add(this.porcentajeComisionTextBox);
            this.rendicionGroupBox.Controls.Add(this.porcentajeComisionLabel);
            this.rendicionGroupBox.Controls.Add(this.importeNetoLabel);
            this.rendicionGroupBox.Location = new System.Drawing.Point(93, 645);
            this.rendicionGroupBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.rendicionGroupBox.Name = "rendicionGroupBox";
            this.rendicionGroupBox.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.rendicionGroupBox.Size = new System.Drawing.Size(1636, 326);
            this.rendicionGroupBox.TabIndex = 25;
            this.rendicionGroupBox.TabStop = false;
            this.rendicionGroupBox.Text = "Rendicion";
            // 
            // oblPorcLabel
            // 
            this.oblPorcLabel.AutoSize = true;
            this.oblPorcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.oblPorcLabel.Location = new System.Drawing.Point(1442, 98);
            this.oblPorcLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.oblPorcLabel.Name = "oblPorcLabel";
            this.oblPorcLabel.Size = new System.Drawing.Size(52, 39);
            this.oblPorcLabel.TabIndex = 47;
            this.oblPorcLabel.Text = "(*)";
            // 
            // importeTotalTextBox
            // 
            this.importeTotalTextBox.Enabled = false;
            this.importeTotalTextBox.Location = new System.Drawing.Point(1246, 42);
            this.importeTotalTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.importeTotalTextBox.Name = "importeTotalTextBox";
            this.importeTotalTextBox.Size = new System.Drawing.Size(228, 35);
            this.importeTotalTextBox.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1055, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "Importe Total";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.Enabled = false;
            this.empresaTextBox.Location = new System.Drawing.Point(1246, 216);
            this.empresaTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(228, 35);
            this.empresaTextBox.TabIndex = 42;
            // 
            // cantFactLabel
            // 
            this.cantFactLabel.AutoSize = true;
            this.cantFactLabel.Location = new System.Drawing.Point(121, 116);
            this.cantFactLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.cantFactLabel.Name = "cantFactLabel";
            this.cantFactLabel.Size = new System.Drawing.Size(241, 29);
            this.cantFactLabel.TabIndex = 32;
            this.cantFactLabel.Text = "Cantidad de Facturas";
            // 
            // fechaRendDT
            // 
            this.fechaRendDT.Enabled = false;
            this.fechaRendDT.Location = new System.Drawing.Point(387, 51);
            this.fechaRendDT.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.fechaRendDT.Name = "fechaRendDT";
            this.fechaRendDT.Size = new System.Drawing.Size(499, 35);
            this.fechaRendDT.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha de rendicion";
            // 
            // cantFactTextBox
            // 
            this.cantFactTextBox.Enabled = false;
            this.cantFactTextBox.Location = new System.Drawing.Point(392, 109);
            this.cantFactTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cantFactTextBox.Name = "cantFactTextBox";
            this.cantFactTextBox.Size = new System.Drawing.Size(128, 35);
            this.cantFactTextBox.TabIndex = 33;
            // 
            // porcentajeLabel
            // 
            this.porcentajeLabel.AutoSize = true;
            this.porcentajeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.porcentajeLabel.Location = new System.Drawing.Point(1381, 103);
            this.porcentajeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.porcentajeLabel.Name = "porcentajeLabel";
            this.porcentajeLabel.Size = new System.Drawing.Size(40, 32);
            this.porcentajeLabel.TabIndex = 40;
            this.porcentajeLabel.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1101, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Empresa";
            // 
            // importeNetoTextBox
            // 
            this.importeNetoTextBox.Enabled = false;
            this.importeNetoTextBox.Location = new System.Drawing.Point(1246, 158);
            this.importeNetoTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.importeNetoTextBox.Name = "importeNetoTextBox";
            this.importeNetoTextBox.Size = new System.Drawing.Size(228, 35);
            this.importeNetoTextBox.TabIndex = 37;
            // 
            // porcentajeComisionTextBox
            // 
            this.porcentajeComisionTextBox.Location = new System.Drawing.Point(1246, 100);
            this.porcentajeComisionTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.porcentajeComisionTextBox.Name = "porcentajeComisionTextBox";
            this.porcentajeComisionTextBox.Size = new System.Drawing.Size(116, 35);
            this.porcentajeComisionTextBox.TabIndex = 39;
            // 
            // porcentajeComisionLabel
            // 
            this.porcentajeComisionLabel.AutoSize = true;
            this.porcentajeComisionLabel.Location = new System.Drawing.Point(957, 107);
            this.porcentajeComisionLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.porcentajeComisionLabel.Name = "porcentajeComisionLabel";
            this.porcentajeComisionLabel.Size = new System.Drawing.Size(271, 29);
            this.porcentajeComisionLabel.TabIndex = 38;
            this.porcentajeComisionLabel.Text = "Porcentaje de Comisión";
            // 
            // importeNetoLabel
            // 
            this.importeNetoLabel.AutoSize = true;
            this.importeNetoLabel.Location = new System.Drawing.Point(1055, 165);
            this.importeNetoLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.importeNetoLabel.Name = "importeNetoLabel";
            this.importeNetoLabel.Size = new System.Drawing.Size(153, 29);
            this.importeNetoLabel.TabIndex = 36;
            this.importeNetoLabel.Text = "Importe Neto";
            // 
            // facturasLabel
            // 
            this.facturasLabel.AutoSize = true;
            this.facturasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.facturasLabel.Location = new System.Drawing.Point(86, 232);
            this.facturasLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.facturasLabel.Name = "facturasLabel";
            this.facturasLabel.Size = new System.Drawing.Size(270, 35);
            this.facturasLabel.TabIndex = 29;
            this.facturasLabel.Text = "Facturas sin rendir";
            // 
            // camposObligatoriosLabel
            // 
            this.camposObligatoriosLabel.AutoSize = true;
            this.camposObligatoriosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.camposObligatoriosLabel.Location = new System.Drawing.Point(1417, 1036);
            this.camposObligatoriosLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.camposObligatoriosLabel.Name = "camposObligatoriosLabel";
            this.camposObligatoriosLabel.Size = new System.Drawing.Size(342, 35);
            this.camposObligatoriosLabel.TabIndex = 30;
            this.camposObligatoriosLabel.Text = "Campos Obligatorios (*)";
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1783, 1099);
            this.Controls.Add(this.camposObligatoriosLabel);
            this.Controls.Add(this.facturasLabel);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.facturasDataGrid);
            this.Controls.Add(this.filtrarGroupBox);
            this.Controls.Add(this.rendicionGroupBox);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Rendicion";
            this.Text = "Rendicion";
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGrid)).EndInit();
            this.filtrarGroupBox.ResumeLayout(false);
            this.filtrarGroupBox.PerformLayout();
            this.rendicionGroupBox.ResumeLayout(false);
            this.rendicionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.ComboBox empresaFilterComboBox;
        private System.Windows.Forms.Button searchBtnL;
        private System.Windows.Forms.Label empresaFilterLabel;
        private System.Windows.Forms.DataGridView facturasDataGrid;
        private System.Windows.Forms.GroupBox filtrarGroupBox;
        private System.Windows.Forms.Button rendirBtn;
        private System.Windows.Forms.Button limpiarRendBtn;
        private System.Windows.Forms.GroupBox rendicionGroupBox;
        private System.Windows.Forms.Label facturasLabel;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.Label cantFactLabel;
        private System.Windows.Forms.DateTimePicker fechaRendDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantFactTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox importeNetoTextBox;
        private System.Windows.Forms.Label importeNetoLabel;
        private System.Windows.Forms.Label mesLabel;
        private System.Windows.Forms.ComboBox mesesComboBox;
        private System.Windows.Forms.TextBox importeTotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label porcentajeLabel;
        private System.Windows.Forms.TextBox porcentajeComisionTextBox;
        private System.Windows.Forms.Label porcentajeComisionLabel;
        private System.Windows.Forms.Label oblMesLabel;
        private System.Windows.Forms.Label oblEmprLabel;
        private System.Windows.Forms.Label oblPorcLabel;
        private System.Windows.Forms.Label camposObligatoriosLabel;

    }
}