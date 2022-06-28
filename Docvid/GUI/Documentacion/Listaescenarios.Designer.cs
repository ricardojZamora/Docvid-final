namespace Docvid.GUI.Documentacion
{
    partial class Listaescenarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listaescenarios));
            this.escenario1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // escenario1
            // 
            this.escenario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("escenario1.BackgroundImage")));
            this.escenario1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.escenario1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.escenario1.Location = new System.Drawing.Point(12, 12);
            this.escenario1.Name = "escenario1";
            this.escenario1.Size = new System.Drawing.Size(184, 138);
            this.escenario1.TabIndex = 0;
            this.escenario1.UseVisualStyleBackColor = true;
            this.escenario1.Click += new System.EventHandler(this.escenario1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evidencia dispositivo móvil";
            // 
            // Listaescenarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(662, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.escenario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Listaescenarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listaescenarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button escenario1;
        private System.Windows.Forms.Label label1;
    }
}