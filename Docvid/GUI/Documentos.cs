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
    public partial class Documentos : Form
    {

        DataTable Resultadopermisos = new DataTable();
        public Documentos()
        {
            InitializeComponent();
        }

        void informaciondeusuarioactual()
        {
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String rolactual = _SESION.OUsuario.Idrol.ToString();


            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select verproyectosajenos from permisos where idrol ='" + rolactual + "';");
            try
            {
                Resultadopermisos = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultadopermisos = new DataTable();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestores.Documentos.agregardocumento a = new Gestores.Documentos.agregardocumento();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            informaciondeusuarioactual();
            if(Resultadopermisos.Rows[0]["verproyectosajenos"].ToString() == "1")
            {
                Gestores.Documentos.agregardocumento.buscando = false;
                Gestores.Cadenasdecustodias.gestioncadenas a = new Gestores.Cadenasdecustodias.gestioncadenas();
                a.ShowDialog();
            }
            else
            {
                Rol2.cadenadecustodia.proyectos a = new Rol2.cadenadecustodia.proyectos();
                a.ShowDialog();
            }
            
        }

        private void Documentos_Load(object sender, EventArgs e)
        {
            
        }

        // no se esta usando, estado = invisible
        private void btngestiondocumentos_Click(object sender, EventArgs e)
        {
            //Documentacion.Listaescenarios g = new Documentacion.Listaescenarios();
            Documentacion.algoritmo_de_documentacion.panelprincipalpasos g = new Documentacion.algoritmo_de_documentacion.panelprincipalpasos();
            g.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI.Gestores.proyectoscompartidos.gestorproyectoscompartidos a = new Gestores.proyectoscompartidos.gestorproyectoscompartidos();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gestores.compartirproyectos.gestionarcompartir a = new Gestores.compartirproyectos.gestionarcompartir();
            a.ShowDialog();
        }
    }
}
