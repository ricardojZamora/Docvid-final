using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI
{

    public partial class Administrador : Form
    {

        /*inicio de permisos*/

        DataTable Resultadopermisos = new DataTable();
        public static String soloverproyectos, verproyectosajenos, suspendercuenta,
            cambiarcredencial, crearevidencias, gestionarusuarios, gestionarroles, crearproyectos,
            compartirproyectos, compartirevidencias;

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
            gestionarusuarios = Resultadopermisos.Rows[rolactualint-1]["gestionarusuarios"].ToString();
            soloverproyectos = Resultadopermisos.Rows[rolactualint-1]["soloverproyectos"].ToString();
            verproyectosajenos= Resultadopermisos.Rows[rolactualint-1]["verproyectosajenos"].ToString();
            suspendercuenta= Resultadopermisos.Rows[rolactualint-1]["suspendercuenta"].ToString();
            cambiarcredencial= Resultadopermisos.Rows[rolactualint-1]["cambiarcredencial"].ToString();
            crearevidencias= Resultadopermisos.Rows[rolactualint-1]["crearevidencias"].ToString();
            gestionarusuarios= Resultadopermisos.Rows[rolactualint-1]["gestionarusuarios"].ToString();
            gestionarroles = Resultadopermisos.Rows[rolactualint - 1]["gestionarroles"].ToString();
            crearproyectos = Resultadopermisos.Rows[rolactualint - 1]["crearproyectos"].ToString();
            compartirproyectos =Resultadopermisos.Rows[rolactualint - 1]["compartirproyectos"].ToString();
            compartirevidencias = Resultadopermisos.Rows[rolactualint - 1]["compartirevidencias"].ToString();


        }
        void permitido()
        {
            if(getgestionarusuarios() == "0")
            {
                btngestionusuarios.Visible = false;
            }
            if (getgestionarroles() == "0")
            {
                btngestionroles.Visible = false;
            }
            
        }


        //metodo para salir de usuario
        Boolean _Reiniciar = false;

        public Boolean Reiniciar
        {
            get { return _Reiniciar; }
        }


        public Administrador()
        {
            InitializeComponent();
            ////codigo para abrir archivos externos
            //Process pr = new Process();
            //string Directorio = @"C:\Users\Kevin\Documents\Docvid";
            ////Configuramos las opociones iniciales del proceso
            //pr.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

            //pr.StartInfo.WorkingDirectory = Directorio;
            //// Aqui se introduce el nombre del archivo
            //pr.StartInfo.FileName = "ejemplo.txt";
            //// Asegurese de tener creado este archivo
            //pr.Start();
            

            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            lblbienvenida.Text = "Usuario: " + _SESION.OUsuario.Nombre.ToString();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            cerrarsesion();
        }

        void cerrarsesion()
        {
            _Reiniciar = true;
            Close();
        }

        private void btngestionauditores_Click(object sender, EventArgs e)
        {
            Docvid.GUI.Gestores.Auditores.gestionauditores f = new Docvid.GUI.Gestores.Auditores.gestionauditores();
            f.ShowDialog();
           // Close();
        }

        private void btngestionroles_Click(object sender, EventArgs e)
        {
            Docvid.GUI.Gestores.Roles.gestionarol f = new Gestores.Roles.gestionarol();
            f.ShowDialog();
            //Close();
        }

        private void btngestionusuarios_Click(object sender, EventArgs e)
        {
            Gestores.Usuarios.gestionarusuario f = new Gestores.Usuarios.gestionarusuario();
            f.ShowDialog();
            //Close();
        }

        private void btngestordocumentos_Click(object sender, EventArgs e)
        {
            Documentos a = new Documentos();
            a.ShowDialog();
            //Close();
        }

        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarsesion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rol2.cuenta.cambiocontrasenia a = new Rol2.cuenta.cambiocontrasenia();
            a.ShowDialog();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            lblinstrucciones.Visible = true;
            lblinstrucciones.Text = "Cambiar la contraseña de su usuario actual";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblinstrucciones.Visible = false;
        }

        private void btngestionusuarios_MouseEnter(object sender, EventArgs e)
        {
            lblinstrucciones.Visible = true;
            lblinstrucciones.Text = "Administre los usuarios";
        }

        private void btngestionusuarios_MouseLeave(object sender, EventArgs e)
        {
            lblinstrucciones.Visible = false;
        }

        private void btngestordocumentos_MouseEnter(object sender, EventArgs e)
        {
            lblinstrucciones.Visible = true;
            lblinstrucciones.Text = "Documente, gestione cadenas de custodia y documentos";
        }

        private void btngestordocumentos_MouseLeave(object sender, EventArgs e)
        {
            lblinstrucciones.Visible = false;

        }

        private void btngestionroles_MouseEnter(object sender, EventArgs e)
        {
            lblinstrucciones.Text = "Administre los permisos de los usuarios";
            lblinstrucciones.Visible = true;
        }

        private void btngestionroles_MouseLeave(object sender, EventArgs e)
        {
            lblinstrucciones.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rol2.cuenta.informacion a = new Rol2.cuenta.informacion();
            a.ShowDialog();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            
            verificarpermisos();
            permitido();
        }




    }
}
