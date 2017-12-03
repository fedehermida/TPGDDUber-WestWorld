namespace PagoAgilFrba
{
    partial class BuscarCliente
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
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.filtrarGroupBox = new System.Windows.Forms.GroupBox();
            this.dniFilterTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.apellidoFilterTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nombreFilterTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.filtrarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AllowUserToResizeColumns = false;
            this.clienteDataGridView.AllowUserToResizeRows = false;
            this.clienteDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Location = new System.Drawing.Point(12, 28);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.clienteDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteDataGridView.Size = new System.Drawing.Size(308, 144);
            this.clienteDataGridView.TabIndex = 0;
            this.clienteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteDataGridView_Seleccionar);
            this.clienteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteDataGridView_Seleccionar);
            this.clienteDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteDataGridView_Seleccionar);
            // 
            // filtrarGroupBox
            // 
            this.filtrarGroupBox.Controls.Add(this.dniFilterTextBox);
            this.filtrarGroupBox.Controls.Add(this.label12);
            this.filtrarGroupBox.Controls.Add(this.searchButton);
            this.filtrarGroupBox.Controls.Add(this.apellidoFilterTxt);
            this.filtrarGroupBox.Controls.Add(this.label11);
            this.filtrarGroupBox.Controls.Add(this.nombreFilterTxt);
            this.filtrarGroupBox.Controls.Add(this.label10);
            this.filtrarGroupBox.Location = new System.Drawing.Point(326, 12);
            this.filtrarGroupBox.Name = "filtrarGroupBox";
            this.filtrarGroupBox.Size = new System.Drawing.Size(206, 168);
            this.filtrarGroupBox.TabIndex = 32;
            this.filtrarGroupBox.TabStop = false;
            this.filtrarGroupBox.Text = "Criterio De Búsqueda";
            // 
            // dniFilterTextBox
            // 
            this.dniFilterTextBox.Location = new System.Drawing.Point(77, 98);
            this.dniFilterTextBox.Name = "dniFilterTextBox";
            this.dniFilterTextBox.Size = new System.Drawing.Size(118, 20);
            this.dniFilterTextBox.TabIndex = 30;
            this.dniFilterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dniFilterTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "DNI";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(47, 137);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 23);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // apellidoFilterTxt
            // 
            this.apellidoFilterTxt.Location = new System.Drawing.Point(77, 59);
            this.apellidoFilterTxt.Name = "apellidoFilterTxt";
            this.apellidoFilterTxt.Size = new System.Drawing.Size(118, 20);
            this.apellidoFilterTxt.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Apellido";
            // 
            // nombreFilterTxt
            // 
            this.nombreFilterTxt.Location = new System.Drawing.Point(77, 22);
            this.nombreFilterTxt.Name = "nombreFilterTxt";
            this.nombreFilterTxt.Size = new System.Drawing.Size(118, 20);
            this.nombreFilterTxt.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nombre";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Enabled = false;
            this.clienteTextBox.Location = new System.Drawing.Point(61, 199);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(173, 20);
            this.clienteTextBox.TabIndex = 31;
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.Location = new System.Drawing.Point(240, 190);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(87, 37);
            this.seleccionarBtn.TabIndex = 31;
            this.seleccionarBtn.Text = "CONFIRMAR";
            this.seleccionarBtn.UseVisualStyleBackColor = true;
            this.seleccionarBtn.Click += new System.EventHandler(this.confirmarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(439, 194);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(93, 29);
            this.cancelarBtn.TabIndex = 33;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.Enabled = false;
            this.idClienteTextBox.Location = new System.Drawing.Point(12, 199);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(43, 20);
            this.idClienteTextBox.TabIndex = 34;
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 240);
            this.Controls.Add(this.idClienteTextBox);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.seleccionarBtn);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.filtrarGroupBox);
            this.Controls.Add(this.clienteDataGridView);
            this.Name = "BuscarCliente";
            this.Text = "Seleccionar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.filtrarGroupBox.ResumeLayout(false);
            this.filtrarGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.GroupBox filtrarGroupBox;
        private System.Windows.Forms.TextBox dniFilterTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox apellidoFilterTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nombreFilterTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button seleccionarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        public System.Windows.Forms.TextBox clienteTextBox;
        public System.Windows.Forms.TextBox idClienteTextBox;
    }
}