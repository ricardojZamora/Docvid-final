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
    public partial class paso4 : Form
    {
        public paso4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //operacion_terminada a = new operacion_terminada();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("No hay otro medio de comunicación integrado");
            a.setpasosiguiente(14);
            a.panel.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            lbl2.Visible = true;
           // lbl3.Visible = true;
            btnsi.Visible = true;
            btnno.Visible = true;
        }

        private void btnsi_Click(object sender, EventArgs e)
        {
            lbl3.Visible = true;
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Hay otro medio de comunicación integrado");
        }
    }
}
