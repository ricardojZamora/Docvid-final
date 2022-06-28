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
    public partial class operacion_terminada : Form
    {
        public operacion_terminada()
        {
            InitializeComponent();
        }

        private void operacion_terminada_Load(object sender, EventArgs e)
        {
            panelprincipalpasos a = new panelprincipalpasos();
            List<String> pasoshechos = a.getlista();
            String cadenaimprimir="";
            txtreporte.Text = "";
            a.agregarpaso("Termino pasos de un dispositivo");
            for (int i = 0; i < pasoshechos.Count; i++)
            {
                if(i >= 1)
                {
                    cadenaimprimir = cadenaimprimir + "\t\n" + pasoshechos[i];
                    //txtreporte.Text = txtreporte.Text + "\n"+  pasoshechos[i];
                    //txtreporte.Text = pasoshechos[i];
                }
                else
                {
                    cadenaimprimir = cadenaimprimir + pasoshechos[i];

                }
            } txtreporte.Text = cadenaimprimir;
         //   MessageBox.Show(pasoshechos.Count.ToString());
            //a.vercantidadenlalista();
        }
    }
}
