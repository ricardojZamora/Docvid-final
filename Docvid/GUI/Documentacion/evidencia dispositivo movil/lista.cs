using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Documentacion.evidencia_dispositivo_movil
{


    public partial class lista : Form
    {

        public static String itemsseleccionado;
        int cantidaddeitems;
        int cantidadseleccionado;

        //actualizamos los pasos que hemos o vamos a cumplir
        void actualizarlabelindicador()
        {
            cantidadseleccionado = chlbOpciones.CheckedItems.Count;
            labelindicador.Text = "Pasos a realizar (cumplidos " + cantidadseleccionado + " de "+ cantidaddeitems+")";
        }

        // encapsulamiento de la variable global
        public String getitemsseleccionado()
        {
            return itemsseleccionado;
        }

        public void setitemsseleccionado( String a)
        {
            itemsseleccionado = a;
        }

        private void actualizaritemscumplidos()
        {
            
        }


        //fin del encapsulamiento de la varianle global

        // aqui llenamos la lista de items
        void itemsaccionescargar()
        {
            chlbOpciones.Items.Add("Web Cam");
            chlbOpciones.Items.Add("Hacer/implementar");
            chlbOpciones.Items.Add("Verificar");
            chlbOpciones.Items.Add("Actuar");
            cantidaddeitems = chlbOpciones.Items.Count;
            actualizarlabelindicador();
        }

      

        public lista()
        {
            InitializeComponent();
        }

        //cuando se selecciona un items
        private void chlbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
              //  chlbOpciones.SelectedValue.Equals(false);
        }

       
        //cuando la ventana inicia
        private void lista_Load(object sender, EventArgs e)
        {
            itemsaccionescargar();
        }

        private void lblpaso1_Click(object sender, EventArgs e)
        {
            webcam.webcam a = new webcam.webcam();
            a.ShowDialog();
        }

        private void chlbOpciones_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int indice = chlbOpciones.SelectedIndex;
            actualizarlabelindicador();
            if (indice != -1)
            {
                setitemsseleccionado(chlbOpciones.Items[indice].ToString());
                if (itemsseleccionado == "Web Cam")
                {
                    webcam.webcam a = new webcam.webcam();
                    a.ShowDialog();
                }

            }
        }

        private void chlbOpciones_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            actualizarlabelindicador();
        } //fin del doble click
    }
}
