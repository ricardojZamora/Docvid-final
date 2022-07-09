namespace Docvid.GUI.Gestores.permisos
{
    partial class listadepermisos
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
            this.lstdatos = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtidpermiso = new System.Windows.Forms.TextBox();
            this.lblrolaplicado = new System.Windows.Forms.Label();
            this.btnseleccionarrol = new System.Windows.Forms.Button();
            this.lblidrol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstdatos
            // 
            this.lstdatos.FormattingEnabled = true;
            this.lstdatos.Items.AddRange(new object[] {
            "Solo ver proyectos ",
            "Ver proyectos ajenos",
            "Suspender cuenta",
            "Cambiar credencial",
            "Crear evidencias ",
            "Gestionar usuarios ",
            "Gestionar roles ",
            "Crear proyectos",
            "Compartir proyectos"});
            this.lstdatos.Location = new System.Drawing.Point(36, 27);
            this.lstdatos.Name = "lstdatos";
            this.lstdatos.Size = new System.Drawing.Size(307, 169);
            this.lstdatos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(51, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(225, 248);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 37);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // txtidpermiso
            // 
            this.txtidpermiso.Location = new System.Drawing.Point(243, 3);
            this.txtidpermiso.Name = "txtidpermiso";
            this.txtidpermiso.ReadOnly = true;
            this.txtidpermiso.Size = new System.Drawing.Size(100, 20);
            this.txtidpermiso.TabIndex = 3;
            this.txtidpermiso.Visible = false;
            // 
            // lblrolaplicado
            // 
            this.lblrolaplicado.ForeColor = System.Drawing.Color.White;
            this.lblrolaplicado.Location = new System.Drawing.Point(145, 208);
            this.lblrolaplicado.Name = "lblrolaplicado";
            this.lblrolaplicado.Size = new System.Drawing.Size(198, 23);
            this.lblrolaplicado.TabIndex = 4;
            this.lblrolaplicado.Text = "label1";
            this.lblrolaplicado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnseleccionarrol
            // 
            this.btnseleccionarrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnseleccionarrol.FlatAppearance.BorderSize = 0;
            this.btnseleccionarrol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnseleccionarrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseleccionarrol.ForeColor = System.Drawing.Color.White;
            this.btnseleccionarrol.Location = new System.Drawing.Point(36, 208);
            this.btnseleccionarrol.Name = "btnseleccionarrol";
            this.btnseleccionarrol.Size = new System.Drawing.Size(103, 23);
            this.btnseleccionarrol.TabIndex = 5;
            this.btnseleccionarrol.Text = "Agregar a otro rol";
            this.btnseleccionarrol.UseVisualStyleBackColor = false;
            this.btnseleccionarrol.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblidrol
            // 
            this.lblidrol.ForeColor = System.Drawing.Color.White;
            this.lblidrol.Location = new System.Drawing.Point(33, 5);
            this.lblidrol.Name = "lblidrol";
            this.lblidrol.Size = new System.Drawing.Size(198, 23);
            this.lblidrol.TabIndex = 6;
            this.lblidrol.Text = "ID";
            this.lblidrol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblidrol.Visible = false;
            // 
            // listadepermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(377, 297);
            this.Controls.Add(this.lblidrol);
            this.Controls.Add(this.btnseleccionarrol);
            this.Controls.Add(this.lblrolaplicado);
            this.Controls.Add(this.txtidpermiso);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstdatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "listadepermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de permisos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.listadepermisos_FormClosed);
            this.Load += new System.EventHandler(this.listadepermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstdatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtidpermiso;
        private System.Windows.Forms.Label lblrolaplicado;
        private System.Windows.Forms.Button btnseleccionarrol;
        private System.Windows.Forms.Label lblidrol;
    }
}