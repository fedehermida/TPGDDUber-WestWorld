﻿namespace PagoAgilFrba
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
            this.SuspendLayout();
            // 
            // ABMClienteBtn
            // 
            this.ABMClienteBtn.Location = new System.Drawing.Point(27, 12);
            this.ABMClienteBtn.Name = "ABMClienteBtn";
            this.ABMClienteBtn.Size = new System.Drawing.Size(218, 47);
            this.ABMClienteBtn.TabIndex = 0;
            this.ABMClienteBtn.Text = "ABM Cliente";
            this.ABMClienteBtn.UseVisualStyleBackColor = true;
            this.ABMClienteBtn.Click += new System.EventHandler(this.ABMClienteBtn_Click);
            // 
            // ABMEmpresaBtn
            // 
            this.ABMEmpresaBtn.Location = new System.Drawing.Point(288, 12);
            this.ABMEmpresaBtn.Name = "ABMEmpresaBtn";
            this.ABMEmpresaBtn.Size = new System.Drawing.Size(218, 47);
            this.ABMEmpresaBtn.TabIndex = 1;
            this.ABMEmpresaBtn.Text = "ABM Empresa";
            this.ABMEmpresaBtn.UseVisualStyleBackColor = true;
            this.ABMEmpresaBtn.Click += new System.EventHandler(this.ABMEmpresaBtn_Click);
            // 
            // AbmSucursalBtn
            // 
            this.AbmSucursalBtn.Location = new System.Drawing.Point(553, 12);
            this.AbmSucursalBtn.Name = "AbmSucursalBtn";
            this.AbmSucursalBtn.Size = new System.Drawing.Size(218, 47);
            this.AbmSucursalBtn.TabIndex = 2;
            this.AbmSucursalBtn.Text = "ABM Sucursal";
            this.AbmSucursalBtn.UseVisualStyleBackColor = true;
            this.AbmSucursalBtn.Click += new System.EventHandler(this.AbmSucursalBtn_Click);
            // 
            // ABMFacturaBtn
            // 
            this.ABMFacturaBtn.Location = new System.Drawing.Point(27, 89);
            this.ABMFacturaBtn.Name = "ABMFacturaBtn";
            this.ABMFacturaBtn.Size = new System.Drawing.Size(218, 57);
            this.ABMFacturaBtn.TabIndex = 3;
            this.ABMFacturaBtn.Text = "ABM Factura";
            this.ABMFacturaBtn.UseVisualStyleBackColor = true;
            this.ABMFacturaBtn.Click += new System.EventHandler(this.ABMFacturaBtn_Click);
            // 
            // registarPagoBtn
            // 
            this.registarPagoBtn.Location = new System.Drawing.Point(288, 89);
            this.registarPagoBtn.Name = "registarPagoBtn";
            this.registarPagoBtn.Size = new System.Drawing.Size(218, 57);
            this.registarPagoBtn.TabIndex = 4;
            this.registarPagoBtn.Text = "Registar Pago";
            this.registarPagoBtn.UseVisualStyleBackColor = true;
            this.registarPagoBtn.Click += new System.EventHandler(this.registarPagoBtn_Click);
            // 
            // rendirFacturasBtn
            // 
            this.rendirFacturasBtn.Location = new System.Drawing.Point(553, 89);
            this.rendirFacturasBtn.Name = "rendirFacturasBtn";
            this.rendirFacturasBtn.Size = new System.Drawing.Size(218, 57);
            this.rendirFacturasBtn.TabIndex = 5;
            this.rendirFacturasBtn.Text = "Rendir Facturas";
            this.rendirFacturasBtn.UseVisualStyleBackColor = true;
            this.rendirFacturasBtn.Click += new System.EventHandler(this.rendirFacturasBtn_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 317);
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
    }
}

