using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.Roles
{
    public partial class agregarrol : Form
    {

        DataTable Resultadoexisterol = new DataTable();

        void informaciondeexisteelproyectocompartido(String desripcionrolactual)
        {
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            //SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            //String rolactual = _SESION.OUsuario.Idusuario.ToString();


            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select * from roles where descripcion ='" + desripcionrolactual + "';");
            try
            {
                Resultadoexisterol = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultadoexisterol = new DataTable();
            }
        }

       // public static String idrolagregado;

       // public static String getidrolagregado()
        //{
          //  return idrolagregado;
       // }

        public static String rolseleccionado;

        public static String getrolseleccionado()
        {
            return rolseleccionado;
        }

        private Boolean Verificacion()///verificando que eñ campo nombre no este vacio
        {
            Boolean Verificado = true;
            Notificador.Clear();
            if (txtdescripcion.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtdescripcion, "Este campo no puede quedar vacio");
            }
            /* if (txtdescripcion.TextLength <= 0)
             {
                 Verificado = false;
                 Notificador.SetError(txtdescripcion, "Este campo no puede quedar vacio");
             }
             */
            return Verificado;

        }

        private void Procesar()
        {
            if (Verificacion())
            {
                General.CLS.Roles oEmpleado = new General.CLS.Roles();
                oEmpleado.Idrol = txtid.Text;
                oEmpleado.Descripcion = txtdescripcion.Text;


                if (txtid.TextLength == 0)
                {
                    ///Estoy insertando un nuevo registro
                    if (oEmpleado.Guardar())
                    {
                        MessageBox.Show("Registro guardado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        //Close();
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser guardado", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    ///estoy actualizando un registro
                    ///
                    if (oEmpleado.Actualizar())
                    {
                        MessageBox.Show("Registro actualizado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       // Close();
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser actualizado", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        public agregarrol()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if(txtid.Text == "")
            {
                informaciondeexisteelproyectocompartido(txtdescripcion.Text);
                //checa que no exista la misma descripcion de este rol
                try
                {
                    if (Resultadoexisterol.Rows[0]["descripcion"].ToString() != txtdescripcion.Text)
                    {
                        Procesar();
                        MessageBox.Show("Agregue los permisos para este nuevo rol");

                        //verificar el id del rol agregado
                        informaciondeexisteelproyectocompartido(txtdescripcion.Text);
                        //idrolagregado = Resultadoexisterol.Rows[0]["idrol"].ToString();
                        rolseleccionado = txtdescripcion.Text;


                        permisos.listadepermisos a = new permisos.listadepermisos();
                        a.ShowDialog();
                        
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Esta descripcion ya existe, pruebe con otra");
                    }
                }
                    //si no existe y da error el datatable, entonces no existe esa descripcion y esta listo para agregar
                catch
                {
                    Procesar();
                    MessageBox.Show("Agregue los permisos para este nuevo rol");
                    //verificar el id del rol agregado
                    informaciondeexisteelproyectocompartido(txtdescripcion.Text);
                    //idrolagregado = Resultadoexisterol.Rows[0]["idrol"].ToString();
                    rolseleccionado = txtdescripcion.Text;

                    //abriendo la lista de permisos
                    permisos.listadepermisos a = new permisos.listadepermisos();
                    a.ShowDialog();
                    
                  
                    Close();
                }
               
                
            }
            else
            {
                Procesar();
                Close();
            }
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rolseleccionado = txtid.Text;
            permisos.listadepermisos a = new permisos.listadepermisos();
            a.ShowDialog();
            //permisos.gestionpermisos a = new permisos.gestionpermisos();
            //a.ShowDialog();
            //txtidpermiso.Text = a.dtgvdatos.CurrentRow.Cells["idpermiso"].Value.ToString();
            // aqui debe abrir la ventana de lista de permisos
        }

        private void agregarrol_FormClosed(object sender, FormClosedEventArgs e)
        {
            rolseleccionado = null;
        }

        private void agregarrol_Load(object sender, EventArgs e)
        {
            if(txtid.Text== "")
            {
                lblpermiso.Visible = false;
                btngestionarpermiso.Visible = false;
            }
        }
    }
}
