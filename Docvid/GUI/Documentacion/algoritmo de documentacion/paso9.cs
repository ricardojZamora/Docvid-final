using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Documentacion.algoritmo_de_documentacion
{
    public partial class paso9 : Form
    {
        public paso9()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //paso2volatil a = new paso2volatil();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Sistema empoderado");
            a.setpasosiguiente(2);
            a.panel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //operacion_terminada a = new operacion_terminada();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Sistema no empoderado");

            a.setpasosiguiente(14);
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
        }
    }

