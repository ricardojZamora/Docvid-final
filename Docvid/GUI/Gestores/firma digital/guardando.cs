using Docvid.GUI.Gestores.firma_digital.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.firma_digital
{
    public partial class guardando : Form
    {
        public guardando()
        {
            InitializeComponent();
        }

        String llaveprivada, llavepublica;
        String mensajeyaencriptado;

        //abriendo donde guardar el archivo
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd1 = new FolderBrowserDialog();
                if (fd1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = fd1.SelectedPath;
                }
            }
            catch
            {
                MessageBox.Show("No se puede abrir el dialogo");
            }
        }



        //creando el archivo
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(textBox1.Text + "\\" + textBox2.Text))
                {
                   // string texttx1 = txtescrituraolectura.Text; 
                    encriptar();
                    string texttx1 = mensajeyaencriptado;
                    TextWriter tw = new StreamWriter(textBox1.Text + "\\" + textBox2.Text + ".txt", true);
                    tw.WriteLine(texttx1);
                    tw.Close();
                    MessageBox.Show("Firma realizada!");
                }
                else
                {
                    MessageBox.Show("File Exists Already", "Error creating file");
                }
            }
            catch
            {
                MessageBox.Show("Error creating file. Cannot Access Location");
            }
            
        }


        string hash = "f0xle@rn";

        // procesos de encriptacion
        private void encriptar()
        {
            //byte[] data = UTF8Encoding.UTF8.GetBytes(txtescrituraolectura.Text); 
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{
            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            //    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //    {
            //        ICryptoTransform transform = tripleDES.CreateEncryptor();
            //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //        // este es el string con el mensaje ya encriptado
            //        mensajeyaencriptado = Convert.ToBase64String(results, 0, results.Length);
            //    }
            //}
            try{
               // mensajeyaencriptado = Cryptography.EncryptWithPublicKey(txtllavepublica.Text, txtescrituraolectura.Text);
                mensajeyaencriptado = Cryptography.EncryptWithPublicKey(llavepublica, txtescrituraolectura.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la desencriptacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscandollavepublica()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM files(*.PEM) | *.PEM";
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtllavepublica.Text = openFileDialog.FileName;
            }

        }
        private void buscandollaveprivada()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM files(*.PEM) | *.PEM";
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtllaveprivada.Text = openFileDialog.FileName;
            }

        }
        private void btnencriptar_Click(object sender, EventArgs e)
        {
            try
            {
               // mensajeyaencriptado = Cryptography.EncryptWithPublicKey(txtllavepublica.Text, txtescrituraolectura.Text);
                mensajeyaencriptado = Cryptography.EncryptWithPublicKey(llavepublica, txtescrituraolectura.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la desencriptacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnbuscarllavepublica_Click(object sender, EventArgs e)
        {
            buscandollavepublica();
        }

        private void btnbuscarllaveprivada_Click(object sender, EventArgs e)
        {
            buscandollaveprivada();
        }

        private void darvalorallaves()
        {
            // DBManager.CLS
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;
            DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
            DataTable consulta = operacion.Consultar("select * from usuarios where idusuario = '" + sesion.OUsuario.Idusuario + "';");
            String llaveprivadaauxiliar, llavepublicaauxiliar;



            llaveprivadaauxiliar = consulta.Rows[0]["llaveprivada"].ToString();
            llavepublicaauxiliar = consulta.Rows[0]["llavepublica"].ToString();

            llaveprivada = llaveprivadaauxiliar.Replace(@"\", "/");
            llavepublica = llavepublicaauxiliar.Replace(@"\", "/");

        }

        private void guardando_Load(object sender, EventArgs e)
        {
            darvalorallaves();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncambiarllaves_Click(object sender, EventArgs e)
        {
            GUI.Gestores.hash.seleccion_llaves a = new hash.seleccion_llaves();
            a.ShowDialog();
            darvalorallaves();
        }
    }
}
