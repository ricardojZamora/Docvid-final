namespace Docvid.GUI.Gestores.firma_digital
{
    partial class guardando
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncrear = new System.Windows.Forms.Button();
            this.txtescrituraolectura = new System.Windows.Forms.RichTextBox();
            this.txtllaveprivada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtllavepublica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbuscarllavepublica = new System.Windows.Forms.Button();
            this.btnbuscarllaveprivada = new System.Windows.Forms.Button();
            this.btncambiarllaves = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 272);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(513, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Direccion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncrear.FlatAppearance.BorderSize = 0;
            this.btncrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrear.ForeColor = System.Drawing.Color.White;
            this.btncrear.Location = new System.Drawing.Point(718, 272);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 42);
            this.btncrear.TabIndex = 8;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtescrituraolectura
            // 
            this.txtescrituraolectura.Location = new System.Drawing.Point(14, 11);
            this.txtescrituraolectura.Name = "txtescrituraolectura";
            this.txtescrituraolectura.ReadOnly = true;
            this.txtescrituraolectura.Size = new System.Drawing.Size(776, 248);
            this.txtescrituraolectura.TabIndex = 7;
            this.txtescrituraolectura.Text = "";
            // 
            // txtllaveprivada
            // 
            this.txtllaveprivada.Location = new System.Drawing.Point(87, 246);
            this.txtllaveprivada.Name = "txtllaveprivada";
            this.txtllaveprivada.Size = new System.Drawing.Size(513, 20);
            this.txtllaveprivada.TabIndex = 15;
            this.txtllaveprivada.Visible = false;
            this.txtllaveprivada.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Llave privada";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtllavepublica
            // 
            this.txtllavepublica.Location = new System.Drawing.Point(87, 220);
            this.txtllavepublica.Name = "txtllavepublica";
            this.txtllavepublica.Size = new System.Drawing.Size(513, 20);
            this.txtllavepublica.TabIndex = 17;
            this.txtllavepublica.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Llave publica";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnbuscarllavepublica
            // 
            this.btnbuscarllavepublica.Location = new System.Drawing.Point(606, 218);
            this.btnbuscarllavepublica.Name = "btnbuscarllavepublica";
            this.btnbuscarllavepublica.Size = new System.Drawing.Size(25, 23);
            this.btnbuscarllavepublica.TabIndex = 18;
            this.btnbuscarllavepublica.Text = "...";
            this.btnbuscarllavepublica.UseVisualStyleBackColor = true;
            this.btnbuscarllavepublica.Visible = false;
            this.btnbuscarllavepublica.Click += new System.EventHandler(this.btnbuscarllavepublica_Click);
            // 
            // btnbuscarllaveprivada
            // 
            this.btnbuscarllaveprivada.Location = new System.Drawing.Point(606, 246);
            this.btnbuscarllaveprivada.Name = "btnbuscarllaveprivada";
            this.btnbuscarllaveprivada.Size = new System.Drawing.Size(25, 23);
            this.btnbuscarllaveprivada.TabIndex = 19;
            this.btnbuscarllaveprivada.Text = "...";
            this.btnbuscarllaveprivada.UseVisualStyleBackColor = true;
            this.btnbuscarllaveprivada.Visible = false;
            this.btnbuscarllaveprivada.Click += new System.EventHandler(this.btnbuscarllaveprivada_Click);
            // 
            // btncambiarllaves
            // 
            this.btncambiarllaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncambiarllaves.FlatAppearance.BorderSize = 0;
            this.btncambiarllaves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncambiarllaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncambiarllaves.ForeColor = System.Drawing.Color.White;
            this.btncambiarllaves.Location = new System.Drawing.Point(637, 272);
            this.btncambiarllaves.Name = "btncambiarllaves";
            this.btncambiarllaves.Size = new System.Drawing.Size(75, 42);
            this.btncambiarllaves.TabIndex = 20;
            this.btncambiarllaves.Text = "Cambiar llaves";
            this.btncambiarllaves.UseVisualStyleBackColor = false;
            this.btncambiarllaves.Click += new System.EventHandler(this.btncambiarllaves_Click);
            // 
            // guardando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.btncambiarllaves);
            this.Controls.Add(this.btnbuscarllaveprivada);
            this.Controls.Add(this.btnbuscarllavepublica);
            this.Controls.Add(this.txtllavepublica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtllaveprivada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtescrituraolectura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "guardando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmando";
            this.Load += new System.EventHandler(this.guardando_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncrear;
        public System.Windows.Forms.RichTextBox txtescrituraolectura;
        private System.Windows.Forms.TextBox txtllaveprivada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtllavepublica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnbuscarllavepublica;
        private System.Windows.Forms.Button btnbuscarllaveprivada;
        private System.Windows.Forms.Button btncambiarllaves;
    }
}