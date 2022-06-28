using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Rol2.cuenta
{
    public partial class informacion : Form
    {
        DataTable Resultadopermisos = new DataTable();
        BindingSource __CLIENTES = new BindingSource();
        SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
        public informacion()
        {
            InitializeComponent();
            permitido();
        }

        void cargardatos()
        {
            permitido();
            try
            {
                __CLIENTES.DataSource = CacheManager.SystemCache.TODOS_LOS_USUARIOS();

                //pendiente
                //   FiltrarLocalmente();
            }
            catch
            {

            }
            // dtgvdatos.AutoGenerateColumns = false;
            dtgvdatos.DataSource = __CLIENTES;

            //verifica la descripcion de su rol
            versurol();

            lblusuarionombre.Text = "Nombre de usuario: "+ _SESION.OUsuario.Nombre.ToString();
            lblid.Text = "ID de usuario: " + _SESION.OUsuario.Idusuario.ToString();
           //  __CLIENTES.Filter = "nombre LIKE '" + _SESION.OUsuario.Nombre.ToString() + "%'";
         //   lblrol.Text = "Rol: " + dtgvdatos. + _SESION.OUsuario.Idrol.ToString();
           // lblrol.Text = "ID rol : " + _SESION.OUsuario.Idrol.ToString();
            lblrol.Text = "Rol: " + Resultadopermisos.Rows[0]["descripcion"].ToString();

            DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
            Resultadopermisos = operacion.Consultar("Select * from usuarios where idusuario = '"+_SESION.OUsuario.Idusuario+"';");

            lbltelefono.Text = "Telefono: " + Resultadopermisos.Rows[0]["telefono"].ToString();
        }

        private void informacion_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btncambiarcontra_Click(object sender, EventArgs e)
        {
            cambiocontrasenia a = new cambiocontrasenia();
            a.ShowDialog();
        }

        private void btnsuspender_Click(object sender, EventArgs e)
        {
            suspendermicuenta a = new suspendermicuenta();
            a.ShowDialog();   
        }

        private void versurol()
        {
            //ver el rol que tiene 
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String rolactual = _SESION.OUsuario.Idusuario.ToString();


            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select descripcion 
            from roles 
            where idrol = (select idrol from usuarios where idusuario ='" + rolactual + "');");
            try
            {
                Resultadopermisos = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultadopermisos = new DataTable();
            }
        }

        private void permitido()
        {
            if(_SESION.OUsuario.Idusuario == "1")
            {
                btnsuspender.Visible = false;
            }

            principal a = new principal();
            if (a.getcambiarcredencial() == "0")
            {
                btncambiarcontra.Visible = false;
            }
            if (a.getsuspendercuenta() == "0")
            {
                btnsuspender.Visible = false;
            }
        }
    }
}
