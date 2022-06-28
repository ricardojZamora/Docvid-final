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
    public partial class paso2volatil : Form
    {
        
        public paso2volatil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //paso3 a = new paso3();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(3);
            a.agregarpaso("Equipo sin datos volatiles");
            a.panel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  paso a = new paso5();
           // a.showdialog();
            //btnregresar a = new btnregresar();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
          
            a.agregarpaso("Equipo con datos volatiles");
            a.setpasosiguiente(5);
            a.panel.Visible = false;
        }
    }
}
