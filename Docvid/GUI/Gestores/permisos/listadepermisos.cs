using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.permisos
{
    public partial class listadepermisos : Form
    {

          DataTable Resultadopermisos = new DataTable();
          DataTable Cargarelnuevorol = new DataTable();


          //consultando las cadenas
          void CARGAR_NUEVO_ROL(String al)
          {
              //mi id para saber las cadenas de custodias que tengo
              // accedemos al id del usuario actual
              SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
              String idusuarioactual = _SESION.OUsuario.Idusuario.ToString();

              StringBuilder Sentencia = new StringBuilder();
              DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

              Sentencia.Append(@"select descripcion from roles where descripcion = '" + al + "';");
              try
              {
                  Cargarelnuevorol = oConsulta.Consultar(Sentencia.ToString());
              }
              catch
              {
                  Cargarelnuevorol = new DataTable();
              }

          }


        public listadepermisos()
        {
            InitializeComponent();
        }
        
        void consultarpermisosguardados()
        {
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String rolactual = Gestores.Roles.agregarrol.getrolseleccionado();


            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select p.*
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
        }

        void checandolospermisos()
        {
            /*lista de permisos 
             Solo ver proyectos 
Ver proyectos ajenos 1
Suspender cuenta 2
Cambiar credencial 3
Crear evidencias  4
Gestionar usuarios  5
Gestionar roles  6
Crear proyectos 7
Compartir proyectos 8
             */

            try
            {
                if (Resultadopermisos.Rows[0]["soloverproyectos"].ToString() == "1")
                {
                    lstdatos.SetItemChecked(0, true);
                }
                if (Resultadopermisos.Rows[0]["verproyectosajenos"].ToString() == "1")
                {
                    lstdatos.SetItemChecked(1, true);
                }
                if (Resultadopermisos.Rows[0]["suspendercuenta"].ToString() == "1")
                {
                    lstdatos.SetItemChecked(2, true);
                }
                if (Resultadopermisos.Rows[0]["cambiarcredencial"].ToString() == "1")
                {
                    lstdatos.SetItemChecked(3, true);
                }
                if (Resultadopermisos.Rows[0]["crearevidencias"].ToString() == "1")
                {
                    lstdatos.SetItemChecked(4, true);
                }
                if (Resultadopermisos.Rows[0]["gestionarusuarios"].ToString() == "1")
                {
                    lstdatos.SetItemChecked(5, true);
                }
                if (Resultadopermisos.Rows[0]["gestionarroles"].ToString() == "1")
                {
                    lstdatos.SetItemChecked(6, true);
                }
                if (Resultadopermisos.Rows[0]["crearproyectos"].ToString() == "1")
                {
                    lstdatos.SetItemChecked(7, true);
                }
                if (Resultadopermisos.Rows[0]["compartirproyectos"].ToString() == "1")
                {
                    lstdatos.SetItemChecked(8, true);
                }
                txtidpermiso.Text = Resultadopermisos.Rows[0]["idpermiso"].ToString();
            }
                //si es nuevo rol, tendra estos permisos
            catch
            {
               // lblidrol.Text = Gestores.Roles.agregarrol.getidrolagregado();
                //lblidrol.Visible = true;
                //lblrolaplicado.Text = "Aplicando a rol " + Gestores.Roles.agregarrol.idrolagregado;

                //lblrolaplicado.Text = "Aplicando a rol " + Cargarelnuevorol.Rows[0]["idrol"].ToString();
                lblidrol.Text = Gestores.Roles.agregarrol.rolseleccionado;

               // lblrolaplicado.Text = "Aplicando a rol " + Cargarelnuevorol.Rows[0]["idrol"].ToString();
               // lblidrol.Text = Cargarelnuevorol.Rows[0]["idrol"].ToString();
                lstdatos.SetItemChecked(0, false);
                lstdatos.SetItemChecked(1, false);
                lstdatos.SetItemChecked(2, false);
                lstdatos.SetItemChecked(3, true);
                lstdatos.SetItemChecked(4, true);
                lstdatos.SetItemChecked(5, false);
                lstdatos.SetItemChecked(6, false);
                lstdatos.SetItemChecked(7, true);
                lstdatos.SetItemChecked(8, true);
                btncancelar.Visible = false;
            }
            
        }
        
        //consultando las cadenas
        public static DataTable PERMISOSCARGADOS(String idpermisoseleccionado)
        {
            //mi id para saber las cadenas de custodias que tengo
            // accedemos al id del usuario actual
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String idusuarioactual = _SESION.OUsuario.Idusuario.ToString();
            

            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@" select *
                from permisos
                where idpermiso = '" + idpermisoseleccionado + "';");
            try
            {
                Resultado = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        private void CargarDatos()
        {
            try
            {
                Resultadopermisos = PERMISOSCARGADOS(txtidpermiso.Text);
               CARGAR_NUEVO_ROL(lblrolaplicado.Text);

                //pendiente
                //   FiltrarLocalmente();
            }
            catch
            {

            }
           

            // lblRegistros.Text = dtgvdatos.Rows.Count.ToString() + " Registors Encontrados";

        }

        private void listadepermisos_Load(object sender, EventArgs e)
        {
            consultarpermisosguardados();
            if(Gestores.Roles.agregarrol.rolseleccionado!=null)
            {
                checandolospermisos();
                lblrolaplicado.Text = "Aplicado a rol: " + Gestores.Roles.agregarrol.rolseleccionado;
                btnseleccionarrol.Visible = false;
            }

            else if(Gestores.permisos.gestionpermisos.agregar)
            {
              
            }
            
            else
            {
                CargarDatos();
                checandolospermisos();
                CARGAR_NUEVO_ROL(lblrolaplicado.Text);
                lblrolaplicado.Text = "Aplicado a rol: " + txtidpermiso.Text;
                btnseleccionarrol.Visible = false;
            }
            
        }

        private void listadepermisos_FormClosed(object sender, FormClosedEventArgs e)
        {
            permisos.gestionpermisos.agregar = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Roles.gestionarol a = new Roles.gestionarol();
            a.ShowDialog();
            lblrolaplicado.Text = "Permisos aplicados a " + a.dtgvdatos.CurrentRow.Cells["idrol"].Value.ToString() + " (" + a.dtgvdatos.CurrentRow.Cells["descripcion"].Value.ToString()+")";
            lblidrol.Text = a.dtgvdatos.CurrentRow.Cells["idrol"].Value.ToString();
            CargarDatos();
        }

        // guardando o agregando permisos
        private void button1_Click(object sender, EventArgs e)
        {

            procesar();
        }

        private void procesar()
        {

            General.CLS.permisos oEmpleado = new General.CLS.permisos();
            
               // int one = lstdatos.SelectedIndex;

            // este se uso antes para checar lstdatos.CheckedItems[1].ToString() == "1"

            /*CHECADOS PERMISOS*/
            if(lstdatos.GetItemChecked(0) == true)
            {
                oEmpleado.Soloverproyectos = "1";
            }
            if (lstdatos.GetItemChecked(1) == true)
            {
                oEmpleado.Verproyectosajenos = "1";
            }
            if (lstdatos.GetItemChecked(2) == true)
            {
                oEmpleado.Suspendercuenta = "1";
            }
            if (lstdatos.GetItemChecked(3) == true)
            {
                oEmpleado.Cambiarcredencial = "1";
            }
            if (lstdatos.GetItemChecked(4) == true)
            {
                oEmpleado.Crearevidencias = "1";
            }
            if (lstdatos.GetItemChecked(5) == true)
            {
                oEmpleado.Gestionarusuarios = "1";
            }
            if (lstdatos.GetItemChecked(6) == true)
            {
                oEmpleado.Gestionarroles = "1";
            }
            if (lstdatos.GetItemChecked(7) == true)
            {
                oEmpleado.Crearproyectos = "1";
            }
            if (lstdatos.GetItemChecked(8) == true)
            {
                oEmpleado.Compartirproyectos = "1";
            }

            /*PERMISOS NO CHECADOS*/
            if (lstdatos.GetItemChecked(0) == false)
            {
                oEmpleado.Soloverproyectos = "0";
            }
            if (lstdatos.GetItemChecked(1) == false)
            {
                oEmpleado.Verproyectosajenos = "0";
            }
            if (lstdatos.GetItemChecked(2) == false)
            {
                oEmpleado.Suspendercuenta = "0";
            }
            if (lstdatos.GetItemChecked(3) == false)
            {
                oEmpleado.Cambiarcredencial = "0";
            }
            if (lstdatos.GetItemChecked(4) == false)
            {
                oEmpleado.Crearevidencias = "0";
            }
            if (lstdatos.GetItemChecked(5) == false)
            {
                oEmpleado.Gestionarusuarios = "0";
            }
            if (lstdatos.GetItemChecked(6) == false)
            {
                oEmpleado.Gestionarroles = "0";
            }
            if (lstdatos.GetItemChecked(7) == false)
            {
                oEmpleado.Crearproyectos = "0";
            }
            if (lstdatos.GetItemChecked(8) == false)
            {
                oEmpleado.Compartirproyectos = "0";
            }

            oEmpleado.Descripcion = Roles.agregarrol.rolseleccionado;

                if (txtidpermiso.TextLength == 0)
                {
                    ///Estoy insertando un nuevo registro
                    if (oEmpleado.Guardar())
                    {
                        MessageBox.Show("Registro guardado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
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
                    oEmpleado.Idpermiso = txtidpermiso.Text;
                    if (oEmpleado.Actualizar())
                    {
                        MessageBox.Show("Registro actualizado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser actualizado", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            
        }



    }
}
