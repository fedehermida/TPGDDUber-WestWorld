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
            this.rendirBtn = new System.Windows.Forms.Button();
            this.limpiarRendBtn = new System.Windows.Forms.Button();
            this.rendicionGroupBox = new System.Windows.Forms.GroupBox();
            this.facturasLabel = new System.Windows.Forms.Label();
            this.importeTotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.porcentajeLabel = new System.Windows.Forms.Label();
            this.porcentajeComisionTextBox = new System.Windows.Forms.TextBox();
            this.porcentajeComisionLabel = new System.Windows.Forms.Label();
            this.importeNetoTextBox = new System.Windows.Forms.TextBox();
            this.importeNetoLabel = new System.Windows.Forms.Label();
            this.conjuntoFactLabel = new System.Windows.Forms.Label();
            this.conjuntoFactTextBox = new System.Windows.Forms.TextBox();
            this.cantFactTextBox = new System.Windows.Forms.TextBox();
            this.cantFactLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaRendDT = new System.Windows.Forms.DateTimePicker();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGrid)).BeginInit();
            this.filtrarGroupBox.SuspendLayout();
            this.rendicionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(328, 441);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(111, 31);
            this.limpiarBtn.TabIndex = 28;
            this.limpiarBtn.Text = "Limpiar Todo";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // empresaFilterComboBox
            // 
            this.empresaFilterComboBox.FormattingEnabled = true;
            this.empresaFilterComboBox.Location = new System.Drawing.Point(153, 30);
            this.empresaFilterComboBox.Name = "empresaFilterComboBox";
            this.empresaFilterComboBox.Size = new System.Drawing.Size(142, 21);
            this.empresaFilterComboBox.TabIndex = 19;
            // 
            // searchBtnL
            // 
            this.searchBtnL.Location = new System.Drawing.Point(414, 22);
            this.searchBtnL.Name = "searchBtnL";
            this.searchBtnL.Size = new System.Drawing.Size(192, 35);
            this.searchBtnL.TabIndex = 18;
            this.searchBtnL.Text = "Buscar";
            this.searchBtnL.UseVisualStyleBackColor = true;
            this.searchBtnL.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // empresaFilterLabel
            // 
            this.empresaFilterLabel.AutoSize = true;
            this.empresaFilterLabel.Location = new System.Drawing.Point(90, 33);
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
            // rendirBtn
            // 
            this.rendirBtn.Location = new System.Drawing.Point(99, 104);
            this.rendirBtn.Name = "rendirBtn";
            this.rendirBtn.Size = new System.Drawing.Size(196, 32);
            this.rendirBtn.TabIndex = 10;
            this.rendirBtn.Text = "Rendir";
            this.rendirBtn.UseVisualStyleBackColor = true;
            // 
            // limpiarRendBtn
            // 
            this.limpiarRendBtn.Location = new System.Drawing.Point(626, 123);
            this.limpiarRendBtn.Name = "limpiarRendBtn";
            this.limpiarRendBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarRendBtn.TabIndex = 29;
            this.limpiarRendBtn.Text = "Limpiar";
            this.limpiarRendBtn.UseVisualStyleBackColor = true;
            this.limpiarRendBtn.Click += new System.EventHandler(this.limpiarRendBtn_Click);
            // 
            // rendicionGroupBox
            // 
            this.rendicionGroupBox.Controls.Add(this.importeTotalTextBox);
            this.rendicionGroupBox.Controls.Add(this.label3);
            this.rendicionGroupBox.Controls.Add(this.empresaTextBox);
            this.rendicionGroupBox.Controls.Add(this.limpiarRendBtn);
            this.rendicionGroupBox.Controls.Add(this.conjuntoFactLabel);
            this.rendicionGroupBox.Controls.Add(this.conjuntoFactTextBox);
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
            this.rendicionGroupBox.Location = new System.Drawing.Point(40, 289);
            this.rendicionGroupBox.Name = "rendicionGroupBox";
            this.rendicionGroupBox.Size = new System.Drawing.Size(701, 146);
            this.rendicionGroupBox.TabIndex = 25;
            this.rendicionGroupBox.TabStop = false;
            this.rendicionGroupBox.Text = "Rendicion";
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
            // importeTotalTextBox
            // 
            this.importeTotalTextBox.Location = new System.Drawing.Point(506, 98);
            this.importeTotalTextBox.Name = "importeTotalTextBox";
            this.importeTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeTotalTextBox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Importe Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Empresa";
            // 
            // porcentajeLabel
            // 
            this.porcentajeLabel.AutoSize = true;
            this.porcentajeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.porcentajeLabel.Location = new System.Drawing.Point(586, 73);
            this.porcentajeLabel.Name = "porcentajeLabel";
            this.porcentajeLabel.Size = new System.Drawing.Size(20, 16);
            this.porcentajeLabel.TabIndex = 40;
            this.porcentajeLabel.Text = "%";
            // 
            // porcentajeComisionTextBox
            // 
            this.porcentajeComisionTextBox.Location = new System.Drawing.Point(506, 72);
            this.porcentajeComisionTextBox.Name = "porcentajeComisionTextBox";
            this.porcentajeComisionTextBox.Size = new System.Drawing.Size(74, 20);
            this.porcentajeComisionTextBox.TabIndex = 39;
            // 
            // porcentajeComisionLabel
            // 
            this.porcentajeComisionLabel.AutoSize = true;
            this.porcentajeComisionLabel.Location = new System.Drawing.Point(382, 75);
            this.porcentajeComisionLabel.Name = "porcentajeComisionLabel";
            this.porcentajeComisionLabel.Size = new System.Drawing.Size(118, 13);
            this.porcentajeComisionLabel.TabIndex = 38;
            this.porcentajeComisionLabel.Text = "Porcentaje de Comisión";
            // 
            // importeNetoTextBox
            // 
            this.importeNetoTextBox.Location = new System.Drawing.Point(506, 46);
            this.importeNetoTextBox.Name = "importeNetoTextBox";
            this.importeNetoTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeNetoTextBox.TabIndex = 37;
            // 
            // importeNetoLabel
            // 
            this.importeNetoLabel.AutoSize = true;
            this.importeNetoLabel.Location = new System.Drawing.Point(424, 49);
            this.importeNetoLabel.Name = "importeNetoLabel";
            this.importeNetoLabel.Size = new System.Drawing.Size(68, 13);
            this.importeNetoLabel.TabIndex = 36;
            this.importeNetoLabel.Text = "Importe Neto";
            // 
            // conjuntoFactLabel
            // 
            this.conjuntoFactLabel.AutoSize = true;
            this.conjuntoFactLabel.Location = new System.Drawing.Point(52, 75);
            this.conjuntoFactLabel.Name = "conjuntoFactLabel";
            this.conjuntoFactLabel.Size = new System.Drawing.Size(108, 13);
            this.conjuntoFactLabel.TabIndex = 35;
            this.conjuntoFactLabel.Text = "Conjunto de Facturas";
            // 
            // conjuntoFactTextBox
            // 
            this.conjuntoFactTextBox.Location = new System.Drawing.Point(166, 75);
            this.conjuntoFactTextBox.Name = "conjuntoFactTextBox";
            this.conjuntoFactTextBox.Size = new System.Drawing.Size(100, 20);
            this.conjuntoFactTextBox.TabIndex = 34;
            // 
            // cantFactTextBox
            // 
            this.cantFactTextBox.Enabled = false;
            this.cantFactTextBox.Location = new System.Drawing.Point(168, 49);
            this.cantFactTextBox.Name = "cantFactTextBox";
            this.cantFactTextBox.Size = new System.Drawing.Size(57, 20);
            this.cantFactTextBox.TabIndex = 33;
            // 
            // cantFactLabel
            // 
            this.cantFactLabel.AutoSize = true;
            this.cantFactLabel.Location = new System.Drawing.Point(52, 52);
            this.cantFactLabel.Name = "cantFactLabel";
            this.cantFactLabel.Size = new System.Drawing.Size(108, 13);
            this.cantFactLabel.TabIndex = 32;
            this.cantFactLabel.Text = "Cantidad de Facturas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha de rendicion";
            // 
            // fechaRendDT
            // 
            this.fechaRendDT.Enabled = false;
            this.fechaRendDT.Location = new System.Drawing.Point(166, 23);
            this.fechaRendDT.Name = "fechaRendDT";
            this.fechaRendDT.Size = new System.Drawing.Size(216, 20);
            this.fechaRendDT.TabIndex = 30;
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.Enabled = false;
            this.empresaTextBox.Location = new System.Drawing.Point(506, 16);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.empresaTextBox.TabIndex = 42;
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 478);
            this.Controls.Add(this.facturasLabel);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.facturasDataGrid);
            this.Controls.Add(this.filtrarGroupBox);
            this.Controls.Add(this.rendicionGroupBox);
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
        private System.Windows.Forms.TextBox importeTotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.Label conjuntoFactLabel;
        private System.Windows.Forms.TextBox conjuntoFactTextBox;
        private System.Windows.Forms.Label cantFactLabel;
        private System.Windows.Forms.DateTimePicker fechaRendDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantFactTextBox;
        private System.Windows.Forms.Label porcentajeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox importeNetoTextBox;
        private System.Windows.Forms.TextBox porcentajeComisionTextBox;
        private System.Windows.Forms.Label porcentajeComisionLabel;
        private System.Windows.Forms.Label importeNetoLabel;

    }
}