namespace Docvid.GUI.Gestores.proyectoscompartidos
{
    partial class gestorproyectoscompartidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestorproyectoscompartidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblestado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtfiltro = new System.Windows.Forms.ToolStripTextBox();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dtgvdatos = new System.Windows.Forms.DataGridView();
            this.idproyectocompartido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario_propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReporte = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblestado
            // 
            this.lblestado.BackColor = System.Drawing.Color.White;
            this.lblestado.Name = "lblestado";
            resources.ApplyResources(this.lblestado, "lblestado");
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // txtfiltro
            // 
            this.txtfiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtfiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltro.Name = "txtfiltro";
            resources.ApplyResources(this.txtfiltro, "txtfiltro");
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Docvid.Properties.Resources._3;
            resources.ApplyResources(this.btneliminar, "btneliminar");
            this.btneliminar.Name = "btneliminar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = global::Docvid.Properties.Resources._2;
            resources.ApplyResources(this.btnmodificar, "btnmodificar");
            this.btnmodificar.Name = "btnmodificar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblestado});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // dtgvdatos
            // 
            this.dtgvdatos.AllowUserToAddRows = false;
            this.dtgvdatos.AllowUserToDeleteRows = false;
            this.dtgvdatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproyectocompartido,
            this.idproyecto,
            this.titulo,
            this.nombre,
            this.nombre_usuario_propietario,
            this.descripcion});
            this.dtgvdatos.EnableHeadersVisualStyles = false;
            this.dtgvdatos.GridColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.dtgvdatos, "dtgvdatos");
            this.dtgvdatos.Name = "dtgvdatos";
            this.dtgvdatos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvdatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdatos_CellContentClick);
            this.dtgvdatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdatos_CellDoubleClick);
            // 
            // idproyectocompartido
            // 
            this.idproyectocompartido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idproyectocompartido.DataPropertyName = "idproyectocompartido";
            resources.ApplyResources(this.idproyectocompartido, "idproyectocompartido");
            this.idproyectocompartido.Name = "idproyectocompartido";
            this.idproyectocompartido.ReadOnly = true;
            // 
            // idproyecto
            // 
            this.idproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idproyecto.DataPropertyName = "idproyecto";
            resources.ApplyResources(this.idproyecto, "idproyecto");
            this.idproyecto.Name = "idproyecto";
            this.idproyecto.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.titulo.DataPropertyName = "titulo";
            resources.ApplyResources(this.titulo, "titulo");
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombre.DataPropertyName = "nombre";
            resources.ApplyResources(this.nombre, "nombre");
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // nombre_usuario_propietario
            // 
            this.nombre_usuario_propietario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombre_usuario_propietario.DataPropertyName = "nombre_usuario_propietario";
            resources.ApplyResources(this.nombre_usuario_propietario, "nombre_usuario_propietario");
            this.nombre_usuario_propietario.Name = "nombre_usuario_propietario";
            this.nombre_usuario_propietario.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descripcion.DataPropertyName = "descripcion";
            resources.ApplyResources(this.descripcion, "descripcion");
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnmodificar,
            this.toolStripSeparator2,
            this.btneliminar,
            this.txtfiltro,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btnReporte});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // btnReporte
            // 
            this.btnReporte.Image = global::Docvid.Properties.Resources.icons8_informe_de_estadísticas_50;
            resources.ApplyResources(this.btnReporte, "btnReporte");
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // gestorproyectoscompartidos
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgvdatos);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestorproyectoscompartidos";
            this.Load += new System.EventHandler(this.gestorproyectoscompartidos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel lblestado;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtfiltro;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dtgvdatos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyectocompartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario_propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnReporte;
    }
}