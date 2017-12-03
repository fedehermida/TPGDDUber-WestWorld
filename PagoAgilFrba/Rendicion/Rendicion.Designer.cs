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
            this.rendicionGroupBox = new System.Windows.Forms.GroupBox();
            this.calcularGroupBox = new System.Windows.Forms.GroupBox();
            this.calcularRendBtn = new System.Windows.Forms.Button();
            this.oblPorcLabel = new System.Windows.Forms.Label();
            this.porcentajeComisionTextBox = new System.Windows.Forms.TextBox();
            this.porcentajeComisionLabel = new System.Windows.Forms.Label();
            this.importeTotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.cantFactLabel = new System.Windows.Forms.Label();
            this.fechaRendDT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cantFactTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.importeNetoTextBox = new System.Windows.Forms.TextBox();
            this.importeNetoLabel = new System.Windows.Forms.Label();
            this.facturasLabel = new System.Windows.Forms.Label();
            this.camposObligatoriosLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.limpiarRendBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGrid)).BeginInit();
            this.filtrarGroupBox.SuspendLayout();
            this.rendicionGroupBox.SuspendLayout();
            this.calcularGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(335, 491);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(111, 31);
            this.limpiarBtn.TabIndex = 28;
            this.limpiarBtn.Text = "Limpiar Todo";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // empresaFilterComboBox
            // 
            this.empresaFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaFilterComboBox.FormattingEnabled = true;
            this.empresaFilterComboBox.Location = new System.Drawing.Point(83, 30);
            this.empresaFilterComboBox.Name = "empresaFilterComboBox";
            this.empresaFilterComboBox.Size = new System.Drawing.Size(142, 21);
            this.empresaFilterComboBox.TabIndex = 19;
            this.empresaFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.empresaFilterComboBox_SelectedIndexChanged);
            // 
            // searchBtnL
            // 
            this.searchBtnL.Location = new System.Drawing.Point(506, 22);
            this.searchBtnL.Name = "searchBtnL";
            this.searchBtnL.Size = new System.Drawing.Size(176, 35);
            this.searchBtnL.TabIndex = 18;
            this.searchBtnL.Text = "Buscar";
            this.searchBtnL.UseVisualStyleBackColor = true;
            this.searchBtnL.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // empresaFilterLabel
            // 
            this.empresaFilterLabel.AutoSize = true;
            this.empresaFilterLabel.Location = new System.Drawing.Point(20, 33);
            this.empresaFilterLabel.Name = "empresaFilterLabel";
            this.empresaFilterLabel.Size = new System.Drawing.Size(48, 13);
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
            this.facturasDataGrid.Location = new System.Drawing.Point(40, 124);
            this.facturasDataGrid.Name = "facturasDataGrid";
            this.facturasDataGrid.ReadOnly = true;
            this.facturasDataGrid.Size = new System.Drawing.Size(701, 159);
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
            this.filtrarGroupBox.Location = new System.Drawing.Point(40, 22);
            this.filtrarGroupBox.Name = "filtrarGroupBox";
            this.filtrarGroupBox.Size = new System.Drawing.Size(701, 74);
            this.filtrarGroupBox.TabIndex = 27;
            this.filtrarGroupBox.TabStop = false;
            this.filtrarGroupBox.Text = "Criterio de Búsqueda";
            // 
            // oblMesLabel
            // 
            this.oblMesLabel.AutoSize = true;
            this.oblMesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.oblMesLabel.Location = new System.Drawing.Point(430, 30);
            this.oblMesLabel.Name = "oblMesLabel";
            this.oblMesLabel.Size = new System.Drawing.Size(24, 18);
            this.oblMesLabel.TabIndex = 49;
            this.oblMesLabel.Text = "(*)";
            // 
            // oblEmprLabel
            // 
            this.oblEmprLabel.AutoSize = true;
            this.oblEmprLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.oblEmprLabel.Location = new System.Drawing.Point(229, 29);
            this.oblEmprLabel.Name = "oblEmprLabel";
            this.oblEmprLabel.Size = new System.Drawing.Size(24, 18);
            this.oblEmprLabel.TabIndex = 48;
            this.oblEmprLabel.Text = "(*)";
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Location = new System.Drawing.Point(270, 33);
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(27, 13);
            this.mesLabel.TabIndex = 22;
            this.mesLabel.Text = "Mes";
            // 
            // mesesComboBox
            // 
            this.mesesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesesComboBox.FormattingEnabled = true;
            this.mesesComboBox.Location = new System.Drawing.Point(303, 30);
            this.mesesComboBox.Name = "mesesComboBox";
            this.mesesComboBox.Size = new System.Drawing.Size(121, 21);
            this.mesesComboBox.TabIndex = 21;
            // 
            // rendirBtn
            // 
            this.rendirBtn.Enabled = false;
            this.rendirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rendirBtn.Location = new System.Drawing.Point(252, 133);
            this.rendirBtn.Name = "rendirBtn";
            this.rendirBtn.Size = new System.Drawing.Size(196, 32);
            this.rendirBtn.TabIndex = 10;
            this.rendirBtn.Text = "Rendir";
            this.rendirBtn.UseVisualStyleBackColor = true;
            this.rendirBtn.Click += new System.EventHandler(this.rendirBtn_Click);
            // 
            // rendicionGroupBox
            // 
            this.rendicionGroupBox.Controls.Add(this.limpiarRendBtn);
            this.rendicionGroupBox.Controls.Add(this.calcularGroupBox);
            this.rendicionGroupBox.Controls.Add(this.importeTotalTextBox);
            this.rendicionGroupBox.Controls.Add(this.label3);
            this.rendicionGroupBox.Controls.Add(this.empresaTextBox);
            this.rendicionGroupBox.Controls.Add(this.rendirBtn);
            this.rendicionGroupBox.Controls.Add(this.cantFactLabel);
            this.rendicionGroupBox.Controls.Add(this.fechaRendDT);
            this.rendicionGroupBox.Controls.Add(this.label1);
            this.rendicionGroupBox.Controls.Add(this.cantFactTextBox);
            this.rendicionGroupBox.Controls.Add(this.label2);
            this.rendicionGroupBox.Controls.Add(this.importeNetoTextBox);
            this.rendicionGroupBox.Controls.Add(this.importeNetoLabel);
            this.rendicionGroupBox.Location = new System.Drawing.Point(40, 289);
            this.rendicionGroupBox.Name = "rendicionGroupBox";
            this.rendicionGroupBox.Size = new System.Drawing.Size(701, 191);
            this.rendicionGroupBox.TabIndex = 25;
            this.rendicionGroupBox.TabStop = false;
            // 
            // calcularGroupBox
            // 
            this.calcularGroupBox.Controls.Add(this.calcularRendBtn);
            this.calcularGroupBox.Controls.Add(this.oblPorcLabel);
            this.calcularGroupBox.Controls.Add(this.porcentajeComisionTextBox);
            this.calcularGroupBox.Controls.Add(this.porcentajeComisionLabel);
            this.calcularGroupBox.Location = new System.Drawing.Point(6, 7);
            this.calcularGroupBox.Name = "calcularGroupBox";
            this.calcularGroupBox.Size = new System.Drawing.Size(689, 46);
            this.calcularGroupBox.TabIndex = 52;
            this.calcularGroupBox.TabStop = false;
            // 
            // calcularRendBtn
            // 
            this.calcularRendBtn.Location = new System.Drawing.Point(488, 10);
            this.calcularRendBtn.Name = "calcularRendBtn";
            this.calcularRendBtn.Size = new System.Drawing.Size(106, 29);
            this.calcularRendBtn.TabIndex = 55;
            this.calcularRendBtn.Text = "Calcular Rendición";
            this.calcularRendBtn.UseVisualStyleBackColor = true;
            this.calcularRendBtn.Click += new System.EventHandler(this.calcularRendBtn_Click);
            // 
            // oblPorcLabel
            // 
            this.oblPorcLabel.AutoSize = true;
            this.oblPorcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.oblPorcLabel.Location = new System.Drawing.Point(388, 15);
            this.oblPorcLabel.Name = "oblPorcLabel";
            this.oblPorcLabel.Size = new System.Drawing.Size(24, 18);
            this.oblPorcLabel.TabIndex = 54;
            this.oblPorcLabel.Text = "(*)";
            // 
            // porcentajeComisionTextBox
            // 
            this.porcentajeComisionTextBox.Location = new System.Drawing.Point(329, 15);
            this.porcentajeComisionTextBox.MaxLength = 4;
            this.porcentajeComisionTextBox.Name = "porcentajeComisionTextBox";
            this.porcentajeComisionTextBox.Size = new System.Drawing.Size(52, 20);
            this.porcentajeComisionTextBox.TabIndex = 53;
            // 
            // porcentajeComisionLabel
            // 
            this.porcentajeComisionLabel.AutoSize = true;
            this.porcentajeComisionLabel.Location = new System.Drawing.Point(61, 18);
            this.porcentajeComisionLabel.Name = "porcentajeComisionLabel";
            this.porcentajeComisionLabel.Size = new System.Drawing.Size(262, 13);
            this.porcentajeComisionLabel.TabIndex = 52;
            this.porcentajeComisionLabel.Text = "Porcentaje de Comisión De La Empresa Seleccionada";
            // 
            // importeTotalTextBox
            // 
            this.importeTotalTextBox.Enabled = false;
            this.importeTotalTextBox.Location = new System.Drawing.Point(551, 59);
            this.importeTotalTextBox.Name = "importeTotalTextBox";
            this.importeTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeTotalTextBox.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Importe Total";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.Enabled = false;
            this.empresaTextBox.Location = new System.Drawing.Point(171, 87);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.empresaTextBox.TabIndex = 42;
            // 
            // cantFactLabel
            // 
            this.cantFactLabel.AutoSize = true;
            this.cantFactLabel.Location = new System.Drawing.Point(55, 116);
            this.cantFactLabel.Name = "cantFactLabel";
            this.cantFactLabel.Size = new System.Drawing.Size(108, 13);
            this.cantFactLabel.TabIndex = 32;
            this.cantFactLabel.Text = "Cantidad de Facturas";
            // 
            // fechaRendDT
            // 
            this.fechaRendDT.Enabled = false;
            this.fechaRendDT.Location = new System.Drawing.Point(171, 62);
            this.fechaRendDT.Name = "fechaRendDT";
            this.fechaRendDT.Size = new System.Drawing.Size(216, 20);
            this.fechaRendDT.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha de rendicion";
            // 
            // cantFactTextBox
            // 
            this.cantFactTextBox.Enabled = false;
            this.cantFactTextBox.Location = new System.Drawing.Point(171, 113);
            this.cantFactTextBox.Name = "cantFactTextBox";
            this.cantFactTextBox.Size = new System.Drawing.Size(57, 20);
            this.cantFactTextBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Empresa";
            // 
            // importeNetoTextBox
            // 
            this.importeNetoTextBox.Enabled = false;
            this.importeNetoTextBox.Location = new System.Drawing.Point(551, 90);
            this.importeNetoTextBox.Name = "importeNetoTextBox";
            this.importeNetoTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeNetoTextBox.TabIndex = 37;
            // 
            // importeNetoLabel
            // 
            this.importeNetoLabel.AutoSize = true;
            this.importeNetoLabel.Location = new System.Drawing.Point(469, 93);
            this.importeNetoLabel.Name = "importeNetoLabel";
            this.importeNetoLabel.Size = new System.Drawing.Size(68, 13);
            this.importeNetoLabel.TabIndex = 36;
            this.importeNetoLabel.Text = "Importe Neto";
            // 
            // facturasLabel
            // 
            this.facturasLabel.AutoSize = true;
            this.facturasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.facturasLabel.Location = new System.Drawing.Point(37, 104);
            this.facturasLabel.Name = "facturasLabel";
            this.facturasLabel.Size = new System.Drawing.Size(126, 17);
            this.facturasLabel.TabIndex = 29;
            this.facturasLabel.Text = "Facturas sin rendir";
            // 
            // camposObligatoriosLabel
            // 
            this.camposObligatoriosLabel.AutoSize = true;
            this.camposObligatoriosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.camposObligatoriosLabel.Location = new System.Drawing.Point(607, 513);
            this.camposObligatoriosLabel.Name = "camposObligatoriosLabel";
            this.camposObligatoriosLabel.Size = new System.Drawing.Size(158, 17);
            this.camposObligatoriosLabel.TabIndex = 30;
            this.camposObligatoriosLabel.Text = "Campos Obligatorios (*)";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(40, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 100);
            this.panel1.TabIndex = 52;
            // 
            // limpiarRendBtn
            // 
            this.limpiarRendBtn.Location = new System.Drawing.Point(624, 170);
            this.limpiarRendBtn.Name = "limpiarRendBtn";
            this.limpiarRendBtn.Size = new System.Drawing.Size(77, 21);
            this.limpiarRendBtn.TabIndex = 53;
            this.limpiarRendBtn.Text = "Limpiar";
            this.limpiarRendBtn.UseVisualStyleBackColor = true;
            this.limpiarRendBtn.Click += new System.EventHandler(this.limpiarRendBtn_Click);
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 539);
            this.Controls.Add(this.camposObligatoriosLabel);
            this.Controls.Add(this.facturasLabel);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.facturasDataGrid);
            this.Controls.Add(this.filtrarGroupBox);
            this.Controls.Add(this.rendicionGroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "Rendicion";
            this.Text = "Rendicion";
            this.Activated += new System.EventHandler(this.Rendicion_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGrid)).EndInit();
            this.filtrarGroupBox.ResumeLayout(false);
            this.filtrarGroupBox.PerformLayout();
            this.rendicionGroupBox.ResumeLayout(false);
            this.rendicionGroupBox.PerformLayout();
            this.calcularGroupBox.ResumeLayout(false);
            this.calcularGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label oblMesLabel;
        private System.Windows.Forms.Label oblEmprLabel;
        private System.Windows.Forms.Label camposObligatoriosLabel;
        private System.Windows.Forms.GroupBox calcularGroupBox;
        private System.Windows.Forms.Button calcularRendBtn;
        private System.Windows.Forms.Label oblPorcLabel;
        private System.Windows.Forms.TextBox porcentajeComisionTextBox;
        private System.Windows.Forms.Label porcentajeComisionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button limpiarRendBtn;

    }
}