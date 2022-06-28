using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Docvid.GUI.Gestores.firma_digital.CLS;

namespace Docvid.GUI.Gestores.hash
{
    public partial class encriptar : Form
    {
        String llavepublica;
        String llaveprivada;
        public encriptar()
        {
            InitializeComponent();
        }

        private void encriptar_Load(object sender, EventArgs e)
        {
            darvalorallaves();
        }

        string hash = "f0xle@rn";

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //byte[] data = UTF8Encoding.UTF8.GetBytes(txtValue.Text);
            //using(MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider())
            //{
            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            //    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider()
            //    {Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7})
            //    {
            //        ICryptoTransform transform = tripleDES.CreateEncryptor();
            //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //        txtEncrypt.Text = Convert.ToBase64String(results, 0, results.Length);
            //    }
            //}
            encriptarconmisllaves();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //byte[] data = Convert.FromBase64String(txtEncrypt.Text);
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{
            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            //    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider()
            //    { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //    {
            //        ICryptoTransform transform = tripleDES.CreateDecryptor();
            //        try
            //        { // por si no tiene nada cifrado en la caja de texto
            //            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //            txtDecrypt.Text = UTF8Encoding.UTF8.GetString(results);

            //        }
            //        catch
            //        {
            //            MessageBox.Show("No tiene mensaje encriptado");
            //        }
            //    }
            //}
            descencriptarconmisllaves();
        }

        // seleccionando llaves
        private void button1_Click(object sender, EventArgs e)
        {
            seleccion_llaves a = new seleccion_llaves();
            a.ShowDialog();
            darvalorallaves();


        }

        private void darvalorallaves()
        {
           // DBManager.CLS
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;
            DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
            DataTable consulta = operacion.Consultar("select * from usuarios where idusuario = '"+sesion.OUsuario.Idusuario+"';");
            String llaveprivadaauxiliar, llavepublicaauxiliar;

            

            llaveprivadaauxiliar = consulta.Rows[0]["llaveprivada"].ToString();
            llavepublicaauxiliar = consulta.Rows[0]["llavepublica"].ToString();

            llaveprivada = llaveprivadaauxiliar.Replace(@"\","/");
            llavepublica = llavepublicaauxiliar.Replace(@"\", "/");

        }
        private void encriptarconmisllaves()
        {
            try
            {
                txtencriptar.Text = Cryptography.EncryptWithPublicKey(llavepublica, txtValue.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la desencriptacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void descencriptarconmisllaves()
        {
            try
            {
                txtdescencriptar.Text = Cryptography.DecryptWithPrivateKey(llaveprivada, txtencriptar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la desencripcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
