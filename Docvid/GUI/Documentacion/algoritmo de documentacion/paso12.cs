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
    public partial class paso12 : Form
    {
        public paso12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // operacion_terminada a = new operacion_terminada();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("No tiene medios de comunicacion adicionales");
            a.setpasosiguiente(14);
            a.panel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Tiene medio(s) de comunicacion adicional(es)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //operacion_terminada a = new operacion_terminada();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(14);
            a.panel.Visible = false;
        }
    }
}
