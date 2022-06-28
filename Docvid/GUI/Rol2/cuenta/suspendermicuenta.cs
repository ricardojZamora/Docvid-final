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
    public partial class suspendermicuenta : Form
    {

        BindingSource __CLIENTES = new BindingSource();
        SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;

        public suspendermicuenta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_SESION.OUsuario.Idusuario == "1")
            {
                MessageBox.Show("El usuario anfitrion no puede suspenderse");
            }
            else
            {
                validar();

            }
        }


        private void desactivarusuario()
        {
            SessionManager.CLS.Sesion _SESIONES = SessionManager.CLS.Sesion.Instancia;
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            String usuarioactuall = _SESIONES.OUsuario.Idusuario.ToString();

            if (usuarioactuall == "1")
            {
                MessageBox.Show("Este usuario no se puede desactivar por que es el administrador del programa");
            }

            else
            {
                    // Sentencia.Append("update idusuario set'" + _SESION.OUsuario.Idusuario.ToString() + "' from cadenasdecustodias where idusuario = '" + dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString() + "';");
                    Sentencia.Append("update usuarios set estado = 0 where idusuario ='" + usuarioactuall + "';");
                
                DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();

                try
                {
                    if (oOperacion.Insertar(Sentencia.ToString()) > 0)
                    {
                        Guardado = true;
                    }
                    else
                    {
                        Guardado = false;
                    }
                    MessageBox.Show("Cuenta suspendida, contacte con el administrador de la aplicacion para activarla");
                    
                    //principal a = new principal();
                    //a.Close();
                    //informacion d = new informacion();
                    //d.Close();

                    //cerrando ventanas 
                    foreach (Form frm in Application.OpenForms)
                    {
                        login lo = new login();

                        if (frm != lo)    //Cerramos todos los formularios menos el formulario principal que contiene el menú
                            frm.Close();
                    }
                    Close();
                    
                }
                catch
                {
                    Guardado = false;
                    MessageBox.Show("No se puede activar o desactivar el usuario");
                }
            }


        }


        void validar()
        {
            DataTable DatosUsuario = new DataTable();
            try
            {
                String usuarioactual = _SESION.OUsuario.Nombre.ToString();
                DatosUsuario = CacheManager.SystemCache.ValidarUsuario(usuarioactual, txt1.Text);

                if (DatosUsuario.Rows.Count == 1)
                {
                    // mira si el estado del usuario es 0 (suspendido) o 1 (activo)
                    _SESION.OUsuario.Estado = DatosUsuario.Rows[0]["estado"].ToString();
                    if (txt1.Text == txt2.Text)
                    {
                        desactivarusuario();
                    }

                    else
                    {
                        MessageBox.Show("No se ha podido desactivar el usuario");
                    }

                }
                else //si no se encuentra el usuario en la base de datos
                {
                    MessageBox.Show("Contraseña actual incorrecta");

                }
            }
            catch { }
        }

    }
}
