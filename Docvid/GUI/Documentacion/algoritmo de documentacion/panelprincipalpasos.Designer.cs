namespace Docvid.GUI.Documentacion.algoritmo_de_documentacion
{
    partial class panelprincipalpasos
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
            this.panel = new System.Windows.Forms.Panel();
            this.txtnombreescenario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnterminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnotas = new System.Windows.Forms.TextBox();
            this.timercambiopanel = new System.Windows.Forms.Timer(this.components);
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.txtidescenario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnpasoanterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(168, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(619, 469);
            this.panel.TabIndex = 0;
            this.panel.VisibleChanged += new System.EventHandler(this.panel_VisibleChanged);
            this.panel.Click += new System.EventHandler(this.panel_Click);
            this.panel.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // txtnombreescenario
            // 
            this.txtnombreescenario.Location = new System.Drawing.Point(22, 155);
            this.txtnombreescenario.Name = "txtnombreescenario";
            this.txtnombreescenario.Size = new System.Drawing.Size(100, 20);
            this.txtnombreescenario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del escenario";
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnaceptar.FlatAppearance.BorderSize = 0;
            this.btnaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Location = new System.Drawing.Point(25, 347);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 3;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnterminar
            // 
            this.btnterminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnterminar.FlatAppearance.BorderSize = 0;
            this.btnterminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnterminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnterminar.ForeColor = System.Drawing.Color.White;
            this.btnterminar.Location = new System.Drawing.Point(25, 376);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(75, 23);
            this.btnterminar.TabIndex = 4;
            this.btnterminar.Text = "Terminar";
            this.btnterminar.UseVisualStyleBackColor = false;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(25, 405);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Notas";
            // 
            // txtnotas
            // 
            this.txtnotas.Location = new System.Drawing.Point(22, 214);
            this.txtnotas.Multiline = true;
            this.txtnotas.Name = "txtnotas";
            this.txtnotas.Size = new System.Drawing.Size(107, 115);
            this.txtnotas.TabIndex = 7;
            // 
            // timercambiopanel
            // 
            this.timercambiopanel.Interval = 1000;
            this.timercambiopanel.Tick += new System.EventHandler(this.timercambiopanel_Tick);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnsiguiente.FlatAppearance.BorderSize = 0;
            this.btnsiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.ForeColor = System.Drawing.Color.White;
            this.btnsiguiente.Location = new System.Drawing.Point(793, 228);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(75, 38);
            this.btnsiguiente.TabIndex = 8;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // txtidescenario
            // 
            this.txtidescenario.Location = new System.Drawing.Point(22, 105);
            this.txtidescenario.Name = "txtidescenario";
            this.txtidescenario.ReadOnly = true;
            this.txtidescenario.Size = new System.Drawing.Size(100, 20);
            this.txtidescenario.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Id proyecto";
            // 
            // btnpasoanterior
            // 
            this.btnpasoanterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnpasoanterior.FlatAppearance.BorderSize = 0;
            this.btnpasoanterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnpasoanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpasoanterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpasoanterior.ForeColor = System.Drawing.Color.White;
            this.btnpasoanterior.Location = new System.Drawing.Point(793, 291);
            this.btnpasoanterior.Name = "btnpasoanterior";
            this.btnpasoanterior.Size = new System.Drawing.Size(75, 38);
            this.btnpasoanterior.TabIndex = 11;
            this.btnpasoanterior.Text = "Anterior";
            this.btnpasoanterior.UseVisualStyleBackColor = false;
            this.btnpasoanterior.Click += new System.EventHandler(this.btnpasoanterior_Click);
            // 
            // panelprincipalpasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(880, 566);
            this.Controls.Add(this.btnpasoanterior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidescenario);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.txtnotas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombreescenario);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelprincipalpasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escenario para proyecto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.panelprincipalpasos_Load);
            this.DoubleClick += new System.EventHandler(this.panelprincipalpasos_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnterminar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.TextBox txtnombreescenario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnotas;
        public System.Windows.Forms.Timer timercambiopanel;
        private System.Windows.Forms.Button btnsiguiente;
        public System.Windows.Forms.TextBox txtidescenario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnpasoanterior;
    }
}