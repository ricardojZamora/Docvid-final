namespace Docvid.GUI.Gestores.Evidencia
{
    partial class todas_las_evidencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.txtfiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReporte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnverificararchivo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblestado = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgvdatos = new System.Windows.Forms.DataGridView();
            this.idevidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoevidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horacorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashactual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chsinfecha = new System.Windows.Forms.CheckBox();
            this.datecalendario = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnmodificar,
            this.toolStripSeparator2,
            this.btneliminar,
            this.toolStripSeparator4,
            this.txtfiltro,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.btnReporte,
            this.toolStripSeparator5,
            this.btnverificararchivo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 31);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton1.Image = global::Docvid.Properties.Resources._1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 28);
            this.toolStripButton1.Text = "Agregar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.Image = global::Docvid.Properties.Resources._2;
            this.btnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(86, 28);
            this.btnmodificar.Text = "Modificar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.Image = global::Docvid.Properties.Resources._3;
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(78, 28);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtfiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(100, 31);
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 28);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // btnReporte
            // 
            this.btnReporte.Image = global::Docvid.Properties.Resources.icons8_informe_de_estadísticas_50;
            this.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(122, 28);
            this.btnReporte.Text = "Generar_Reporte";
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // btnverificararchivo
            // 
            this.btnverificararchivo.Image = global::Docvid.Properties.Resources.icons8_someter_para_aprobacion_24;
            this.btnverificararchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnverificararchivo.Name = "btnverificararchivo";
            this.btnverificararchivo.Size = new System.Drawing.Size(211, 28);
            this.btnverificararchivo.Text = "Verificar manipulacion de archivo";
            this.btnverificararchivo.Click += new System.EventHandler(this.btnverificararchivo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblestado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(867, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblestado
            // 
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(136, 17);
            this.lblestado.Text = "Registros encontrados: 0";
            // 
            // dtgvdatos
            // 
            this.dtgvdatos.AllowUserToAddRows = false;
            this.dtgvdatos.AllowUserToDeleteRows = false;
            this.dtgvdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvdatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvdatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dtgvdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idevidencia,
            this.idproyecto,
            this.tipoevidencia,
            this.idusuario,
            this.hash,
            this.tipo,
            this.dia,
            this.mes,
            this.anio,
            this.hora,
            this.minutos,
            this.fechacorta,
            this.horacorta,
            this.nombreproyecto,
            this.nota,
            this.ruta,
            this.hashactual});
            this.dtgvdatos.EnableHeadersVisualStyles = false;
            this.dtgvdatos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvdatos.Location = new System.Drawing.Point(0, 80);
            this.dtgvdatos.Name = "dtgvdatos";
            this.dtgvdatos.ReadOnly = true;
            this.dtgvdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvdatos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgvdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvdatos.Size = new System.Drawing.Size(880, 461);
            this.dtgvdatos.TabIndex = 20;
            this.dtgvdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdatos_CellContentClick);
            // 
            // idevidencia
            // 
            this.idevidencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idevidencia.DataPropertyName = "idevidencia";
            this.idevidencia.HeaderText = "ID Evidencia";
            this.idevidencia.Name = "idevidencia";
            this.idevidencia.ReadOnly = true;
            this.idevidencia.Width = 96;
            // 
            // idproyecto
            // 
            this.idproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idproyecto.DataPropertyName = "idproyecto";
            this.idproyecto.HeaderText = "ID Proyecto";
            this.idproyecto.Name = "idproyecto";
            this.idproyecto.ReadOnly = true;
            this.idproyecto.Visible = false;
            // 
            // tipoevidencia
            // 
            this.tipoevidencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipoevidencia.DataPropertyName = "tipoevidencia";
            this.tipoevidencia.HeaderText = "Tipo de evidencia";
            this.tipoevidencia.Name = "tipoevidencia";
            this.tipoevidencia.ReadOnly = true;
            this.tipoevidencia.Visible = false;
            // 
            // idusuario
            // 
            this.idusuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idusuario.DataPropertyName = "idusuario";
            this.idusuario.HeaderText = "ID Usuario creador";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            this.idusuario.Visible = false;
            // 
            // hash
            // 
            this.hash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hash.DataPropertyName = "hash";
            this.hash.HeaderText = "Hash";
            this.hash.Name = "hash";
            this.hash.ReadOnly = true;
            this.hash.Visible = false;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 57;
            // 
            // dia
            // 
            this.dia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dia.DataPropertyName = "dia";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dia.DefaultCellStyle = dataGridViewCellStyle10;
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            this.dia.Visible = false;
            // 
            // mes
            // 
            this.mes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mes.DataPropertyName = "mes";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mes.DefaultCellStyle = dataGridViewCellStyle11;
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Visible = false;
            // 
            // anio
            // 
            this.anio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.anio.DataPropertyName = "anio";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.anio.DefaultCellStyle = dataGridViewCellStyle12;
            this.anio.HeaderText = "Anio";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Visible = false;
            // 
            // hora
            // 
            this.hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hora.DataPropertyName = "hora";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hora.DefaultCellStyle = dataGridViewCellStyle13;
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Visible = false;
            // 
            // minutos
            // 
            this.minutos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.minutos.DataPropertyName = "minutos";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.minutos.DefaultCellStyle = dataGridViewCellStyle14;
            this.minutos.HeaderText = "Minutos";
            this.minutos.Name = "minutos";
            this.minutos.ReadOnly = true;
            this.minutos.Visible = false;
            // 
            // fechacorta
            // 
            this.fechacorta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechacorta.HeaderText = "Fecha";
            this.fechacorta.Name = "fechacorta";
            this.fechacorta.ReadOnly = true;
            this.fechacorta.Width = 67;
            // 
            // horacorta
            // 
            this.horacorta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.horacorta.HeaderText = "Hora";
            this.horacorta.Name = "horacorta";
            this.horacorta.ReadOnly = true;
            this.horacorta.Width = 59;
            // 
            // nombreproyecto
            // 
            this.nombreproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreproyecto.DataPropertyName = "nombreproyecto";
            this.nombreproyecto.HeaderText = "Nombre de proyecto";
            this.nombreproyecto.Name = "nombreproyecto";
            this.nombreproyecto.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nota.DataPropertyName = "nota";
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            // 
            // ruta
            // 
            this.ruta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ruta.DataPropertyName = "ruta";
            this.ruta.HeaderText = "Ruta";
            this.ruta.Name = "ruta";
            this.ruta.ReadOnly = true;
            this.ruta.Visible = false;
            // 
            // hashactual
            // 
            this.hashactual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hashactual.DataPropertyName = "hashactual";
            this.hashactual.HeaderText = "Hash actual";
            this.hashactual.Name = "hashactual";
            this.hashactual.ReadOnly = true;
            this.hashactual.Visible = false;
            // 
            // chsinfecha
            // 
            this.chsinfecha.AutoSize = true;
            this.chsinfecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chsinfecha.Location = new System.Drawing.Point(188, 50);
            this.chsinfecha.Name = "chsinfecha";
            this.chsinfecha.Size = new System.Drawing.Size(111, 17);
            this.chsinfecha.TabIndex = 24;
            this.chsinfecha.Text = "Sin importar fecha";
            this.chsinfecha.UseVisualStyleBackColor = true;
            this.chsinfecha.CheckedChanged += new System.EventHandler(this.chsinfecha_CheckedChanged);
            // 
            // datecalendario
            // 
            this.datecalendario.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.datecalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datecalendario.Location = new System.Drawing.Point(503, 43);
            this.datecalendario.Name = "datecalendario";
            this.datecalendario.Size = new System.Drawing.Size(292, 24);
            this.datecalendario.TabIndex = 23;
            this.datecalendario.ValueChanged += new System.EventHandler(this.datecalendario_ValueChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // todas_las_evidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(867, 481);
            this.Controls.Add(this.chsinfecha);
            this.Controls.Add(this.datecalendario);
            this.Controls.Add(this.dtgvdatos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "todas_las_evidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todas las evidencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.todas_las_evidencias_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox txtfiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblestado;
        public System.Windows.Forms.DataGridView dtgvdatos;
        public System.Windows.Forms.CheckBox chsinfecha;
        public System.Windows.Forms.DateTimePicker datecalendario;
        private System.Windows.Forms.ToolStripButton btnverificararchivo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idevidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoevidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn horacorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashactual;
        private System.Windows.Forms.ToolStripButton btnReporte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}