namespace Docvid.GUI.Gestores.Documentos
{
    partial class gestiondocumentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestiondocumentos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnagregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnverificararchivo = new System.Windows.Forms.ToolStripButton();
            this.txtfiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblestado = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvdatos = new System.Windows.Forms.DataGridView();
            this.idevidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipoevidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoevidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashactual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horacorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecalendario = new System.Windows.Forms.DateTimePicker();
            this.chsinfecha = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnagregar,
            this.toolStripSeparator1,
            this.btnmodificar,
            this.toolStripSeparator2,
            this.btneliminar,
            this.toolStripSeparator3,
            this.btnverificararchivo,
            this.txtfiltro,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1105, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Docvid.Properties.Resources._1;
            this.btnagregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(69, 22);
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = global::Docvid.Properties.Resources._2;
            this.btnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(78, 22);
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Docvid.Properties.Resources._3;
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(70, 22);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnverificararchivo
            // 
            this.btnverificararchivo.Image = global::Docvid.Properties.Resources.icons8_someter_para_aprobacion_24;
            this.btnverificararchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnverificararchivo.Name = "btnverificararchivo";
            this.btnverificararchivo.Size = new System.Drawing.Size(203, 22);
            this.btnverificararchivo.Text = "Verificar manipulacion de archivo";
            this.btnverificararchivo.Click += new System.EventHandler(this.btnverificararchivo_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtfiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(100, 25);
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblestado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1105, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblestado
            // 
            this.lblestado.BackColor = System.Drawing.Color.White;
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(136, 17);
            this.lblestado.Text = "Registros encontrados: 0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1093, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Doble click para abrir un archivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgvdatos
            // 
            this.dtgvdatos.AllowUserToAddRows = false;
            this.dtgvdatos.AllowUserToDeleteRows = false;
            this.dtgvdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvdatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvdatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dtgvdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idevidencia,
            this.idtipoevidencia,
            this.idproyecto,
            this.tipoevidencia,
            this.idusuario,
            this.hash,
            this.hashactual,
            this.tipo,
            this.dia,
            this.mes,
            this.anio,
            this.hora,
            this.minutos,
            this.horacorta,
            this.fechacorta,
            this.nota,
            this.ruta});
            this.dtgvdatos.EnableHeadersVisualStyles = false;
            this.dtgvdatos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvdatos.Location = new System.Drawing.Point(0, 58);
            this.dtgvdatos.Name = "dtgvdatos";
            this.dtgvdatos.ReadOnly = true;
            this.dtgvdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvdatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvdatos.Size = new System.Drawing.Size(1105, 498);
            this.dtgvdatos.TabIndex = 19;
            // 
            // idevidencia
            // 
            this.idevidencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idevidencia.DataPropertyName = "idevidencia";
            this.idevidencia.HeaderText = "ID Evidencia";
            this.idevidencia.Name = "idevidencia";
            this.idevidencia.ReadOnly = true;
            // 
            // idtipoevidencia
            // 
            this.idtipoevidencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idtipoevidencia.DataPropertyName = "idtipoevidencia";
            this.idtipoevidencia.HeaderText = "Id Tipo de evidencia";
            this.idtipoevidencia.Name = "idtipoevidencia";
            this.idtipoevidencia.ReadOnly = true;
            this.idtipoevidencia.Visible = false;
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
            this.tipoevidencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.hash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hash.DataPropertyName = "hash";
            this.hash.HeaderText = "Hash";
            this.hash.Name = "hash";
            this.hash.ReadOnly = true;
            this.hash.Visible = false;
            // 
            // hashactual
            // 
            this.hashactual.DataPropertyName = "hashactual";
            this.hashactual.HeaderText = "Hash actual";
            this.hashactual.Name = "hashactual";
            this.hashactual.ReadOnly = true;
            this.hashactual.Visible = false;
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
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            this.dia.Visible = false;
            // 
            // mes
            // 
            this.mes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Visible = false;
            // 
            // anio
            // 
            this.anio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Anio";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Visible = false;
            // 
            // hora
            // 
            this.hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Visible = false;
            // 
            // minutos
            // 
            this.minutos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.minutos.DataPropertyName = "minutos";
            this.minutos.HeaderText = "Minutos";
            this.minutos.Name = "minutos";
            this.minutos.ReadOnly = true;
            this.minutos.Visible = false;
            // 
            // horacorta
            // 
            this.horacorta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.horacorta.HeaderText = "Hora";
            this.horacorta.Name = "horacorta";
            this.horacorta.ReadOnly = true;
            this.horacorta.Width = 59;
            // 
            // fechacorta
            // 
            this.fechacorta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechacorta.HeaderText = "Fecha";
            this.fechacorta.Name = "fechacorta";
            this.fechacorta.ReadOnly = true;
            this.fechacorta.Width = 67;
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
            // datecalendario
            // 
            this.datecalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datecalendario.Location = new System.Drawing.Point(421, 26);
            this.datecalendario.Name = "datecalendario";
            this.datecalendario.Size = new System.Drawing.Size(292, 24);
            this.datecalendario.TabIndex = 21;
            this.datecalendario.ValueChanged += new System.EventHandler(this.datecalendario_ValueChanged);
            // 
            // chsinfecha
            // 
            this.chsinfecha.AutoSize = true;
            this.chsinfecha.ForeColor = System.Drawing.Color.Black;
            this.chsinfecha.Location = new System.Drawing.Point(745, 30);
            this.chsinfecha.Name = "chsinfecha";
            this.chsinfecha.Size = new System.Drawing.Size(111, 17);
            this.chsinfecha.TabIndex = 22;
            this.chsinfecha.Text = "Sin importar fecha";
            this.chsinfecha.UseVisualStyleBackColor = true;
            this.chsinfecha.CheckedChanged += new System.EventHandler(this.chsinfecha_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // gestiondocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 620);
            this.Controls.Add(this.chsinfecha);
            this.Controls.Add(this.datecalendario);
            this.Controls.Add(this.dtgvdatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestiondocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todos los documentos";
            this.Load += new System.EventHandler(this.gestiondocumentos_Load);
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
        private System.Windows.Forms.ToolStripButton btnagregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripTextBox txtfiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblestado;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dtgvdatos;
        public System.Windows.Forms.DateTimePicker datecalendario;
        public System.Windows.Forms.CheckBox chsinfecha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnverificararchivo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idevidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoevidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoevidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashactual;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn horacorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta;
    }
}