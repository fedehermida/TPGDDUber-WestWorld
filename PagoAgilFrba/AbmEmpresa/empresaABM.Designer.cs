namespace PagoAgilFrba.AbmEmpresa
{
    partial class empresaABM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rubroComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cuitTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.empresaDataGrid = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.habilitadoCheck = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rubroFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cuitFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreFilterTextBox = new System.Windows.Forms.TextBox();
            this.diaRendicionLabel = new System.Windows.Forms.Label();
            this.diaRendicionTextBox = new System.Windows.Forms.TextBox();
            this.camposObligatoriosLabel = new System.Windows.Forms.Label();
            this.nombreObligLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CUIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // rubroComboBox
            // 
            this.rubroComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.rubroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rubroComboBox.FormattingEnabled = true;
            this.rubroComboBox.Location = new System.Drawing.Point(399, 52);
            this.rubroComboBox.Name = "rubroComboBox";
            this.rubroComboBox.Size = new System.Drawing.Size(121, 21);
            this.rubroComboBox.TabIndex = 5;
            this.rubroComboBox.SelectedIndexChanged += new System.EventHandler(this.rubroComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rubro";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(99, 12);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // cuitTextBox
            // 
            this.cuitTextBox.Location = new System.Drawing.Point(99, 55);
            this.cuitTextBox.Name = "cuitTextBox";
            this.cuitTextBox.Size = new System.Drawing.Size(100, 20);
            this.cuitTextBox.TabIndex = 2;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(399, 10);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(121, 20);
            this.direccionTextBox.TabIndex = 4;
            // 
            // empresaDataGrid
            // 
            this.empresaDataGrid.AllowUserToAddRows = false;
            this.empresaDataGrid.AllowUserToDeleteRows = false;
            this.empresaDataGrid.AllowUserToResizeRows = false;
            this.empresaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresaDataGrid.Location = new System.Drawing.Point(29, 222);
            this.empresaDataGrid.Name = "empresaDataGrid";
            this.empresaDataGrid.ReadOnly = true;
            this.empresaDataGrid.Size = new System.Drawing.Size(727, 150);
            this.empresaDataGrid.TabIndex = 8;
            this.empresaDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.empresaDataGrid_MouseDoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(605, 52);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 36);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // habilitadoCheck
            // 
            this.habilitadoCheck.AutoSize = true;
            this.habilitadoCheck.Location = new System.Drawing.Point(99, 95);
            this.habilitadoCheck.Name = "habilitadoCheck";
            this.habilitadoCheck.Size = new System.Drawing.Size(15, 14);
            this.habilitadoCheck.TabIndex = 3;
            this.habilitadoCheck.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Habilitado";
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(346, 397);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(103, 31);
            this.limpiarBtn.TabIndex = 12;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.rubroFilterComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cuitFilter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nombreFilterTextBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterio De Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(608, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 34);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // rubroFilterComboBox
            // 
            this.rubroFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rubroFilterComboBox.FormattingEnabled = true;
            this.rubroFilterComboBox.Location = new System.Drawing.Point(454, 30);
            this.rubroFilterComboBox.Name = "rubroFilterComboBox";
            this.rubroFilterComboBox.Size = new System.Drawing.Size(110, 21);
            this.rubroFilterComboBox.TabIndex = 10;
            this.rubroFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.rubroFilterComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Rubro";
            // 
            // cuitFilter
            // 
            this.cuitFilter.Location = new System.Drawing.Point(257, 32);
            this.cuitFilter.Name = "cuitFilter";
            this.cuitFilter.Size = new System.Drawing.Size(112, 20);
            this.cuitFilter.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "CUIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre";
            // 
            // nombreFilterTextBox
            // 
            this.nombreFilterTextBox.Location = new System.Drawing.Point(87, 32);
            this.nombreFilterTextBox.Name = "nombreFilterTextBox";
            this.nombreFilterTextBox.Size = new System.Drawing.Size(101, 20);
            this.nombreFilterTextBox.TabIndex = 8;
            // 
            // diaRendicionLabel
            // 
            this.diaRendicionLabel.AutoSize = true;
            this.diaRendicionLabel.Location = new System.Drawing.Point(288, 96);
            this.diaRendicionLabel.Name = "diaRendicionLabel";
            this.diaRendicionLabel.Size = new System.Drawing.Size(91, 13);
            this.diaRendicionLabel.TabIndex = 40;
            this.diaRendicionLabel.Text = "Día de Rendición";
            // 
            // diaRendicionTextBox
            // 
            this.diaRendicionTextBox.Location = new System.Drawing.Point(399, 94);
            this.diaRendicionTextBox.MaxLength = 2;
            this.diaRendicionTextBox.Name = "diaRendicionTextBox";
            this.diaRendicionTextBox.Size = new System.Drawing.Size(50, 20);
            this.diaRendicionTextBox.TabIndex = 6;
            this.diaRendicionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diaRendicionTextBox_KeyPress);
            // 
            // camposObligatoriosLabel
            // 
            this.camposObligatoriosLabel.AutoSize = true;
            this.camposObligatoriosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.camposObligatoriosLabel.Location = new System.Drawing.Point(635, 426);
            this.camposObligatoriosLabel.Name = "camposObligatoriosLabel";
            this.camposObligatoriosLabel.Size = new System.Drawing.Size(152, 17);
            this.camposObligatoriosLabel.TabIndex = 42;
            this.camposObligatoriosLabel.Text = "camposObligatorios (*)";
            // 
            // nombreObligLabel
            // 
            this.nombreObligLabel.AutoSize = true;
            this.nombreObligLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nombreObligLabel.Location = new System.Drawing.Point(205, 10);
            this.nombreObligLabel.Name = "nombreObligLabel";
            this.nombreObligLabel.Size = new System.Drawing.Size(23, 17);
            this.nombreObligLabel.TabIndex = 43;
            this.nombreObligLabel.Text = "(*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(205, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(526, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "(*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(526, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "(*)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.Location = new System.Drawing.Point(455, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "(*)";
            // 
            // empresaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nombreObligLabel);
            this.Controls.Add(this.camposObligatoriosLabel);
            this.Controls.Add(this.diaRendicionTextBox);
            this.Controls.Add(this.diaRendicionLabel);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.habilitadoCheck);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.empresaDataGrid);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.cuitTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rubroComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "empresaABM";
            this.Text = "ABM Empresa";
            this.Activated += new System.EventHandler(this.empresaABM_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rubroComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox cuitTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.DataGridView empresaDataGrid;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox habilitadoCheck;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox rubroFilterComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cuitFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombreFilterTextBox;
        private System.Windows.Forms.Label diaRendicionLabel;
        private System.Windows.Forms.TextBox diaRendicionTextBox;
        private System.Windows.Forms.Label camposObligatoriosLabel;
        private System.Windows.Forms.Label nombreObligLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}