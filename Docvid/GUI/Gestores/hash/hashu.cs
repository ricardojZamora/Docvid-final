using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Docvid.GUI.Gestores.hash
{
    public partial class hashu : Form
    {
        public hashu()
        {
            InitializeComponent();
        }

        private void hashu_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string fPath = e.Argument.ToString();
            byte[] buffer;
            int bytesRead;
            long size;
            long totalBytesRead = 0;
            using (Stream file = File.OpenRead(fPath))
            {
                size = file.Length;
                using (HashAlgorithm hasher = MD5.Create())
                {
                    do
                    {
                        buffer = new byte[4096];
                        bytesRead = file.Read(buffer, 0, buffer.Length);
                        totalBytesRead += bytesRead;
                        hasher.TransformBlock(buffer, 0, bytesRead, null, 0);
                        backgroundWorker1.ReportProgress((int)((double)totalBytesRead / size * 100));
                    }
                    while (bytesRead != 0);

                    hasher.TransformFinalBlock(buffer, 0, 0);
                    e.Result = MakeHashString(hasher.Hash);
                }
            }
        }

        private static string MakeHashString(byte[] hashBytes)
        {
            StringBuilder hash = new StringBuilder(32);
            foreach (byte b in hashBytes)
            {
                hash.Append(b.ToString("X2").ToLower());
            }
            return hash.ToString();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           // MessageBox.Show(e.Result.ToString());
            txthashextraido.Text = e.Result.ToString();
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            backgroundWorker1.RunWorkerAsync(textBox1.Text);
        }
    }
}
