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
    public partial class btnregresar : Form
    {
        public btnregresar()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //paso3 a = new paso3();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(3);
            a.agregarpaso("Sistema empoderado");
            a.panel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //operacion_terminada a = new operacion_terminada();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(14);
            a.agregarpaso("Sistema no empoderado");
            a.panel.Visible = false;
        }

        private void paso5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            visiblepregunta2();
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Datos requeridos no son en vivo");
        }

        void visiblepregunta2()
        {
            //haciendo visible la decision siguiente
            lbl2.Visible = true;
            si2.Visible = true;
            no2.Visible = true;
            btnpreguntaanterior.Visible = true;

            //haciendo invisible la decision actual
            lbl1.Visible = false;
            btn1.Visible = false;
            btn2.Visible = false;
        }
        void regresarpregunta1()
        {
            //haciendo visible la decision siguiente
            lbl2.Visible = false;
            si2.Visible = false;
            no2.Visible = false;
            btnpreguntaanterior.Visible = false;

            //haciendo invisible la decision actual
            lbl1.Visible = true;
            btn1.Visible = true;
            btn2.Visible = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //paso6 a = new paso6();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Datos requeridos son en vivo");
            int nmero = 6;
            a.setpasosiguiente(nmero);
          //  a.panel.Visible = false;
        }

        private void btnpreguntaanterior_Click(object sender, EventArgs e)
        {
            regresarpregunta1();
        }
    }
}
