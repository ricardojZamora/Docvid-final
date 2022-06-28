using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Docvid
{
    public partial class login : Form
    {
        // contador para saber que el programa acaba de iniciar y mostrar el splash 1 vez
        public static int cuentadeinicio = 1;


        // instancia para almacenar los datos de la base de datos
        SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
        //ATRIBUTO
        int _Autorizado = 0;


        //funcion para el splash
        public login()
        {
            // iniciamos el login
            InitializeComponent();
           // splash();
            
        }

        void splash()
        {

            // si estamos iniciando el programa, mostrara el splash, sino, no; 
            if (cuentadeinicio == 1)
            {
                //creamos un hilo
                Thread t = new Thread(new ThreadStart(SplashStart));
                //arrancamos el hilo
                t.Start();

                //ponemos a dormir la forma principal
                Thread.Sleep(5000);


                //finalizamos el hilo
                t.Abort();
                // incrementamos el contador de inicio, este dira que ya no se iniciara el programa 
                //y no mostrara el splash, ya que cuentainicio sera diferente de 1 y no entrara a la condicion
                cuentadeinicio++;
            }
        }

        public void SplashStart()
        {
            Application.Run(new Splahs());
        }
        //fin del splash
        
        //quien iniciara sesion (rol de usuario), 1 = administrador, 2 = usuario ordinario
        public void setAutorizado(int a)
        {
            _Autorizado = a;
        }

        //declaracion de autorizado que es el rol del usuario
        //PROPIEDAD DE SOLO LECTURA
        public int Autorizado
        {
            get { return _Autorizado; }
            //set { _Autorizado = value; }
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //validamos las cajas de texto (usuario y credencial)
        private void btningresar_Click(object sender, EventArgs e)
        {
            procesaringreso();
        }

        private void procesaringreso()
        {
            if (txtcredencial.Text == "" && txtusuario.Text == "")
            {
                lblbienvenida.Text = "No ha ingresado usuario y credencial";
            }
            else if (txtcredencial.Text == "")
            {
                lblbienvenida.Text = "No ha ingresado credencial";
            }
            else if (txtusuario.Text == "")
            {
                lblbienvenida.Text = "No ha ingresado usuario";
            }
            else
            {
                Validar(txtusuario.Text, txtcredencial.Text);
            }
        }


        //validamos que exista ese usuario y credencial
        private void validarsolonombre(String pUsuario)
        {
            DataTable DatosUsuario = new DataTable();
            try
            {
                DatosUsuario = CacheManager.SystemCache.Validarnombreusuario(pUsuario);

                if (DatosUsuario.Rows.Count == 1)
                {
                    lblbienvenida.Text = "Credencial errónea";
                }
                else //si no se encuentra el usuario en la base de datos
                {
                    _Autorizado = 0;
                    MessageBox.Show("Nombre de usuario no registrado, por favor registrelo ingresando a un usuario administrador");

                }
            }
            catch { }
        }


        //validamos que exista ese usuario y credencial
        private void Validar(String pUsuario, String pCredencial)
        {
            DataTable DatosUsuario = new DataTable();
            try
            {
                DatosUsuario = CacheManager.SystemCache.ValidarUsuario(pUsuario, pCredencial);

                if (DatosUsuario.Rows.Count == 1)
                {
                    // mira si el estado del usuario es 0 (suspendido) o 1 (activo)
                    _SESION.OUsuario.Estado = DatosUsuario.Rows[0]["estado"].ToString();
                    if( _SESION.OUsuario.Estado == "0")
                    {
                        //_Autorizado = 0;
                        lblbienvenida.Text = "Su cuenta se encuentra suspendida";
                    }

                    else
                    {
                        //_Autorizado = 1;
                        _SESION.OUsuario.Idusuario = DatosUsuario.Rows[0]["idusuario"].ToString();
                        _SESION.OUsuario.Nombre = DatosUsuario.Rows[0]["nombre"].ToString();
                        _SESION.OUsuario.Idrol = DatosUsuario.Rows[0]["idrol"].ToString(); // rol 1 = administrador
                      
                        if (_SESION.OUsuario.Idrol == "1")
                        {
                            _Autorizado = 1; //administrador; rol 1 = administrador
                        }

                        if (_SESION.OUsuario.Idrol == "2") //rol 2, usuario ordinario
                        {
                            _Autorizado = 2;

                        }
                        else 
                        {
                            _Autorizado = 3;

                        }

                        Close();
                    }
                   
                }
                else //si no se encuentra el usuario en la base de datos
                {

                    _Autorizado = 0;
                    //lblbienvenida.Text = "Datos erroneos";
                    validarsolonombre(pUsuario);
                }
            }
            catch { }
        }

        //al presionar el boton salir
        private void btnsalir_Click(object sender, EventArgs e)
        {
            salirdeaplicacion();
        }

        //metodo para salir de la aplicacion
        void salirdeaplicacion()
        {
           // _Autorizado = 0;
            Docvid.CLS.AppManager._Reiniciar = false;
            //Close();
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        // no usado
        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        // si autorizado = 0; quiere decir que no se esta logeando o no esta nadie logeado
        //por lo tanto se cierra todo el programa
        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_Autorizado==0)
            {
                salirdeaplicacion();
            }
            
        }

        //click en la caja de usuarios
        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                procesaringreso();
            }
            //if ((int)e.KeyChar == (int)Keys.Escape)
            //{
            //    salirdeaplicacion();
            //}
        }

        //click en la caja de contrasenia1  
        private void txtcredencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                procesaringreso();
            }
            //if ((int)e.KeyChar == (int)Keys.Escape)
            //{
            //    salirdeaplicacion();
            //}
        }

    }
}
