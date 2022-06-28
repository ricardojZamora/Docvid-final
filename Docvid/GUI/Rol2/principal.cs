using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Rol2
{
    public partial class principal : Form
    {

        /*inicio de permisos*/

        DataTable Resultadopermisos = new DataTable();
        public static String soloverproyectos, verproyectosajenos, suspendercuenta,
            cambiarcredencial, crearevidencias, gestionarusuarios, gestionarroles,crearproyectos,
            compartirproyectos,compartirevidencias;

        public String getcompartirproyectos()
        {
            return compartirproyectos;
        }
        public String getcompartirevidencias()
        {
            return compartirevidencias;
        }
        public String getsoloverproyectos()
        {
            return soloverproyectos;
        }
        public String getverproyectosajenos()
        {
            return verproyectosajenos;
        }
        public String getsuspendercuenta()
        {
            return suspendercuenta;
        }
        public String getcambiarcredencial()
        {
            return cambiarcredencial;
        }
        public String getcrearevidencias()
        {
            return crearevidencias;
        }
        public String getgestionarusuarios()
        {
            return gestionarroles;
        }
        public String getgestionarroles()
        {
            return gestionarroles;
        }
        public String getcrearproyectos()
        {
            return crearproyectos;
        }


        public void verificarpermisos()
        {
            //ver el rol que tiene 
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String rolactual = _SESION.OUsuario.Idrol.ToString();


            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select * from permisos;
                select p.*
                from permisos p, roles r
                where r.idrol = p.idrol and p.idrol ='" + rolactual + "';");
            try
            {
                Resultadopermisos = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultadopermisos = new DataTable();
            }



            int rolactualint = int.Parse(rolactual);
            gestionarusuarios = Resultadopermisos.Rows[rolactualint - 1]["gestionarusuarios"].ToString();
            soloverproyectos = Resultadopermisos.Rows[rolactualint - 1]["soloverproyectos"].ToString();
            verproyectosajenos = Resultadopermisos.Rows[rolactualint - 1]["verproyectosajenos"].ToString();
            suspendercuenta = Resultadopermisos.Rows[rolactualint - 1]["suspendercuenta"].ToString();
            cambiarcredencial = Resultadopermisos.Rows[rolactualint - 1]["cambiarcredencial"].ToString();
            crearevidencias = Resultadopermisos.Rows[rolactualint - 1]["crearevidencias"].ToString();
            gestionarusuarios = Resultadopermisos.Rows[rolactualint - 1]["gestionarusuarios"].ToString();
            gestionarroles = Resultadopermisos.Rows[rolactualint - 1]["gestionarroles"].ToString();
            crearproyectos = Resultadopermisos.Rows[rolactualint - 1]["crearproyectos"].ToString();
            compartirproyectos = Resultadopermisos.Rows[rolactualint - 1]["compartirproyectos"].ToString();
            compartirevidencias = Resultadopermisos.Rows[rolactualint - 1]["compartirevidencias"].ToString();

        }

        private void permitido()
        {
         if(crearproyectos == "0")
         { 
             btncadenas.Visible = false;
         }
        }

        /*fin de permisos*/



        //metodo para salir de usuario
        Boolean _Reiniciar = false;

        public Boolean Reiniciar
        {
            get { return _Reiniciar; }
        }

        public principal()
        {
            InitializeComponent();
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            lblbienvenida.Text = "Usuario: " + _SESION.OUsuario.Nombre.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestores.Documentos.agregardocumento a = new Gestores.Documentos.agregardocumento();
            a.ShowDialog();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            cerrarsesion();
        }

        //cerramos sesion
        void cerrarsesion()
        {
            _Reiniciar = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rol2.cadenadecustodia.proyectos a = new cadenadecustodia.proyectos();
            a.ShowDialog();
        }

        private void principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarsesion();
        }

        private void btncuenta_Click(object sender, EventArgs e)
        {
            cuenta.informacion a = new cuenta.informacion();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Documentacion.algoritmo_de_documentacion.paso1principal a = new Documentacion.algoritmo_de_documentacion.paso1principal();
            a.ShowDialog();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            lblindicacion.Visible = true;
            lblindicacion.Text = "Edite sus cadenas de custodia y documentos"; 
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblindicacion.Visible = false;
        }


        // METODO PARA LOS PERMISOS



        private void principal_Load(object sender, EventArgs e)
        {
            verificarpermisos();
            permitido();
            //// solo muestra
           //  MessageBox.Show("hola " + documentar);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Gestores.proyectoscompartidos.gestorproyectoscompartidos a = new Gestores.proyectoscompartidos.gestorproyectoscompartidos();
            a.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Gestores.compartirproyectos.gestionarcompartir a = new Gestores.compartirproyectos.gestionarcompartir();
            a.ShowDialog();
        }

    }

}
