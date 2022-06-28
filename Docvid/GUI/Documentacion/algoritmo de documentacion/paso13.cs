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
    public partial class paso13 : Form
    {
        public paso13()
        {
            InitializeComponent();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            //operacion_terminada a = new operacion_terminada();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(14);
            a.panel.Visible = false;
        }
    }
}
