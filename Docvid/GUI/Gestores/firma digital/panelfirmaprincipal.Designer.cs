namespace Docvid.GUI.Gestores.firma_digital
{
    partial class panelfirmaprincipal
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
            this.btnbuscarpdf = new System.Windows.Forms.Button();
            this.btnfirma = new System.Windows.Forms.Button();
            this.txtescritura = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbuscarpdf
            // 
            this.btnbuscarpdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnbuscarpdf.FlatAppearance.BorderSize = 0;
            this.btnbuscarpdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnbuscarpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarpdf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarpdf.ForeColor = System.Drawing.Color.White;
            this.btnbuscarpdf.Location = new System.Drawing.Point(22, 7);
            this.btnbuscarpdf.Name = "btnbuscarpdf";
            this.btnbuscarpdf.Size = new System.Drawing.Size(160, 49);
            this.btnbuscarpdf.TabIndex = 0;
            this.btnbuscarpdf.Text = "Buscar PDF";
            this.btnbuscarpdf.UseVisualStyleBackColor = false;
            this.btnbuscarpdf.Click += new System.EventHandler(this.btnbuscarpdf_Click);
            // 
            // btnfirma
            // 
            this.btnfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnfirma.FlatAppearance.BorderSize = 0;
            this.btnfirma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfirma.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfirma.ForeColor = System.Drawing.Color.White;
            this.btnfirma.Location = new System.Drawing.Point(793, 531);
            this.btnfirma.Name = "btnfirma";
            this.btnfirma.Size = new System.Drawing.Size(75, 23);
            this.btnfirma.TabIndex = 1;
            this.btnfirma.Text = "Firmar pdf";
            this.btnfirma.UseVisualStyleBackColor = false;
            this.btnfirma.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtescritura
            // 
            this.txtescritura.Location = new System.Drawing.Point(22, 62);
            this.txtescritura.Multiline = true;
            this.txtescritura.Name = "txtescritura";
            this.txtescritura.Size = new System.Drawing.Size(846, 463);
            this.txtescritura.TabIndex = 2;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(22, 534);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(484, 20);
            this.txtbuscar.TabIndex = 3;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(512, 532);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // panelfirmaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(880, 566);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txtescritura);
            this.Controls.Add(this.btnfirma);
            this.Controls.Add(this.btnbuscarpdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "panelfirmaprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma digital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfirma;
        public System.Windows.Forms.Button btnbuscarpdf;
        public System.Windows.Forms.TextBox txtescritura;
        private System.Windows.Forms.TextBox txtbuscar;
        public System.Windows.Forms.Button btnbuscar;
    }
}