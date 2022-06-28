using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Documentacion
{
    public partial class Listaescenarios : Form
    {
        public Listaescenarios()
        {
            InitializeComponent();
        }

        private void escenario1_Click(object sender, EventArgs e)
        {
            evidencia_dispositivo_movil.lista f  = new evidencia_dispositivo_movil.lista();
            f.ShowDialog();
        }
    }
}
