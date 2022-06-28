using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI
{
    public partial class nuevaprincipal : Form
    {
        public nuevaprincipal()
        {
            InitializeComponent();
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            DataTable informaciondelacuenta = new DataTable();
            DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
            informaciondelacuenta = operacion.Consultar("select * from usuarios where idusuario = '"+_SESION.OUsuario.Idusuario+"';");

            try
            {
                btncerrarsesion.Text = "Cerrar sesion (" + informaciondelacuenta.Rows[0]["nombre"].ToString() + ")";
            }
            catch
            {
                Application.Exit();
            }
            
        }
        //metodo para salir de usuario
        Boolean _Reiniciar = false;

        public Boolean Reiniciar
        {
            get { return _Reiniciar; }
        }
        void cerrarsesion()
        {
            _Reiniciar = true;
            Close();
        }

        private void nuevaprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarsesion();

        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            cerrarsesion();
            Close();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
        }
        //limpia el panel principal
        private void limpiarpanel()
        {
            panelprincipal.Controls.Clear();
        }

        private void btnusuarios_Click_1(object sender, EventArgs e)
        {

            Gestores.Usuarios.gestionarusuario a = new Gestores.Usuarios.gestionarusuario();
            limpiarpanel();
            a.TopLevel = false;
            panelprincipal.Controls.Add(a);
            a.Show();
        }

        private void btnmicuenta_Click(object sender, EventArgs e)
        {
            GUI.Gestores.herramientas_administrativas.paneladministrativo a = new GUI.Gestores.herramientas_administrativas.paneladministrativo();
            abrirfrmpanel(a);
        }
        private void abrirfrmpanel (Form a )
        {
            limpiarpanel();
            a.TopLevel = false;
            panelprincipal.Controls.Add(a);
            a.Show();
        }

        private void btncompartidos_Click(object sender, EventArgs e)
        {
            GUI.Gestores.compartirproyectos.gestionarcompartir a = new GUI.Gestores.compartirproyectos.gestionarcompartir();
            abrirfrmpanel(a);
        }

        private void btnproyectoscompartidosconmigo_Click(object sender, EventArgs e)
        {
            GUI.Gestores.proyectoscompartidos.gestorproyectoscompartidos a = new Gestores.proyectoscompartidos.gestorproyectoscompartidos();
            abrirfrmpanel(a);
        }

        private void btnpermisos_Click(object sender, EventArgs e)
        {
            //GUI.Gestores.Roles.gestionarol a = new Gestores.Roles.gestionarol();
            //abrirfrmpanel(a);
            Rol2.cuenta.informacion a = new Rol2.cuenta.informacion();
            abrirfrmpanel(a);
        }

        private void btndocumentar_Click(object sender, EventArgs e)
        {
            Documentacion.algoritmo_de_documentacion.panelprincipalpasos a = new Documentacion.algoritmo_de_documentacion.panelprincipalpasos();
            abrirfrmpanel(a);
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            limpiarpanel();
        }

        private void btnmisevidencias_Click(object sender, EventArgs e)
        {
            Gestores.Evidencia.todas_las_evidencias a = new Gestores.Evidencia.todas_las_evidencias();
            //a.ShowDialog();
             abrirfrmpanel(a);
        }

        private void btnadministrardocumentos_Click(object sender, EventArgs e)
        {
            Gestores.Cadenasdecustodias.gestioncadenas a = new Gestores.Cadenasdecustodias.gestioncadenas();
            abrirfrmpanel(a);
        }

        private void btnfirmadigital_Click(object sender, EventArgs e)
        {
            Docvid.GUI.Gestores.hash.seleccion_llaves a = new Gestores.hash.seleccion_llaves();
            a.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para manejar la documentación se debe ir de arriba hacia abajo en orden");
        }
    }
}
