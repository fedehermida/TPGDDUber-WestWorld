namespace PagoAgilFrba.AbmSucursal
{
    partial class sucursalABM
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
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoPostalTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sucursalDataGrid = new System.Windows.Forms.DataGridView();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.habilitadoCheck = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.filtrarGroupBox = new System.Windows.Forms.GroupBox();
            this.codigoPostalFilterTxtBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.apellidoFilterTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreFilterTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalDataGrid)).BeginInit();
            this.filtrarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(489, 33);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(121, 20);
            this.direccionTextBox.TabIndex = 11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(125, 33);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(126, 20);
            this.nombreTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // codigoPostalTxtBox
            // 
            this.codigoPostalTxtBox.Location = new System.Drawing.Point(125, 87);
            this.codigoPostalTxtBox.Name = "codigoPostalTxtBox";
            this.codigoPostalTxtBox.Size = new System.Drawing.Size(126, 20);
            this.codigoPostalTxtBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Codigo Postal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sucursalDataGrid
            // 
            this.sucursalDataGrid.AllowUserToAddRows = false;
            this.sucursalDataGrid.AllowUserToDeleteRows = false;
            this.sucursalDataGrid.AllowUserToResizeRows = false;
            this.sucursalDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sucursalDataGrid.Location = new System.Drawing.Point(37, 208);
            this.sucursalDataGrid.Name = "sucursalDataGrid";
            this.sucursalDataGrid.ReadOnly = true;
            this.sucursalDataGrid.Size = new System.Drawing.Size(793, 150);
            this.sucursalDataGrid.TabIndex = 36;
            this.sucursalDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sucursalDataGrid_MouseDoubleClick);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(683, 47);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(96, 37);
            this.guardarBtn.TabIndex = 28;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // habilitadoCheck
            // 
            this.habilitadoCheck.AutoSize = true;
            this.habilitadoCheck.Location = new System.Drawing.Point(495, 87);
            this.habilitadoCheck.Name = "habilitadoCheck";
            this.habilitadoCheck.Size = new System.Drawing.Size(15, 14);
            this.habilitadoCheck.TabIndex = 40;
            this.habilitadoCheck.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(401, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Habilitado";
            // 
            // filtrarGroupBox
            // 
            this.filtrarGroupBox.Controls.Add(this.codigoPostalFilterTxtBox);
            this.filtrarGroupBox.Controls.Add(this.searchButton);
            this.filtrarGroupBox.Controls.Add(this.label8);
            this.filtrarGroupBox.Controls.Add(this.apellidoFilterTxt);
            this.filtrarGroupBox.Controls.Add(this.label7);
            this.filtrarGroupBox.Controls.Add(this.nombreFilterTxt);
            this.filtrarGroupBox.Controls.Add(this.label6);
            this.filtrarGroupBox.Location = new System.Drawing.Point(33, 146);
            this.filtrarGroupBox.Name = "filtrarGroupBox";
            this.filtrarGroupBox.Size = new System.Drawing.Size(797, 56);
            this.filtrarGroupBox.TabIndex = 42;
            this.filtrarGroupBox.TabStop = false;
            this.filtrarGroupBox.Text = "Criterio De Búsqueda";
            // 
            // codigoPostalFilterTxtBox
            // 
            this.codigoPostalFilterTxtBox.Location = new System.Drawing.Point(542, 23);
            this.codigoPostalFilterTxtBox.Name = "codigoPostalFilterTxtBox";
            this.codigoPostalFilterTxtBox.Size = new System.Drawing.Size(63, 20);
            this.codigoPostalFilterTxtBox.TabIndex = 48;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(650, 21);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 23);
            this.searchButton.TabIndex = 47;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Codigo Postal";
            // 
            // apellidoFilterTxt
            // 
            this.apellidoFilterTxt.Location = new System.Drawing.Point(283, 24);
            this.apellidoFilterTxt.Name = "apellidoFilterTxt";
            this.apellidoFilterTxt.Size = new System.Drawing.Size(163, 20);
            this.apellidoFilterTxt.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Direccion";
            // 
            // nombreFilterTxt
            // 
            this.nombreFilterTxt.Location = new System.Drawing.Point(71, 24);
            this.nombreFilterTxt.Name = "nombreFilterTxt";
            this.nombreFilterTxt.Size = new System.Drawing.Size(124, 20);
            this.nombreFilterTxt.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nombre";
            // 
            // sucursalABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 424);
            this.Controls.Add(this.filtrarGroupBox);
            this.Controls.Add(this.habilitadoCheck);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sucursalDataGrid);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.codigoPostalTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "sucursalABM";
            this.Text = "ABM Sucursal";
            ((System.ComponentModel.ISupportInitialize)(this.sucursalDataGrid)).EndInit();
            this.filtrarGroupBox.ResumeLayout(false);
            this.filtrarGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoPostalTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView sucursalDataGrid;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.CheckBox habilitadoCheck;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox filtrarGroupBox;
        private System.Windows.Forms.TextBox codigoPostalFilterTxtBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox apellidoFilterTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombreFilterTxt;
        private System.Windows.Forms.Label label6;
    }
}