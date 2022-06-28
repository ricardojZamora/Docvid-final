using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Docvid.GUI.Gestores.herramientas_administrativas
{
    public partial class paneladministrativo : Form
    {
        public paneladministrativo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipo_evidencias.gestiontipoevidencias a = new tipo_evidencias.gestiontipoevidencias();
            a.ShowDialog();
        }

        private void btnroles_Click(object sender, EventArgs e)
        {
            Roles.gestionarol a = new Roles.gestionarol();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hash.hashu a = new hash.hashu();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hash.encriptar a = new hash.encriptar();
            a.ShowDialog();
        }

        private void btnfirma_Click(object sender, EventArgs e)
        {
            firma_digital.panelfirmaprincipal a = new firma_digital.panelfirmaprincipal();
            a.ShowDialog();
        }
    }
}
