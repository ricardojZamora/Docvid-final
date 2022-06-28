using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Documentacion.webcam
{
    public partial class webcam : Form
    {

        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice Miwebcam = null;


        public webcam()
        {
            InitializeComponent();
        }

        public void cerrarwebcam()
        {
            if (Miwebcam != null && Miwebcam.IsRunning)
            {
                Miwebcam.SignalToStop();
                Miwebcam = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // aqui se intantara abrir la camara sin ningun error de crasheo para el programa
            try
            {
                cerrarwebcam();
                int i = comboBox1.SelectedIndex;
                string nombrevideo = MisDispositivos[i].MonikerString;
                Miwebcam = new VideoCaptureDevice(nombrevideo);
                Miwebcam.NewFrame += new NewFrameEventHandler(capturando);
                label1guia.Text = "";
                Miwebcam.Start();
            }
                // si el programa da error, el programa cerrara la camara y dara el mensaje
            catch
            {
                cerrarwebcam();
                MessageBox.Show("Error al seleccionar esta camara, puede que la camara no este disponible o este defectuosa");
            }
          
        }

        public void CargarDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    comboBox1.Items.Add(MisDispositivos[i].Name.ToString());
                }
                
                // comboBox1.Text = MisDispositivos[0].ToString();
                comboBox1.Text = "Seleccione una camara aquí y pulse en grabar";
            }
            else
            {
                HayDispositivos = false;
            }
        }

        private void capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = Imagen;
        }

        private void webcam_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarwebcam();
        }

        private void webcam_Load(object sender, EventArgs e)
        {

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; //deshabilita el introducir texto en el combobox
            CargarDispositivos();
        }
    }
}
