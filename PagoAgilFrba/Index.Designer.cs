namespace PagoAgilFrba
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ABMClienteBtn = new System.Windows.Forms.Button();
            this.ABMEmpresaBtn = new System.Windows.Forms.Button();
            this.AbmSucursalBtn = new System.Windows.Forms.Button();
            this.ABMFacturaBtn = new System.Windows.Forms.Button();
            this.registarPagoBtn = new System.Windows.Forms.Button();
            this.rendirFacturasBtn = new System.Windows.Forms.Button();
            this.abmRolBtn = new System.Windows.Forms.Button();
            this.devolverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ABMClienteBtn
            // 
            this.ABMClienteBtn.Location = new System.Drawing.Point(26, 25);
            this.ABMClienteBtn.Name = "ABMClienteBtn";
            this.ABMClienteBtn.Size = new System.Drawing.Size(218, 57);
            this.ABMClienteBtn.TabIndex = 0;
            this.ABMClienteBtn.Text = "ABM Cliente";
            this.ABMClienteBtn.UseVisualStyleBackColor = true;
            this.ABMClienteBtn.Click += new System.EventHandler(this.ABMClienteBtn_Click);
            // 
            // ABMEmpresaBtn
            // 
            this.ABMEmpresaBtn.Location = new System.Drawing.Point(287, 25);
            this.ABMEmpresaBtn.Name = "ABMEmpresaBtn";
            this.ABMEmpresaBtn.Size = new System.Drawing.Size(218, 57);
            this.ABMEmpresaBtn.TabIndex = 1;
            this.ABMEmpresaBtn.Text = "ABM Empresa";
            this.ABMEmpresaBtn.UseVisualStyleBackColor = true;
            this.ABMEmpresaBtn.Click += new System.EventHandler(this.ABMEmpresaBtn_Click);
            // 
            // AbmSucursalBtn
            // 
            this.AbmSucursalBtn.Location = new System.Drawing.Point(552, 25);
            this.AbmSucursalBtn.Name = "AbmSucursalBtn";
            this.AbmSucursalBtn.Size = new System.Drawing.Size(218, 57);
            this.AbmSucursalBtn.TabIndex = 2;
            this.AbmSucursalBtn.Text = "ABM Sucursal";
            this.AbmSucursalBtn.UseVisualStyleBackColor = true;
            this.AbmSucursalBtn.Click += new System.EventHandler(this.AbmSucursalBtn_Click);
            // 
            // ABMFacturaBtn
            // 
            this.ABMFacturaBtn.Location = new System.Drawing.Point(26, 113);
            this.ABMFacturaBtn.Name = "ABMFacturaBtn";
            this.ABMFacturaBtn.Size = new System.Drawing.Size(218, 57);
            this.ABMFacturaBtn.TabIndex = 3;
            this.ABMFacturaBtn.Text = "ABM Factura";
            this.ABMFacturaBtn.UseVisualStyleBackColor = true;
            this.ABMFacturaBtn.Click += new System.EventHandler(this.ABMFacturaBtn_Click);
            // 
            // registarPagoBtn
            // 
            this.registarPagoBtn.Location = new System.Drawing.Point(552, 111);
            this.registarPagoBtn.Name = "registarPagoBtn";
            this.registarPagoBtn.Size = new System.Drawing.Size(218, 57);
            this.registarPagoBtn.TabIndex = 4;
            this.registarPagoBtn.Text = "Registar Pago";
            this.registarPagoBtn.UseVisualStyleBackColor = true;
            this.registarPagoBtn.Click += new System.EventHandler(this.registarPagoBtn_Click);
            // 
            // rendirFacturasBtn
            // 
            this.rendirFacturasBtn.Location = new System.Drawing.Point(26, 200);
            this.rendirFacturasBtn.Name = "rendirFacturasBtn";
            this.rendirFacturasBtn.Size = new System.Drawing.Size(218, 57);
            this.rendirFacturasBtn.TabIndex = 5;
            this.rendirFacturasBtn.Text = "Rendir Facturas";
            this.rendirFacturasBtn.UseVisualStyleBackColor = true;
            this.rendirFacturasBtn.Click += new System.EventHandler(this.rendirFacturasBtn_Click);
            // 
            // abmRolBtn
            // 
            this.abmRolBtn.Location = new System.Drawing.Point(290, 112);
            this.abmRolBtn.Name = "abmRolBtn";
            this.abmRolBtn.Size = new System.Drawing.Size(218, 56);
            this.abmRolBtn.TabIndex = 7;
            this.abmRolBtn.Text = "ABM Rol";
            this.abmRolBtn.UseVisualStyleBackColor = true;
            // 
            // devolverBtn
            // 
            this.devolverBtn.Location = new System.Drawing.Point(287, 200);
            this.devolverBtn.Name = "devolverBtn";
            this.devolverBtn.Size = new System.Drawing.Size(218, 57);
            this.devolverBtn.TabIndex = 8;
            this.devolverBtn.Text = "Devolver Factura/s";
            this.devolverBtn.UseVisualStyleBackColor = true;
            this.devolverBtn.Click += new System.EventHandler(this.devolverBtn_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 280);
            this.Controls.Add(this.devolverBtn);
            this.Controls.Add(this.abmRolBtn);
            this.Controls.Add(this.rendirFacturasBtn);
            this.Controls.Add(this.registarPagoBtn);
            this.Controls.Add(this.ABMFacturaBtn);
            this.Controls.Add(this.AbmSucursalBtn);
            this.Controls.Add(this.ABMEmpresaBtn);
            this.Controls.Add(this.ABMClienteBtn);
            this.Name = "Index";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ABMClienteBtn;
        private System.Windows.Forms.Button ABMEmpresaBtn;
        private System.Windows.Forms.Button AbmSucursalBtn;
        private System.Windows.Forms.Button ABMFacturaBtn;
        private System.Windows.Forms.Button registarPagoBtn;
        private System.Windows.Forms.Button rendirFacturasBtn;
        private System.Windows.Forms.Button abmRolBtn;
        private System.Windows.Forms.Button devolverBtn;
    }
}

