namespace PagoAgilFrba
{
    partial class SelectRol
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
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.SeleccionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Rol con el cual desea ingresar:";
            // 
            // comboRol
            // 
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(172, 95);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(217, 21);
            this.comboRol.TabIndex = 1;
            // 
            // SeleccionBtn
            // 
            this.SeleccionBtn.Location = new System.Drawing.Point(241, 145);
            this.SeleccionBtn.Name = "SeleccionBtn";
            this.SeleccionBtn.Size = new System.Drawing.Size(75, 23);
            this.SeleccionBtn.TabIndex = 2;
            this.SeleccionBtn.Text = "Seleccionar";
            this.SeleccionBtn.UseVisualStyleBackColor = true;
            this.SeleccionBtn.Click += new System.EventHandler(this.SeleccionBtn_Click);
            // 
            // SelectRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 261);
            this.Controls.Add(this.SeleccionBtn);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.label1);
            this.Name = "SelectRol";
            this.Text = "Seleccione Rol";
            this.Load += new System.EventHandler(this.SelectRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Button SeleccionBtn;
    }
}