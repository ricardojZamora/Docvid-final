namespace Docvid.GUI.Gestores.Usuarios
{
    partial class agregarusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarusuario));
            this.txtidusuarioo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcredencial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnagregarrol = new System.Windows.Forms.Button();
            this.lbldescripcionrol = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rddactivo = new System.Windows.Forms.RadioButton();
            this.rddsuspendido = new System.Windows.Forms.RadioButton();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtidrolss = new System.Windows.Forms.ComboBox();
            this.txtidrol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidusuarioo
            // 
            this.txtidusuarioo.Location = new System.Drawing.Point(481, 41);
            this.txtidusuarioo.Name = "txtidusuarioo";
            this.txtidusuarioo.ReadOnly = true;
            this.txtidusuarioo.Size = new System.Drawing.Size(62, 20);
            this.txtidusuarioo.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(500, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(230, 25);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(96, 13);
            this.lblusuario.TabIndex = 13;
            this.lblusuario.Text = "Nombre de usuario";
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Location = new System.Drawing.Point(154, 41);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(249, 20);
            this.txtnombreusuario.TabIndex = 12;
            this.txtnombreusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreusuario_KeyPress);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(328, 226);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 17;
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
            this.btnagregar.Location = new System.Drawing.Point(155, 226);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 16;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Credencial";
            // 
            // txtcredencial
            // 
            this.txtcredencial.Location = new System.Drawing.Point(155, 97);
            this.txtcredencial.Name = "txtcredencial";
            this.txtcredencial.PasswordChar = '*';
            this.txtcredencial.Size = new System.Drawing.Size(249, 20);
            this.txtcredencial.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(249, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rol";
            // 
            // btnagregarrol
            // 
            this.btnagregarrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnagregarrol.FlatAppearance.BorderSize = 0;
            this.btnagregarrol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnagregarrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarrol.ForeColor = System.Drawing.Color.White;
            this.btnagregarrol.Location = new System.Drawing.Point(410, 187);
            this.btnagregarrol.Name = "btnagregarrol";
            this.btnagregarrol.Size = new System.Drawing.Size(75, 23);
            this.btnagregarrol.TabIndex = 29;
            this.btnagregarrol.Text = "Agregar";
            this.btnagregarrol.UseVisualStyleBackColor = false;
            this.btnagregarrol.Click += new System.EventHandler(this.btnagregarrol_Click);
            // 
            // lbldescripcionrol
            // 
            this.lbldescripcionrol.AutoSize = true;
            this.lbldescripcionrol.ForeColor = System.Drawing.Color.White;
            this.lbldescripcionrol.Location = new System.Drawing.Point(53, 164);
            this.lbldescripcionrol.Name = "lbldescripcionrol";
            this.lbldescripcionrol.Size = new System.Drawing.Size(74, 13);
            this.lbldescripcionrol.TabIndex = 31;
            this.lbldescripcionrol.Text = "Seleccione rol";
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rddactivo);
            this.groupBox1.Controls.Add(this.rddsuspendido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 61);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // rddactivo
            // 
            this.rddactivo.AutoSize = true;
            this.rddactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddactivo.ForeColor = System.Drawing.Color.White;
            this.rddactivo.Location = new System.Drawing.Point(6, 19);
            this.rddactivo.Name = "rddactivo";
            this.rddactivo.Size = new System.Drawing.Size(61, 17);
            this.rddactivo.TabIndex = 11;
            this.rddactivo.TabStop = true;
            this.rddactivo.Text = "Activo";
            this.rddactivo.UseVisualStyleBackColor = true;
            // 
            // rddsuspendido
            // 
            this.rddsuspendido.AutoSize = true;
            this.rddsuspendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddsuspendido.ForeColor = System.Drawing.Color.White;
            this.rddsuspendido.Location = new System.Drawing.Point(6, 38);
            this.rddsuspendido.Name = "rddsuspendido";
            this.rddsuspendido.Size = new System.Drawing.Size(91, 17);
            this.rddsuspendido.TabIndex = 12;
            this.rddsuspendido.TabStop = true;
            this.rddsuspendido.Text = "Suspendido";
            this.rddsuspendido.UseVisualStyleBackColor = true;
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(472, 104);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(121, 21);
            this.cbb1.TabIndex = 33;
            this.cbb1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Telefono";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(155, 143);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(249, 20);
            this.txttelefono.TabIndex = 34;
            // 
            // txtidrolss
            // 
            this.txtidrolss.FormattingEnabled = true;
            this.txtidrolss.Location = new System.Drawing.Point(486, 236);
            this.txtidrolss.Name = "txtidrolss";
            this.txtidrolss.Size = new System.Drawing.Size(121, 21);
            this.txtidrolss.TabIndex = 36;
            this.txtidrolss.Visible = false;
            // 
            // txtidrol
            // 
            this.txtidrol.Location = new System.Drawing.Point(155, 190);
            this.txtidrol.Name = "txtidrol";
            this.txtidrol.ReadOnly = true;
            this.txtidrol.Size = new System.Drawing.Size(249, 20);
            this.txtidrol.TabIndex = 28;
            this.txtidrol.TextChanged += new System.EventHandler(this.txtidrol_TextChanged);
            // 
            // agregarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(619, 269);
            this.Controls.Add(this.txtidrolss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldescripcionrol);
            this.Controls.Add(this.btnagregarrol);
            this.Controls.Add(this.txtidrol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcredencial);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtidusuarioo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txtnombreusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregarusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregando usuario";
            this.Load += new System.EventHandler(this.agregarusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtidusuarioo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblusuario;
        public System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtcredencial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnagregarrol;
        public System.Windows.Forms.Label lbldescripcionrol;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rddactivo;
        public System.Windows.Forms.RadioButton rddsuspendido;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txttelefono;
        public System.Windows.Forms.ComboBox txtidrolss;
        public System.Windows.Forms.TextBox txtidrol;
    }
}