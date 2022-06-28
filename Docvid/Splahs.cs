using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid
{
    public partial class Splahs : Form
    {
        public Splahs()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //incrementar la barra
            progressBar1.Increment(1);

            // si llega al maximo paramos el timer
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
            }
        }
    }
}
