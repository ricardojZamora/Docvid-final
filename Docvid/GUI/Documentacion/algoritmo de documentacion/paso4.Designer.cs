namespace Docvid.GUI.Documentacion.algoritmo_de_documentacion
{
    partial class paso4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paso4));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnsi = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(92, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etiquete, desconecte y asegure los cables y puertos del dispositivo; coloque sint" +
    "a adhesiva en el boton de encendido del dispositivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "lo tengo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(92, 206);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(397, 32);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Hay otro medio de comunicacion involucrado?";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl2.Visible = false;
            // 
            // btnsi
            // 
            this.btnsi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsi.Location = new System.Drawing.Point(38, 255);
            this.btnsi.Name = "btnsi";
            this.btnsi.Size = new System.Drawing.Size(142, 28);
            this.btnsi.TabIndex = 3;
            this.btnsi.Text = "si";
            this.btnsi.UseVisualStyleBackColor = true;
            this.btnsi.Visible = false;
            this.btnsi.Click += new System.EventHandler(this.btnsi_Click);
            // 
            // btnno
            // 
            this.btnno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnno.Location = new System.Drawing.Point(387, 255);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(142, 28);
            this.btnno.TabIndex = 4;
            this.btnno.Text = "no";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Visible = false;
            this.btnno.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl3.Location = new System.Drawing.Point(115, 325);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(374, 73);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Debe manejar los medios de acuerdo a las pautas especificas ";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl3.Visible = false;
            // 
            // paso4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(603, 430);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnsi);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "paso4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paso4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnsi;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Label lbl3;
    }
}