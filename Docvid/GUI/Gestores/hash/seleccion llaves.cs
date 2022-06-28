using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.hash
{
    public partial class seleccion_llaves : Form
    {
        public seleccion_llaves()
        {
            InitializeComponent();
        }

        private void buscandollavepublica()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM files(*.PEM) | *.PEM";
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtllavepublica.Text = openFileDialog.FileName;
            }

        }
        private void buscandollaveprivada()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM files(*.PEM) | *.PEM";
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtllaveprivada.Text = openFileDialog.FileName;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            buscandollavepublica();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscandollaveprivada();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;
            DBManager.CLS.DBOperacion conexion = new DBManager.CLS.DBOperacion();
            String llavepublica = txtllavepublica.Text.Replace(@"\","/");
            String llaveprivada = txtllaveprivada.Text.Replace(@"\","/");
            try
            {
                conexion.Actualizar("update usuarios set llavepublica ='" + llavepublica + "', llaveprivada = '" + llaveprivada + "' where idusuario = '" + sesion.OUsuario.Idusuario + "' ;");
                MessageBox.Show("Llaves actualizadas");
                Close();
            }
            catch { MessageBox.Show("No se ha podido actualizar las llaves"); }

        }
        
        //borramos la ubicacion de las llaves actuales
        private void btnborrarllavesactual_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DBManager.CLS.DBOperacion conexion = new DBManager.CLS.DBOperacion();
                SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;

                conexion.Actualizar("update usuarios set llavepublica = null , llaveprivada = null where idusuario = '" + sesion.OUsuario.Idusuario + "' ;");

            }
            else { }
        }
    }
}
