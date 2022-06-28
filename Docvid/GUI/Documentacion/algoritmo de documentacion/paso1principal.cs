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
    public partial class paso1principal : Form
    {
        public paso1principal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //coleccion y encendido
            if(rdencendido.Checked == true)
            {
                //paso2volatil a = new paso2volatil();
                //a.ShowDialog();
                panelprincipalpasos a = new panelprincipalpasos();
                a.agregarpaso("Coleccion de datos");
                a.agregarpaso("Equipo encendido");
                a.setpasosiguiente(2);
                a.panel.Visible = false;
            }
            //coleccion y apagado
            else if (rdapagado.Checked == true)
            {
                //paso11 a = new paso11();
                //a.ShowDialog();
                panelprincipalpasos a = new panelprincipalpasos();
                a.setpasosiguiente(11);
                a.agregarpaso("Coleccion de datos");
                a.agregarpaso("Equipo apagado");
                a.panel.Visible = false;
            }
            else
            {
                MessageBox.Show("Seleccione si el dispositivo esta encendido o apagado");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //adquisicion y encendido
            if(rdencendido.Checked == true)
            {
              //  btnregresar a = new btnregresar(); // por defecro era este
                panelprincipalpasos a = new panelprincipalpasos();
               // a.panelpaso5();
                //a.condicionespanel();
                //// condiciones para el panel

                a.agregarpaso("Adquisicion de datos");
                a.agregarpaso("Equipo encendido");
                a.setpasosiguiente(5);
                a.timercambiopanel.Enabled = true;
            //    a.panel.Visible = false;
             //   a.timercambiopanel.Enabled = true;

                //this.Close();
               // a.timercambiopanel.Start();
                //a.timercambiopanel_Tick(sender,e);
                
                
               // a.AbrirFormulario<btnregresar>();

                // a.ShowDialog(); // por defecro era este
            }
            //adquisicion y apagado
            else if (rdapagado.Checked == true)
            {
                //// a la figura 5 pendiente
                //paso13 a = new paso13();
                //a.ShowDialog();
                panelprincipalpasos a = new panelprincipalpasos();
                a.agregarpaso("Adquisicion de datos");
                a.agregarpaso("Equipo apagado");
                a.setpasosiguiente(13);
              //  a.panel.Visible = false;
              //  a.timercambiopanel.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione si el dispositivo esta encendido o apagado");
            }
        }

        private void paso1principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //GUI.Documentacion.algoritmo_de_documentacion.panelprincipalpasos a = new panelprincipalpasos();
            //a.panelpaso5();

        }
    }
}
