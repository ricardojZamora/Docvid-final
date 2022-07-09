namespace Docvid.GUI.Gestores.Documentos
{
    partial class agregardocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregardocumento));
            this.txtruta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtidevidencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidproyecto = new System.Windows.Forms.TextBox();
            this.rddestacado = new System.Windows.Forms.RadioButton();
            this.rdnodestacado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscarcadena = new System.Windows.Forms.Button();
            this.lblseleccion = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblproyectoseleccionado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.txthash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnbuscartipoevidencia = new System.Windows.Forms.Button();
            this.txttipoevidencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltipodeevidenciaseleccion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // txtruta
            // 
            this.txtruta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtruta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruta.Location = new System.Drawing.Point(117, 100);
            this.txtruta.Name = "txtruta";
            this.txtruta.ReadOnly = true;
            this.txtruta.Size = new System.Drawing.Size(438, 20);
            this.txtruta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(264, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Haga click en el boton procesar para cargar archivo";
            // 
            // btnprocesar
            // 
            this.btnprocesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnprocesar.FlatAppearance.BorderSize = 0;
            this.btnprocesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnprocesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprocesar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocesar.ForeColor = System.Drawing.Color.White;
            this.btnprocesar.Location = new System.Drawing.Point(561, 100);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(75, 23);
            this.btnprocesar.TabIndex = 2;
            this.btnprocesar.Text = "Archivo";
            this.btnprocesar.UseVisualStyleBackColor = false;
            this.btnprocesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(402, 487);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtidevidencia
            // 
            this.txtidevidencia.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtidevidencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidevidencia.Location = new System.Drawing.Point(646, 37);
            this.txtidevidencia.Name = "txtidevidencia";
            this.txtidevidencia.ReadOnly = true;
            this.txtidevidencia.Size = new System.Drawing.Size(100, 20);
            this.txtidevidencia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(655, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID evidencia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnota
            // 
            this.txtnota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtnota.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota.Location = new System.Drawing.Point(117, 375);
            this.txtnota.Multiline = true;
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(535, 106);
            this.txtnota.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(357, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nota(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(308, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID Proyecto";
            // 
            // txtidproyecto
            // 
            this.txtidproyecto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtidproyecto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidproyecto.Location = new System.Drawing.Point(282, 209);
            this.txtidproyecto.Name = "txtidproyecto";
            this.txtidproyecto.ReadOnly = true;
            this.txtidproyecto.Size = new System.Drawing.Size(123, 20);
            this.txtidproyecto.TabIndex = 9;
            // 
            // rddestacado
            // 
            this.rddestacado.AutoSize = true;
            this.rddestacado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddestacado.ForeColor = System.Drawing.SystemColors.Control;
            this.rddestacado.Location = new System.Drawing.Point(6, 19);
            this.rddestacado.Name = "rddestacado";
            this.rddestacado.Size = new System.Drawing.Size(86, 17);
            this.rddestacado.TabIndex = 11;
            this.rddestacado.TabStop = true;
            this.rddestacado.Text = "Destacado";
            this.rddestacado.UseVisualStyleBackColor = true;
            // 
            // rdnodestacado
            // 
            this.rdnodestacado.AutoSize = true;
            this.rdnodestacado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnodestacado.ForeColor = System.Drawing.SystemColors.Control;
            this.rdnodestacado.Location = new System.Drawing.Point(6, 38);
            this.rdnodestacado.Name = "rdnodestacado";
            this.rdnodestacado.Size = new System.Drawing.Size(104, 17);
            this.rdnodestacado.TabIndex = 12;
            this.rdnodestacado.TabStop = true;
            this.rdnodestacado.Text = "No destacado";
            this.rdnodestacado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rddestacado);
            this.groupBox1.Controls.Add(this.rdnodestacado);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(42, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 61);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destacado";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnbuscarcadena
            // 
            this.btnbuscarcadena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnbuscarcadena.FlatAppearance.BorderSize = 0;
            this.btnbuscarcadena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnbuscarcadena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarcadena.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarcadena.ForeColor = System.Drawing.Color.White;
            this.btnbuscarcadena.Location = new System.Drawing.Point(411, 207);
            this.btnbuscarcadena.Name = "btnbuscarcadena";
            this.btnbuscarcadena.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarcadena.TabIndex = 14;
            this.btnbuscarcadena.Text = "Buscar";
            this.btnbuscarcadena.UseVisualStyleBackColor = false;
            this.btnbuscarcadena.Click += new System.EventHandler(this.btnbuscarcadena_Click);
            // 
            // lblseleccion
            // 
            this.lblseleccion.AutoSize = true;
            this.lblseleccion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseleccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblseleccion.Location = new System.Drawing.Point(276, 233);
            this.lblseleccion.Name = "lblseleccion";
            this.lblseleccion.Size = new System.Drawing.Size(145, 14);
            this.lblseleccion.TabIndex = 15;
            this.lblseleccion.Text = "ID proyecto seleccionado";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(283, 487);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 16;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // lblproyectoseleccionado
            // 
            this.lblproyectoseleccionado.AutoSize = true;
            this.lblproyectoseleccionado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproyectoseleccionado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblproyectoseleccionado.Location = new System.Drawing.Point(434, 233);
            this.lblproyectoseleccionado.Name = "lblproyectoseleccionado";
            this.lblproyectoseleccionado.Size = new System.Drawing.Size(53, 14);
            this.lblproyectoseleccionado.TabIndex = 17;
            this.lblproyectoseleccionado.Text = "Muestra";
            this.lblproyectoseleccionado.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(642, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Quitar enlace";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(561, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Carpeta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txthash
            // 
            this.txthash.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txthash.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthash.Location = new System.Drawing.Point(259, 136);
            this.txthash.Name = "txthash";
            this.txthash.ReadOnly = true;
            this.txthash.Size = new System.Drawing.Size(295, 20);
            this.txthash.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(74, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hash de archivo seleccionado";
            // 
            // btnbuscartipoevidencia
            // 
            this.btnbuscartipoevidencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnbuscartipoevidencia.FlatAppearance.BorderSize = 0;
            this.btnbuscartipoevidencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnbuscartipoevidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscartipoevidencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscartipoevidencia.ForeColor = System.Drawing.Color.White;
            this.btnbuscartipoevidencia.Location = new System.Drawing.Point(411, 292);
            this.btnbuscartipoevidencia.Name = "btnbuscartipoevidencia";
            this.btnbuscartipoevidencia.Size = new System.Drawing.Size(75, 23);
            this.btnbuscartipoevidencia.TabIndex = 24;
            this.btnbuscartipoevidencia.Text = "Buscar";
            this.btnbuscartipoevidencia.UseVisualStyleBackColor = false;
            this.btnbuscartipoevidencia.Click += new System.EventHandler(this.btnbuscartipoevidencia_Click);
            // 
            // txttipoevidencia
            // 
            this.txttipoevidencia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txttipoevidencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipoevidencia.Location = new System.Drawing.Point(282, 294);
            this.txttipoevidencia.Name = "txttipoevidencia";
            this.txttipoevidencia.ReadOnly = true;
            this.txttipoevidencia.Size = new System.Drawing.Size(123, 20);
            this.txttipoevidencia.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(296, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 14);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tipo de evidencia";
            // 
            // lbltipodeevidenciaseleccion
            // 
            this.lbltipodeevidenciaseleccion.AutoSize = true;
            this.lbltipodeevidenciaseleccion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipodeevidenciaseleccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltipodeevidenciaseleccion.Location = new System.Drawing.Point(438, 318);
            this.lbltipodeevidenciaseleccion.Name = "lbltipodeevidenciaseleccion";
            this.lbltipodeevidenciaseleccion.Size = new System.Drawing.Size(53, 14);
            this.lbltipodeevidenciaseleccion.TabIndex = 26;
            this.lbltipodeevidenciaseleccion.Text = "Muestra";
            this.lbltipodeevidenciaseleccion.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(244, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tipo de evidencia seleccionada";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // agregardocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(758, 542);
            this.Controls.Add(this.lbltipodeevidenciaseleccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnbuscartipoevidencia);
            this.Controls.Add(this.txttipoevidencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txthash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblproyectoseleccionado);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lblseleccion);
            this.Controls.Add(this.btnbuscarcadena);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtidproyecto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidevidencia);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtruta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregardocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrgando evidencia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.agregardocumento_FormClosed);
            this.Load += new System.EventHandler(this.agregardocumento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtidevidencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscarcadena;
        private System.Windows.Forms.Label lblseleccion;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.TextBox txtruta;
        public System.Windows.Forms.TextBox txtnota;
        public System.Windows.Forms.TextBox txtidproyecto;
        public System.Windows.Forms.RadioButton rddestacado;
        public System.Windows.Forms.RadioButton rdnodestacado;
        public System.Windows.Forms.Label lblproyectoseleccionado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        public System.Windows.Forms.TextBox txthash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnbuscartipoevidencia;
        public System.Windows.Forms.TextBox txttipoevidencia;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbltipodeevidenciaseleccion;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}