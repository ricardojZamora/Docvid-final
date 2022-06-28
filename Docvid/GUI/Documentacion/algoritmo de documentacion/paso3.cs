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
    public partial class paso3 : Form
    {
        public paso3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //paso4 a = new paso4();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(4);
            a.panel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelprincipalpasos a = new panelprincipalpasos();

            a.agregarpaso("Los datos del equipo son estables");
            lbl1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("No o no se sabe si los datos son estables");
            lbl2.Visible = true;
        }
    }
}
