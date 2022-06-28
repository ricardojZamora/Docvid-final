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
    public partial class paso11 : Form
    {
        public paso11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Dispositivo tiene bateria");
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Dispositivo no tiene bateria");
            lbl5.Visible = true;
            lbl6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //paso12 a = new paso12();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(12);
            a.panel.Visible = false;
        }
    }
}
