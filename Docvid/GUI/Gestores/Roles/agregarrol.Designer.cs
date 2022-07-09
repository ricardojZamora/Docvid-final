namespace Docvid.GUI.Gestores.Roles
{
    partial class agregarrol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarrol));
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtidpermiso = new System.Windows.Forms.TextBox();
            this.btngestionarpermiso = new System.Windows.Forms.Button();
            this.lblpermiso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(95, 25);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(62, 20);
            this.txtid.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(113, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "ID";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Descripción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(95, 71);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(335, 25);
            this.txtdescripcion.TabIndex = 14;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(272, 170);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(145, 170);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 12;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // txtidpermiso
            // 
            this.txtidpermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtidpermiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidpermiso.Location = new System.Drawing.Point(420, 172);
            this.txtidpermiso.Multiline = true;
            this.txtidpermiso.Name = "txtidpermiso";
            this.txtidpermiso.ReadOnly = true;
            this.txtidpermiso.Size = new System.Drawing.Size(73, 25);
            this.txtidpermiso.TabIndex = 25;
            this.txtidpermiso.Visible = false;
            // 
            // btngestionarpermiso
            // 
            this.btngestionarpermiso.ForeColor = System.Drawing.Color.White;
            this.btngestionarpermiso.Location = new System.Drawing.Point(95, 128);
            this.btngestionarpermiso.Name = "btngestionarpermiso";
            this.btngestionarpermiso.Size = new System.Drawing.Size(335, 23);
            this.btngestionarpermiso.TabIndex = 26;
            this.btngestionarpermiso.Text = "Gestionar permisos";
            this.btngestionarpermiso.UseVisualStyleBackColor = true;
            this.btngestionarpermiso.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblpermiso
            // 
            this.lblpermiso.ForeColor = System.Drawing.Color.White;
            this.lblpermiso.Location = new System.Drawing.Point(95, 107);
            this.lblpermiso.Name = "lblpermiso";
            this.lblpermiso.Size = new System.Drawing.Size(335, 18);
            this.lblpermiso.TabIndex = 24;
            this.lblpermiso.Text = "Permisos";
            this.lblpermiso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // agregarrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(520, 205);
            this.Controls.Add(this.btngestionarpermiso);
            this.Controls.Add(this.txtidpermiso);
            this.Controls.Add(this.lblpermiso);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregarrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregando rol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.agregarrol_FormClosed);
            this.Load += new System.EventHandler(this.agregarrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Button btngestionarpermiso;
        public System.Windows.Forms.TextBox txtidpermiso;
        private System.Windows.Forms.Label lblpermiso;

    }
}