namespace Docvid.GUI.Gestores.Documentos
{
    partial class selecciontipo
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
            this.dtgvdatos = new System.Windows.Forms.DataGridView();
            this.idtipoevidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvdatos
            // 
            this.dtgvdatos.AllowUserToAddRows = false;
            this.dtgvdatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dtgvdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvdatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dtgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtipoevidencia,
            this.tipo,
            this.caracteristica,
            this.formato,
            this.extension});
            this.dtgvdatos.Location = new System.Drawing.Point(0, 23);
            this.dtgvdatos.Name = "dtgvdatos";
            this.dtgvdatos.ReadOnly = true;
            this.dtgvdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvdatos.Size = new System.Drawing.Size(683, 407);
            this.dtgvdatos.TabIndex = 21;
            this.dtgvdatos.DoubleClick += new System.EventHandler(this.dtgvdatos_DoubleClick);
            // 
            // idtipoevidencia
            // 
            this.idtipoevidencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idtipoevidencia.DataPropertyName = "idtipoevidencia";
            this.idtipoevidencia.HeaderText = "ID tipo";
            this.idtipoevidencia.Name = "idtipoevidencia";
            this.idtipoevidencia.ReadOnly = true;
            this.idtipoevidencia.Visible = false;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // caracteristica
            // 
            this.caracteristica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.caracteristica.DataPropertyName = "caracteristica";
            this.caracteristica.HeaderText = "Caracteristica";
            this.caracteristica.Name = "caracteristica";
            this.caracteristica.ReadOnly = true;
            // 
            // formato
            // 
            this.formato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formato.DataPropertyName = "formato";
            this.formato.HeaderText = "Formato";
            this.formato.Name = "formato";
            this.formato.ReadOnly = true;
            // 
            // extension
            // 
            this.extension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.extension.DataPropertyName = "extension";
            this.extension.HeaderText = "Extension";
            this.extension.Name = "extension";
            this.extension.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filtrar";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.Location = new System.Drawing.Point(202, 442);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(282, 22);
            this.txtfiltro.TabIndex = 23;
            // 
            // selecciontipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(683, 474);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvdatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selecciontipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "selecciontipo";
            this.Load += new System.EventHandler(this.selecciontipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgvdatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoevidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn caracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn extension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiltro;
    }
}