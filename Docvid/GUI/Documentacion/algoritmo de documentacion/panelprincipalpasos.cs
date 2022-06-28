using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Documentacion.algoritmo_de_documentacion
{
    public partial class panelprincipalpasos : Form
    {
        public static int pasosiguiente =0;
        Boolean cambiopanel = false;
        //esta lista almacenara los pasos que se haran de algoritmo
        public static List<String> pasoshechos = new List<String>();

        public List<String> getlista ()
    {
        return pasoshechos;
    }
        public void vercantidadenlalista()
        {
            MessageBox.Show(pasoshechos.Count.ToString());
        }
        public void agregarpaso(String agregar)
        {
            pasoshechos.Add(agregar);
        }
        public String getidproyecto()
        {
            return txtidescenario.Text;
        }

        public int[] pasosrecorrido;
        
        int contadorrecorrido = 0;  
        private void agregarsiguientepasorecorrido(int a)
        {
           // if(a!= null) 
           // pasosrecorrido[contadorrecorrido] = a;
                contadorrecorrido++;
        }

       public void setpasosiguiente(int a)
        {
            if (a > 0)
            {
                agregarsiguientepasorecorrido(a);
            }
           
            pasosiguiente = a;
            cambiopanel = true;
        }
       public int getpasosiguiente()
       {
           return pasosiguiente;
       }
        public void pasoanterior()
       {
           contadorrecorrido--;
          int pasoanterior = pasosrecorrido[contadorrecorrido];
          setpasosiguiente(pasoanterior);
        }

        public panelprincipalpasos()
        {
            InitializeComponent();
            
        }
        private void limpiarpanel()
        {
            panel.Controls.Clear();
            
        }

        private void abrirenpanel( Form a)
        {
            limpiarpanel();
            panel.Visible = true;
            a.TopLevel = false;
            panel.Controls.Add(a);
            a.Show();
        }

        private void abrirpanelsecundario(Form a)
        {
            limpiarpanel();
            panel.Visible = true;
            a.TopLevel = false;
            panel.Controls.Add(a);
            a.Show();
        }

        //panel de paso 1
        public void panelpaso1()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso1principal a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso1principal();
            abrirpanelsecundario(a);
        }
        public void panelpaso2()
        {
            limpiarpanel();
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso2volatil a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso2volatil();
            abrirenpanel(a);
        }
        public void panelpaso3()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso3 a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso3();
            abrirenpanel(a);

        }
        public void panelpaso4()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso4 a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso4();
            abrirenpanel(a);

        }
        public void panelpaso5()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.btnregresar a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.btnregresar();
            abrirpanelsecundario(a);
        } //se conoce como btnregresar
        public void panelpaso6()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso6 a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso6();
            abrirpanelsecundario(a);
        }
        public void panelpaso7()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.Paso_7 a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.Paso_7();
            abrirenpanel(a);
        }
        public void panelpaso8()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso8 a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso8();
            abrirenpanel(a);
        }
        public void panelpaso9()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso9 a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso9();
            abrirenpanel(a);
        }
        public void panelpaso10()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso10 a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso10();
            abrirenpanel(a);
        }
        public void panelpaso11()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso11 a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso11();
            abrirenpanel(a);
        }
        public void panelpaso12()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso12 a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso12();
            abrirenpanel(a);
        }
        public void panelpaso13()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso13 a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.paso13();
            abrirenpanel(a);
        }
        public void panelpasoterminado()
        {
            Docvid.GUI.Documentacion.algoritmo_de_documentacion.operacion_terminada a = new Docvid.GUI.Documentacion.algoritmo_de_documentacion.operacion_terminada();
            abrirenpanel(a);
        } 
        private void panelprincipalpasos_Load(object sender, EventArgs e)
        {
            //panelpaso1();
            if (postponer())
            {

            }
           
        }
        //para cambiar el panel con los demas pasos
        public void condicionespanel()
        {
            if (pasosiguiente == 1)
            {
                panelpaso1();
                cambiopanel = false;
            }
            if (pasosiguiente == 2)
            {
                panelpaso2();
                cambiopanel = false;
            }
            if (pasosiguiente == 3)
            {
                panelpaso3();
                cambiopanel = false;
            }
            if (pasosiguiente == 4)
            {
                panelpaso4();
                cambiopanel = false;
            }
            if(pasosiguiente == 5)
            {
                panelpaso5();
                cambiopanel = false;
            }
            if (pasosiguiente == 6)
            {
                panelpaso6();
                cambiopanel = false;
            }
            if (pasosiguiente == 7)
            {
                panelpaso7();
                cambiopanel = false;
            }
            if (pasosiguiente == 8)
            {
                panelpaso8();
                cambiopanel = false;
            }
            if (pasosiguiente == 9)
            {
                panelpaso9();
                cambiopanel = false;
            }
            if (pasosiguiente == 10)
            {
                panelpaso10();
                cambiopanel = false;
            }
            if (pasosiguiente == 11)
            {
                panelpaso11();
                cambiopanel = false;
            }
            if (pasosiguiente == 12)
            {
                panelpaso12();
                cambiopanel = false;
            }
            if (pasosiguiente == 13)
            {
                panelpaso13();
                cambiopanel = false;
            }
            if (pasosiguiente == 14)
            {
                panelpasoterminado();
                cambiopanel = false;
            }
        }
        private Boolean postponer()
        {
            Boolean postponers = false;
            try { 
            

            DBManager.CLS.DBOperacion operacioness = new DBManager.CLS.DBOperacion();
            SessionManager.CLS.Sesion sesioness = SessionManager.CLS.Sesion.Instancia;
            DataTable consultass = operacioness.Consultar("Select * from escenarios where idusuario = '" + sesioness.OUsuario.Idusuario + "' order by idescenario desc limit 1;");

                //if(Int32.Parse(consultass.Rows[0]["pasoactual"].ToString())<14)
            if (pasosiguiente > 0 && pasosiguiente < 14 && Int32.Parse(consultass.Rows[0]["pasoactual"].ToString()) > 0 && Int32.Parse(consultass.Rows[0]["pasoactual"].ToString()) < 14)
            {
                 DialogResult result = MessageBox.Show("desea reanudar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                 DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
                 SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;
                 General.CLS.escenarios escenarios = new General.CLS.escenarios();

                 if (result == DialogResult.Yes)
                 {
                     
                     postponers = true;

                     DataTable consulta = operacion.Consultar("Select * from escenarios where idusuario = '" + sesion.OUsuario.Idusuario + "' order by idescenario desc limit 1;");
                     txtnombreescenario.Text = consulta.Rows[0]["titulo"].ToString();
                     txtnotas.Text = consulta.Rows[0]["notas"].ToString();
                     txtidescenario.Text = consulta.Rows[0]["idescenario"].ToString();
                     pasosiguiente = Int32.Parse(consulta.Rows[0]["pasoactual"].ToString());
                     
                 } else
                 {
                     DataTable consulta = operacion.Consultar("Select * from escenarios where idusuario = '" + sesion.OUsuario.Idusuario + "' order by idescenario desc limit 1;");
                     operacion.Actualizar("update escenarios set pasoactual = 14 where idescenario ='"+consulta.Rows[0]["idescenario"].ToString()+"'");
                 }
            }
            else
            {
                pasosiguiente = 0;
            }

            }
            catch { } return postponers;

        }
        //boton de aceptar para iniciar el escenario
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if(txtnombreescenario.Text!=null && txtnombreescenario.Text!="")
            {
                //if(postponer())
                //{
                    
                //}
                //else
                //{
                   // txtnombreescenario.Enabled = false;
                    panelpaso1();
                    this.condicionespanel();
                    guardarescenario();
               // }
                
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre del escenario para empezar");
            }
        }

        private void panelprincipalpasos_DoubleClick(object sender, EventArgs e)
        {
            condicionespanel();
        }

        private void panel_VisibleChanged(object sender, EventArgs e)
        {
            //condicionespanel();
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void panel_Click(object sender, EventArgs e)
        {
            //if (cambiopanel == true)
            //{
            //    condicionespanel();
            //}
        }

        public void AbrirFormulario<T>() where T : Form, new()
        {
           Form  formulario = panel.Controls.OfType<T>().FirstOrDefault();
            if (formulario != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = new T();
            formulario.TopLevel = false;
            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();
        }


        public int segundos = 0;
        //para cambiar el panel
        public void timercambiopanel_Tick(object sender, EventArgs e)
        {
            //timercambiopanel.Enabled = true;
            //timercambiopanel.Start();
            condicionespanel();
            timercambiopanel.Enabled = false;
            //panelpaso5();
            //segundos++;
            //MessageBox.Show("el tiempo es: "+segundos);
            //if(segundos==2)
            //{
            //    condicionespanel();
            //    segundos = 0;
            //    timercambiopanel.Enabled = false;
            //}
            //segundos++;
            //if(segundos>=5)
            //{
            //    condicionespanel();
            //    segundos = 0;
            //    timercambiopanel.Enabled = false;
            //    MessageBox.Show("cambiando");
            //}
           
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
                condicionespanel();
                actualizarnotasescenario();
        }
       
        private void guardarescenario()
        {
            DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;
            General.CLS.escenarios escenarios = new General.CLS.escenarios();
            
            escenarios.Idusuario = sesion.OUsuario.Idusuario;
            escenarios.Titulo = txtnombreescenario.Text;
            escenarios.Notas = txtnotas.Text;
            escenarios.Pasoactual = "1";

            if(escenarios.Guardar())
            {
                DataTable consulta = operacion.Consultar("select * from proyectos where idusuario = '" + sesion.OUsuario.Idusuario + "' order by idproyecto desc limit 1 ;");
                txtidescenario.Text = consulta.Rows[0]["idproyecto"].ToString();
            }
            else
            {
                MessageBox.Show("No se pudo guardar este esenario");
            }

        }
        private void actualizarnotasescenario()
        {
            DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;
            General.CLS.escenarios escenarios = new General.CLS.escenarios();
            DataTable consulta = operacion.Consultar("Select * from proyectos where idusuario = '"+sesion.OUsuario.Idusuario+"' order by idproyecto desc limit 1;");
            escenarios.Idescenario = consulta.Rows[0]["idproyecto"].ToString();
            escenarios.Notas = txtnotas.Text;
            escenarios.Pasoactual = pasosiguiente.ToString();
            escenarios.Idusuario = consulta.Rows[0]["idusuario"].ToString();
            escenarios.Titulo = txtnombreescenario.Text;
            if(escenarios.Actualizar())
            {

            }
            else
            {
                MessageBox.Show("No se ha podido actualizar el escenario");
            }
        }

        // terminar escenario
        private void btnterminar_Click(object sender, EventArgs e)
        {

             DialogResult result = MessageBox.Show("Terminar el escenario actual?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if (result == DialogResult.Yes)
             {
                 DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
                 SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;
                 General.CLS.escenarios escenarios = new General.CLS.escenarios();

                 escenarios.Idusuario = sesion.OUsuario.Idusuario;
                 escenarios.Titulo = txtnombreescenario.Text;
                 escenarios.Notas = txtnotas.Text;
                 escenarios.Pasoactual = "14";

                 if (escenarios.Guardar())
                 {
                     //DataTable consulta = operacion.Consultar("select * from escenarios where idusuario = '" + sesion.OUsuario.Idusuario + "' order by idescenario desc limit 1 ;");
                     //txtidescenario.Text = consulta.Rows[0]["idescenario"].ToString();
                     limpiarpanel();
                     pasosiguiente = 0;
                     txtnotas.Text = "";
                     txtidescenario.Text = "";
                     txtnombreescenario.Text = "";
                 }
             }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpasoanterior_Click(object sender, EventArgs e)
        {
            pasoanterior();
            condicionespanel();
            actualizarnotasescenario();
        }

    }
}
