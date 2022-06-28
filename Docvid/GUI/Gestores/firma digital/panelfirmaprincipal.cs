using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.firma_digital
{
    public partial class panelfirmaprincipal : Form
    {
        public panelfirmaprincipal()
        {
            InitializeComponent();
        }

        private void btnbuscarpdf_Click(object sender, EventArgs e)
        {
            abrirpdf();
        }

        private void abrirpdf()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PDF FILES |* .pdf", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(ofd.FileName);
                        StringBuilder sb = new StringBuilder();
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        }
                        txtescritura.Text = sb.ToString();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // firmar el documento
        private void button2_Click(object sender, EventArgs e)
        {
            guardando a = new guardando();
            a.txtescrituraolectura.Text = txtescritura.Text;
            a.ShowDialog();
        }
    }
}
