namespace Docvid.GUI.Documentacion.evidencia_dispositivo_movil
{
    partial class lista
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
            this.labelindicador = new System.Windows.Forms.Label();
            this.lblanuncio = new System.Windows.Forms.Label();
            this.chlbOpciones = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // labelindicador
            // 
            this.labelindicador.AutoSize = true;
            this.labelindicador.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelindicador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelindicador.Location = new System.Drawing.Point(154, 9);
            this.labelindicador.Name = "labelindicador";
            this.labelindicador.Size = new System.Drawing.Size(238, 19);
            this.labelindicador.TabIndex = 1;
            this.labelindicador.Text = "Pasos a realizar cumplidos (0 de 0)";
            // 
            // lblanuncio
            // 
            this.lblanuncio.AutoSize = true;
            this.lblanuncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanuncio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblanuncio.Location = new System.Drawing.Point(12, 259);
            this.lblanuncio.Name = "lblanuncio";
            this.lblanuncio.Size = new System.Drawing.Size(521, 20);
            this.lblanuncio.TabIndex = 2;
            this.lblanuncio.Text = "Doble click para ir a ese item, puede marcar los items cumplidos";
            // 
            // chlbOpciones
            // 
            this.chlbOpciones.BackColor = System.Drawing.Color.Silver;
            this.chlbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlbOpciones.FormattingEnabled = true;
            this.chlbOpciones.Location = new System.Drawing.Point(75, 42);
            this.chlbOpciones.Name = "chlbOpciones";
            this.chlbOpciones.Size = new System.Drawing.Size(415, 208);
            this.chlbOpciones.TabIndex = 3;
            this.chlbOpciones.SelectedIndexChanged += new System.EventHandler(this.chlbOpciones_SelectedIndexChanged_1);
            this.chlbOpciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chlbOpciones_MouseDoubleClick_1);
            // 
            // lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(572, 310);
            this.Controls.Add(this.chlbOpciones);
            this.Controls.Add(this.lblanuncio);
            this.Controls.Add(this.labelindicador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lista";
            this.Load += new System.EventHandler(this.lista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelindicador;
        private System.Windows.Forms.Label lblanuncio;
        public System.Windows.Forms.CheckedListBox chlbOpciones;
    }
}