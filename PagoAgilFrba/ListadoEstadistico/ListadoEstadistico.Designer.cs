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
            this.trimestreComboBox = new System.Windows.Forms.ComboBox();
            this.listadoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.anioTextBox = new System.Windows.Forms.TextBox();
            this.anioLabel = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.clientesRadioButton = new System.Windows.Forms.RadioButton();
            this.listarBtn = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.limpiarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.trimestreComboBox.Location = new System.Drawing.Point(453, 16);
            this.trimestreComboBox.Name = "trimestreComboBox";
            this.trimestreComboBox.Size = new System.Drawing.Size(121, 21);
            this.trimestreComboBox.TabIndex = 0;
            // 
            // listadoDataGridView
            // 
            this.listadoDataGridView.AllowUserToAddRows = false;
            this.listadoDataGridView.AllowUserToDeleteRows = false;
            this.listadoDataGridView.AllowUserToResizeRows = false;
            this.listadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDataGridView.Location = new System.Drawing.Point(45, 112);
            this.listadoDataGridView.Name = "listadoDataGridView";
            this.listadoDataGridView.ReadOnly = true;
            this.listadoDataGridView.Size = new System.Drawing.Size(595, 150);
            this.listadoDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trimestre";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(240, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Porcentaje de facturas cobradas por empresa";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // anioTextBox
            // 
            this.anioTextBox.Location = new System.Drawing.Point(453, 43);
            this.anioTextBox.MaxLength = 4;
            this.anioTextBox.Name = "anioTextBox";
            this.anioTextBox.Size = new System.Drawing.Size(72, 20);
            this.anioTextBox.TabIndex = 4;
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Location = new System.Drawing.Point(421, 46);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(26, 13);
            this.anioLabel.TabIndex = 5;
            this.anioLabel.Text = "Año";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(45, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(193, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Empresas con mayor monto rendido";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // clientesRadioButton
            // 
            this.clientesRadioButton.AutoSize = true;
            this.clientesRadioButton.Location = new System.Drawing.Point(45, 61);
            this.clientesRadioButton.Name = "clientesRadioButton";
            this.clientesRadioButton.Size = new System.Drawing.Size(137, 17);
            this.clientesRadioButton.TabIndex = 7;
            this.clientesRadioButton.TabStop = true;
            this.clientesRadioButton.Text = "Clientes con más pagos";
            this.clientesRadioButton.UseVisualStyleBackColor = true;
            // 
            // listarBtn
            // 
            this.listarBtn.Location = new System.Drawing.Point(400, 69);
            this.listarBtn.Name = "listarBtn";
            this.listarBtn.Size = new System.Drawing.Size(174, 37);
            this.listarBtn.TabIndex = 8;
            this.listarBtn.Text = "LISTAR";
            this.listarBtn.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(45, 84);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(267, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Clientes con mayor porcentaje de facturas pagadas";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(261, 268);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(115, 32);
            this.limpiarBtn.TabIndex = 10;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 309);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.listarBtn);
            this.Controls.Add(this.clientesRadioButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.anioLabel);
            this.Controls.Add(this.anioTextBox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadoDataGridView);
            this.Controls.Add(this.trimestreComboBox);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadístico";
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox trimestreComboBox;
        private System.Windows.Forms.DataGridView listadoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox anioTextBox;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton clientesRadioButton;
        private System.Windows.Forms.Button listarBtn;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button limpiarBtn;
    }
}