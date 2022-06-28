namespace Docvid.GUI.Documentacion.algoritmo_de_documentacion
{
    partial class btnregresar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnregresar));
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.no2 = new System.Windows.Forms.Button();
            this.si2 = new System.Windows.Forms.Button();
            this.btnpreguntaanterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(108, 59);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(367, 19);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Los datos requeridos del dispositivo son datos en vivo";
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(142, 125);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 33);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Si";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(347, 125);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 33);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "No";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(154, 243);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(258, 19);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Puede que el sistema sea apoderado?";
            this.lbl2.Visible = false;
            // 
            // no2
            // 
            this.no2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no2.Location = new System.Drawing.Point(257, 319);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(75, 31);
            this.no2.TabIndex = 5;
            this.no2.Text = "No";
            this.no2.UseVisualStyleBackColor = true;
            this.no2.Visible = false;
            this.no2.Click += new System.EventHandler(this.button3_Click);
            // 
            // si2
            // 
            this.si2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.si2.Location = new System.Drawing.Point(61, 319);
            this.si2.Name = "si2";
            this.si2.Size = new System.Drawing.Size(75, 31);
            this.si2.TabIndex = 4;
            this.si2.Text = "Si";
            this.si2.UseVisualStyleBackColor = true;
            this.si2.Visible = false;
            this.si2.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnpreguntaanterior
            // 
            this.btnpreguntaanterior.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpreguntaanterior.Location = new System.Drawing.Point(453, 299);
            this.btnpreguntaanterior.Name = "btnpreguntaanterior";
            this.btnpreguntaanterior.Size = new System.Drawing.Size(86, 71);
            this.btnpreguntaanterior.TabIndex = 6;
            this.btnpreguntaanterior.Text = "Regresar a la pregunta anterior";
            this.btnpreguntaanterior.UseVisualStyleBackColor = true;
            this.btnpreguntaanterior.Visible = false;
            this.btnpreguntaanterior.Click += new System.EventHandler(this.btnpreguntaanterior_Click);
            // 
            // btnregresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(603, 430);
            this.Controls.Add(this.btnpreguntaanterior);
            this.Controls.Add(this.no2);
            this.Controls.Add(this.si2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl1);
            this.Name = "btnregresar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paso5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.paso5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button no2;
        private System.Windows.Forms.Button si2;
        private System.Windows.Forms.Button btnpreguntaanterior;
    }
}