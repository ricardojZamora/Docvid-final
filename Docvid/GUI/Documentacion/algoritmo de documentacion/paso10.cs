using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Documentacion.algoritmo_de_documentacion
{
    public partial class paso10 : Form
    {
        public paso10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //paso9 a = new paso9();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(9);
            a.panel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //paso10 a = new paso10();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(10);
            a.panel.Visible = false;
        }

        private void btnagregarcarpeta_Click(object sender, EventArgs e)
        {
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Se agregaron datos no volatiles");
            String auxiliarruta;
            var resultado = fbd.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //extraemos la direccion del archivo
                txtcarpeta.Text = fbd.SelectedPath;
                String auxiliar1 = fbd.SelectedPath;

                //conversion de \ a /
                auxiliar1 = auxiliar1.Replace(@"\", "/");

                // algoritmo de reemplazo de \ a /
                String auxiliar = txtcarpeta.Text.Replace(@"\", "/");

                txtcarpeta.Text = auxiliar1;
                auxiliarruta = auxiliar1;
                txtcarpeta.Text = auxiliar;

                // txtruta.Text = fbd.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // filName;
            string filName;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png*)|*.png*|PDF (*.pdf)|*.pdf|DOC (*.doc)|*.doc|XLS (*.xls)|*.xls|DOCX (*.docx)|*.docx|TXT (*.txt)|*.txt";
            //Restaurar la ventana despues del open fileDialog
            ofd.RestoreDirectory = true;
            ofd.Title = "Selecciona Comprobante";
            //if (ofd.ShowDialog() == DialogResult.OK)
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // filName = ofd.FileName;

                filName = openFileDialog1.FileName;


                String auxiliar1 = openFileDialog1.FileName;
                String auxiliarruta;
                //conversion de \ a /
                auxiliar1 = auxiliar1.Replace(@"\", "/");

                // algoritmo de reemplazo de \ a /
                String auxiliar = txtarchivo.Text.Replace(@"\", "/");

                txtarchivo.Text = auxiliar1;
                auxiliarruta = auxiliar1;
                txtarchivo.Text = auxiliar;
                // txtruta.Text = auxiliar;
                //if (guardar)
                //{
                //Copia del archivo
                string destino = Path.Combine(Application.StartupPath, String.Format(@"C:\Users\Kevin\Documents\Docvid\{0}", Path.GetFileName(ofd.FileName)));


                String extension = Path.GetExtension(auxiliar1);
                extension = Regex.Replace(extension, "[@,\\.\";'\\\\]", string.Empty);
                
            }
        }

        private void btnguardararchivos_Click(object sender, EventArgs e)
        {
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;
            General.CLS.evidencias oEmpleado = new General.CLS.evidencias();
            panelprincipalpasos a = new panelprincipalpasos();
            oEmpleado.Idproyecto = a.getidproyecto();
            oEmpleado.Idtipoevidencia = "1";
            oEmpleado.Idusuario = sesion.OUsuario.Idusuario;
            oEmpleado.Hash = "No verificado";
            oEmpleado.Ruta = txtcarpeta.Text;
            oEmpleado.Nota = "";
            if (oEmpleado.Guardar())
            {
                MessageBox.Show("Registro guardado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El registro no pudo ser guardado", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcarpeta_TextChanged(object sender, EventArgs e)
        {
            if(txtcarpeta.Text!= null)
            {
                btnguardararchivos.Visible = true;
            }
            else
            {
                btnguardararchivos.Visible = false;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtarchivo.Text != null) 
            {
                btnguardararchivos.Visible = true;
            }
            else
            {
                btnguardararchivos.Visible = false;

            }
        }
    }
}
