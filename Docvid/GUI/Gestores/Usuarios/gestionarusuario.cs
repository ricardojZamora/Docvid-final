using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.Usuarios
{
    public partial class gestionarusuario : Form
    {
        DataTable Resultadopermisos = new DataTable();

        BindingSource __CLIENTES = new BindingSource();
        private void CargarDatos()
        {
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
            lblestado.Text = " Registros encontrados: " + dtgvdatos.Rows.Count.ToString();

            // lblRegistros.Text = dtgvdatos.Rows.Count.ToString() + " Registors Encontrados";

        }

        //funcion de filtro de la caja de texto
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtfiltro.TextLength > 0)
                {
                    __CLIENTES.Filter = "nombre LIKE '" + txtfiltro.Text + "%'";
                }
                else
                {
                    __CLIENTES.RemoveFilter();
                }
                dtgvdatos.AutoGenerateColumns = false;
                dtgvdatos.DataSource = __CLIENTES;
                lblestado.Text = " Registros encontrados: " + dtgvdatos.Rows.Count.ToString();
            }
            catch
            {

            }
        }



        public gestionarusuario()
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

            Sentencia.Append(@"select * from permisos where idrol ='" + rolactual + "';");
            try
            {
                Resultadopermisos = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultadopermisos = new DataTable();
            }
        }
        void verificarpermisos()
        {
            informaciondeusuarioactual();
            if (Resultadopermisos.Rows[0]["gestionarusuarios"].ToString() == "0")
            {
                btnagregar.Visible = false;
                btnactsus.Visible = false;
                btnmodificar.Visible = false;
                btneliminar.Visible = false;
            }
        }

        private void gestionarusuario_Load(object sender, EventArgs e)
        {
            verificarpermisos();
            CargarDatos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            agregarusuario a = new agregarusuario();
            a.ShowDialog();
            CargarDatos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea editar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                agregarusuario f = new agregarusuario();
                f.txtidusuarioo.Text = dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString();
                f.txtnombreusuario.Text = dtgvdatos.CurrentRow.Cells["nombre"].Value.ToString();
                f.txtidrolss.Text = dtgvdatos.CurrentRow.Cells["idrol"].Value.ToString();
                f.txttelefono.Text = dtgvdatos.CurrentRow.Cells["telefono"].Value.ToString();

                if (dtgvdatos.CurrentRow.Cells["estadonv"].Value.ToString() == "1")
                {
                    f.rddactivo.Checked = true;
                }
                else
                {
                    f.rddsuspendido.Checked = true;
                }

                f.ShowDialog();

                CargarDatos();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //verificar que no se quiera autoeliminar el usuario

            // accedemos al id del usuario actual
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;

            //comprobamos el id del usuario seleccionado
            if(dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString() == _SESION.OUsuario.Idusuario.ToString())
            {
                MessageBox.Show("Este usuario lo esta utilizando actualmente");
            }
            else
            {
                DialogResult result = MessageBox.Show("Realmente desea eliminar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if ( result == DialogResult.Yes)
                {
                   
                    General.CLS.Usuarios oEmpleado = new General.CLS.Usuarios();
                    oEmpleado.Idusuario = dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString();
                    if (oEmpleado.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado satisfactoriamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        DialogResult result2 = MessageBox.Show("El registro tiene archivos creados, desea pasarlos a su id de usuario actual los archivos de este usuario?", "pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if ( result2 == DialogResult.Yes)
                        {
                            
                                intercambiardatos();

                            oEmpleado.Idusuario = dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString();
                            if (oEmpleado.Eliminar())
                            {
                                MessageBox.Show("Operacion realizada");
                            }
                            else
                            {
                                MessageBox.Show("Operacion fallida al eliminar");
                            }
                        }
                        else if (result2 == DialogResult.No)
                        {
                            eliminarcascadausuario();
                        }
                        else if (result2 == DialogResult.Cancel)
                        {

                        }
                        
                        
                        
                        CargarDatos();
                    }
                }
            }

          
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        // funcion para hacer los documentos que pasen a otro usuario y no eliminarlos
        private void intercambiardatos()
        {
            SessionManager.CLS.Sesion _SESIONES = SessionManager.CLS.Sesion.Instancia;
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            String usuarioactuall = _SESIONES.OUsuario.Idusuario.ToString();
            String usuarioseleccionadoo = dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString();
           // Sentencia.Append("update idusuario set'" + _SESION.OUsuario.Idusuario.ToString() + "' from cadenasdecustodias where idusuario = '" + dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString() + "';");
            Sentencia.Append("update cadenasdecustodias set idusuario = '"+usuarioactuall+ "' where idusuario ='"+usuarioseleccionadoo+"';");
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
            }
            catch
            {
                Guardado = false;
                MessageBox.Show("No se puede hacer el intercambio de archivos");
            }
        }

        private void activardesactivarusuario()
        {
            SessionManager.CLS.Sesion _SESIONES = SessionManager.CLS.Sesion.Instancia;
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            String usuarioactuall = _SESIONES.OUsuario.Idusuario.ToString();
            String estadoactualseleccionado = dtgvdatos.CurrentRow.Cells["estadonv"].Value.ToString();
            String usuarioseleccionado = dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString();

            if(usuarioactuall == usuarioseleccionado)
            {
                MessageBox.Show("Este usuario no se puede desactivar por que es el administrador del programa");
            }

            else 
            {
            if(estadoactualseleccionado == "1")
            {
                // Sentencia.Append("update idusuario set'" + _SESION.OUsuario.Idusuario.ToString() + "' from cadenasdecustodias where idusuario = '" + dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString() + "';");
                Sentencia.Append("update usuarios set estado = 0 where idusuario ='" + usuarioseleccionado + "';");
            }
            else
            {
                Sentencia.Append("update usuarios set estado = 1 where idusuario ='" + usuarioseleccionado + "';");
            }

            
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
            }
            catch
            {
                Guardado = false;
                MessageBox.Show("No se puede activar o desactivar el usuario");
            }
            }

           
        }

        private void eliminarcascadausuario()
        {
            //SessionManager.CLS.Sesion _SESIONES = SessionManager.CLS.Sesion.Instancia;
            //Boolean Guardado = false;
            //StringBuilder Sentencia = new StringBuilder();
            //String usuarioactuall = _SESIONES.OUsuario.Idusuario.ToString();
            //String usuarioseleccionadoo = dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString();
            //// Sentencia.Append("update idusuario set'" + _SESION.OUsuario.Idusuario.ToString() + "' from cadenasdecustodias where idusuario = '" + dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString() + "';");
            //Sentencia.Append("delete * from documentos where ");
            //DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();

            //try
            //{
            //    if (oOperacion.Insertar(Sentencia.ToString()) > 0)
            //    {
            //        Guardado = true;
            //    }
            //    else
            //    {
            //        Guardado = false;
            //    }
            //}
            //catch
            //{
            //    Guardado = false;
            //    MessageBox.Show("No se puede hacer el intercambio de archivos");
            //}

            MessageBox.Show("Elimine los archivos y cadenas de custodias creadas por el id de usuario "+ dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString()+"");


        }

        //boton de activar suspender
        private void btnactsus_Click(object sender, EventArgs e)
        {
            activardesactivarusuario();
            CargarDatos();
        }

        private void dtgvdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (compartirproyectos.gestionarcompartir.buscandousuario)
            {

                Close();
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Vista_Reportes.Reportes_sp un = new Reportes.Vista_Reportes.Reportes_sp(7, "1");
            un.Show();
        }


    }
}
