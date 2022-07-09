namespace Docvid.GUI.Documentacion.algoritmo_de_documentacion
{
    partial class Paso_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcarpeta = new System.Windows.Forms.TextBox();
            this.btnagregarcarpeta = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnguardarcarpeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realize la adquisicion de datos volatiles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(113, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 71);
            this.label2.TabIndex = 1;
            this.label2.Text = "Es no volatil lo que se requiere del dispositivo?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(37, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Si";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(466, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtcarpeta
            // 
            this.txtcarpeta.Location = new System.Drawing.Point(20, 89);
            this.txtcarpeta.Multiline = true;
            this.txtcarpeta.Name = "txtcarpeta";
            this.txtcarpeta.Size = new System.Drawing.Size(309, 20);
            this.txtcarpeta.TabIndex = 4;
            this.txtcarpeta.TextChanged += new System.EventHandler(this.txtcarpeta_TextChanged);
            // 
            // btnagregarcarpeta
            // 
            this.btnagregarcarpeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnagregarcarpeta.FlatAppearance.BorderSize = 0;
            this.btnagregarcarpeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnagregarcarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarcarpeta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarcarpeta.ForeColor = System.Drawing.Color.White;
            this.btnagregarcarpeta.Location = new System.Drawing.Point(371, 81);
            this.btnagregarcarpeta.Name = "btnagregarcarpeta";
            this.btnagregarcarpeta.Size = new System.Drawing.Size(160, 33);
            this.btnagregarcarpeta.TabIndex = 5;
            this.btnagregarcarpeta.Text = "Agregar carpeta";
            this.btnagregarcarpeta.UseVisualStyleBackColor = false;
            this.btnagregarcarpeta.Click += new System.EventHandler(this.btnagregarcarpeta_Click);
            // 
            // btnguardarcarpeta
            // 
            this.btnguardarcarpeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnguardarcarpeta.FlatAppearance.BorderSize = 0;
            this.btnguardarcarpeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnguardarcarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcarpeta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarcarpeta.ForeColor = System.Drawing.Color.White;
            this.btnguardarcarpeta.Location = new System.Drawing.Point(20, 131);
            this.btnguardarcarpeta.Name = "btnguardarcarpeta";
            this.btnguardarcarpeta.Size = new System.Drawing.Size(160, 33);
            this.btnguardarcarpeta.TabIndex = 6;
            this.btnguardarcarpeta.Text = "Guardar carpeta";
            this.btnguardarcarpeta.UseVisualStyleBackColor = false;
            this.btnguardarcarpeta.Visible = false;
            this.btnguardarcarpeta.Click += new System.EventHandler(this.btnguardarcarpeta_Click);
            // 
            // Paso_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(603, 430);
            this.ControlBox = false;
            this.Controls.Add(this.btnguardarcarpeta);
            this.Controls.Add(this.btnagregarcarpeta);
            this.Controls.Add(this.txtcarpeta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Paso_7";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paso_7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtcarpeta;
        private System.Windows.Forms.Button btnagregarcarpeta;
        public System.Windows.Forms.FolderBrowserDialog fbd;
        public System.Windows.Forms.Button btnguardarcarpeta;
    }
}