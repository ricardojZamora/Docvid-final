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
    public partial class paso8 : Form
    {
        public paso8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //paso9 a = new paso9();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(9);
            a.agregarpaso("Es volatil los datos que se requieren del dispositivo");

            a.panel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //paso10 a = new paso10();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(10);
            a.agregarpaso("Es no volatil los datos que se requieren del dispositivo");

            a.panel.Visible = false;
        }

        private void paso8_Load(object sender, EventArgs e)
        {

        }
    }
}
