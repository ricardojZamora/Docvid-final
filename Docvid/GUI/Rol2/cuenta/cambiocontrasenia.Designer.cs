namespace Docvid.GUI.Rol2.cuenta
{
    partial class cambiocontrasenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cambiocontrasenia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcontraseniaactual = new System.Windows.Forms.TextBox();
            this.txtrepenuevacontra = new System.Windows.Forms.TextBox();
            this.txtnuevacontrasenia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña actual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(54, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repetir nueva contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(63, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nueva contraseña";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcontraseniaactual
            // 
            this.txtcontraseniaactual.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseniaactual.Location = new System.Drawing.Point(63, 53);
            this.txtcontraseniaactual.Name = "txtcontraseniaactual";
            this.txtcontraseniaactual.PasswordChar = '*';
            this.txtcontraseniaactual.Size = new System.Drawing.Size(210, 29);
            this.txtcontraseniaactual.TabIndex = 4;
            // 
            // txtrepenuevacontra
            // 
            this.txtrepenuevacontra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepenuevacontra.Location = new System.Drawing.Point(63, 205);
            this.txtrepenuevacontra.Name = "txtrepenuevacontra";
            this.txtrepenuevacontra.PasswordChar = '*';
            this.txtrepenuevacontra.Size = new System.Drawing.Size(210, 29);
            this.txtrepenuevacontra.TabIndex = 5;
            // 
            // txtnuevacontrasenia
            // 
            this.txtnuevacontrasenia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnuevacontrasenia.Location = new System.Drawing.Point(63, 135);
            this.txtnuevacontrasenia.Name = "txtnuevacontrasenia";
            this.txtnuevacontrasenia.PasswordChar = '*';
            this.txtnuevacontrasenia.Size = new System.Drawing.Size(210, 29);
            this.txtnuevacontrasenia.TabIndex = 6;
            // 
            // cambiocontrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(335, 310);
            this.Controls.Add(this.txtnuevacontrasenia);
            this.Controls.Add(this.txtrepenuevacontra);
            this.Controls.Add(this.txtcontraseniaactual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cambiocontrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cambiocontrasenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcontraseniaactual;
        private System.Windows.Forms.TextBox txtrepenuevacontra;
        private System.Windows.Forms.TextBox txtnuevacontrasenia;
    }
}