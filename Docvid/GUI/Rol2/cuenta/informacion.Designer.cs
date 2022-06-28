namespace Docvid.GUI.Rol2.cuenta
{
    partial class informacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informacion));
            this.lblusuarionombre = new System.Windows.Forms.Label();
            this.lblrol = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btncambiarcontra = new System.Windows.Forms.Button();
            this.btnsuspender = new System.Windows.Forms.Button();
            this.dtgvdatos = new System.Windows.Forms.DataGridView();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltelefono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusuarionombre
            // 
            this.lblusuarionombre.AutoSize = true;
            this.lblusuarionombre.BackColor = System.Drawing.Color.Transparent;
            this.lblusuarionombre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuarionombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblusuarionombre.Location = new System.Drawing.Point(48, 54);
            this.lblusuarionombre.Name = "lblusuarionombre";
            this.lblusuarionombre.Size = new System.Drawing.Size(91, 24);
            this.lblusuarionombre.TabIndex = 7;
            this.lblusuarionombre.Text = "Usuario: ";
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.BackColor = System.Drawing.Color.Transparent;
            this.lblrol.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrol.ForeColor = System.Drawing.SystemColors.Control;
            this.lblrol.Location = new System.Drawing.Point(48, 177);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(53, 24);
            this.lblrol.TabIndex = 8;
            this.lblrol.Text = "Rol: ";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.SystemColors.Control;
            this.lblid.Location = new System.Drawing.Point(48, 301);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(44, 24);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "ID: ";
            // 
            // btncambiarcontra
            // 
            this.btncambiarcontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncambiarcontra.FlatAppearance.BorderSize = 0;
            this.btncambiarcontra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncambiarcontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncambiarcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncambiarcontra.ForeColor = System.Drawing.Color.White;
            this.btncambiarcontra.Location = new System.Drawing.Point(574, 489);
            this.btncambiarcontra.Name = "btncambiarcontra";
            this.btncambiarcontra.Size = new System.Drawing.Size(195, 35);
            this.btncambiarcontra.TabIndex = 10;
            this.btncambiarcontra.Text = "Cambiar contraseña";
            this.btncambiarcontra.UseVisualStyleBackColor = false;
            this.btncambiarcontra.Click += new System.EventHandler(this.btncambiarcontra_Click);
            // 
            // btnsuspender
            // 
            this.btnsuspender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnsuspender.FlatAppearance.BorderSize = 0;
            this.btnsuspender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnsuspender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuspender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuspender.ForeColor = System.Drawing.Color.White;
            this.btnsuspender.Location = new System.Drawing.Point(52, 489);
            this.btnsuspender.Name = "btnsuspender";
            this.btnsuspender.Size = new System.Drawing.Size(195, 35);
            this.btnsuspender.TabIndex = 11;
            this.btnsuspender.Text = "Suspender mi cuenta";
            this.btnsuspender.UseVisualStyleBackColor = false;
            this.btnsuspender.Click += new System.EventHandler(this.btnsuspender_Click);
            // 
            // dtgvdatos
            // 
            this.dtgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cargo});
            this.dtgvdatos.Location = new System.Drawing.Point(292, 26);
            this.dtgvdatos.Name = "dtgvdatos";
            this.dtgvdatos.Size = new System.Drawing.Size(111, 101);
            this.dtgvdatos.TabIndex = 12;
            this.dtgvdatos.Visible = false;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "descripcion";
            this.cargo.HeaderText = "cargo";
            this.cargo.Name = "cargo";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.BackColor = System.Drawing.Color.Transparent;
            this.lbltelefono.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltelefono.Location = new System.Drawing.Point(48, 398);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(98, 24);
            this.lbltelefono.TabIndex = 13;
            this.lbltelefono.Text = "Telefono: ";
            // 
            // informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(880, 566);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.dtgvdatos);
            this.Controls.Add(this.btnsuspender);
            this.Controls.Add(this.btncambiarcontra);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblrol);
            this.Controls.Add(this.lblusuarionombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "informacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "informacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.informacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuarionombre;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btncambiarcontra;
        private System.Windows.Forms.Button btnsuspender;
        private System.Windows.Forms.DataGridView dtgvdatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.Label lbltelefono;

    }
}