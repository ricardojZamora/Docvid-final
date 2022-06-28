using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.Cadenasdecustodias
{
    public partial class gestioncadenas : Form
    {
        //variable para consultar que documentos de que cadena de custodia abrir
        public static String proyectoseleccionado;
        DataTable permisosusuario = new DataTable();
        

        private void consultarpermisosusuario()
        {
            SessionManager.CLS.Sesion a = SessionManager.CLS.Sesion.Instancia;
            DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
            permisosusuario = operacion.Consultar("select * from permisos where idrol = '"+a.OUsuario.Idrol+"';");
             if( permisosusuario.Rows[0]["verproyectosajenos"].ToString() == "1")
           // if (chsolomisproyectos.Checked == false)
            {
                __CLIENTES.DataSource = CacheManager.SystemCache.TODOS_LOS_PROYECTOS();
                chsolomisproyectos.Visible = true;
                chsolomisproyectos.Checked = true;
            }
            else
            {
                __CLIENTES.DataSource = TODOS_LOS_PROYECTOS_PERSONALES();
                chsolomisproyectos.Visible = false;
                chsolomisproyectos.Checked = true;
            }


            // dtgvdatos.AutoGenerateColumns = false;
            dtgvdatos.DataSource = __CLIENTES;
            lblestado.Text = " Registros encontrados: " + dtgvdatos.Rows.Count.ToString();


        }

        public void cambiarproyectoseleccionado(String a)
        {
            proyectoseleccionado = a;
        }

        public String getproyectoseleccion()
        {

            //if (frm.GetType() == typeof(Gestores.Documentos.agregardocumento))
            //{
            //    Close();
            //    break;
            //}
            //else
            //{
            //    GUI.Gestores.Documentos.gestiondocumentos f = new GUI.Gestores.Documentos.gestiondocumentos();

            //    cadenadecustodiadocumentos = dtgvdatos.CurrentRow.Cells["idcadena"].Value.ToString();
            //    f.ShowDialog();

            //    CargarDatos();
            //    break;
            //}

            return proyectoseleccionado;
        }

        public static DataTable TODOS_LOS_PROYECTOS_PERSONALES()
        {

            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;

            Sentencia.Append(@" select p.* , u.nombre as nombre_usuario
 from usuarios u, proyectos p
 where u.idusuario = p.idusuario and p.idusuario = '" + sesion.OUsuario.Idusuario + "';");
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


        BindingSource __CLIENTES = new BindingSource();

        private void CargarDatos()
        {
            consultarpermisosusuario();

              // if( permisosusuario.Rows[0]["verproyectosajenos"].ToString() == "1")
            if( chsolomisproyectos.Checked == false)
               {
                   __CLIENTES.DataSource = CacheManager.SystemCache.TODOS_LOS_PROYECTOS();
               }
               else
               {
                   __CLIENTES.DataSource = TODOS_LOS_PROYECTOS_PERSONALES();
                 //  chsolomisproyectos.Visible = false;
               }

            
            // dtgvdatos.AutoGenerateColumns = false;
            dtgvdatos.DataSource = __CLIENTES;
            lblestado.Text = " Registros encontrados: " + dtgvdatos.Rows.Count.ToString();


        }

        private void consultarcheckverproyectosajenos()
        {
             // if( permisosusuario.Rows[0]["verproyectosajenos"].ToString() == "1")
            if( chsolomisproyectos.Checked == false)
               {
                   __CLIENTES.DataSource = CacheManager.SystemCache.TODOS_LOS_PROYECTOS();
               }
               else
               {
                   __CLIENTES.DataSource = TODOS_LOS_PROYECTOS_PERSONALES();
                  // chsolomisproyectos.Visible = false;
               }

            
            // dtgvdatos.AutoGenerateColumns = false;
            dtgvdatos.DataSource = __CLIENTES;
            lblestado.Text = " Registros encontrados: " + dtgvdatos.Rows.Count.ToString();

        }

        //funcion de filtro de la caja de texto
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtfiltro.TextLength > 0)
                {
                    __CLIENTES.Filter = "titulo LIKE '%" + txtfiltro.Text + "%' or descripcion LIKE '%" + txtfiltro.Text + "%' or nombre_usuario LIKE '%" + txtfiltro.Text + "%'";
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

        public gestioncadenas()
        {
            InitializeComponent();

        }

        private void gestioncadenas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Gestores.Cadenasdecustodias.agregarcadena a = new agregarcadena();
            a.ShowDialog();
            consultarcheckverproyectosajenos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea editar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                agregarcadena f = new agregarcadena();
                f.txtidusuario.Text = dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString();
                f.txttitulo.Text = dtgvdatos.CurrentRow.Cells["titulo"].Value.ToString();
                f.txtdescripcion.Text = dtgvdatos.CurrentRow.Cells["descripcion"].Value.ToString();
                f.txtidproyecto.Text = dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString();


                f.ShowDialog();

                consultarcheckverproyectosajenos();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro seleccionado? se eliminaran los archivos relacionados a esa cadena de custodia", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                General.CLS.proyectos oEmpleado = new General.CLS.proyectos();
                oEmpleado.Idproyecto = dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString();
                if (oEmpleado.Eliminar())
                {
                    MessageBox.Show("Registro eliminado satisfactoriamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    consultarcheckverproyectosajenos();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado ", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    consultarcheckverproyectosajenos();
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtgvdatos_DoubleClick(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                //if (frm.GetType() == typeof(Gestores.Documentos.agregardocumento))
                if (Gestores.compartirproyectos.gestionarcompartir.buscandoproyecto)
                {

                    Close();
                    break;
                }
                else
                {
                    //MessageBox.Show("No esta agregando");
                    // Verifica que el form de gestion de usuarios este abierto


                    if (frm.GetType() == typeof(Gestores.Documentos.agregardocumento))
                    {
                        Close();
                        break;
                    }
                    else
                    {
                        GUI.Gestores.Documentos.gestiondocumentos f = new GUI.Gestores.Documentos.gestiondocumentos();

                        proyectoseleccionado = dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString();
                        f.ShowDialog();

                        CargarDatos();
                        break;
                    }



                    Close();
                    break;
                }
            }


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvdatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                //if (frm.GetType() == typeof(Gestores.Documentos.agregardocumento))
                if (Gestores.Documentos.agregardocumento.buscando)
                {

                    Close();
                    break;
                }
                else
                {
                    //MessageBox.Show("No esta agregando");
                    // Verifica que el form de gestion de usuarios este abierto


                    if (frm.GetType() == typeof(Gestores.Documentos.agregardocumento))
                    {
                        Close();
                        break;
                    }
                    else
                    {
                        GUI.Gestores.Documentos.gestiondocumentos f = new GUI.Gestores.Documentos.gestiondocumentos();

                        proyectoseleccionado = dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString();
                        f.ShowDialog();

                        CargarDatos();
                        break;
                    }



                    Close();
                    break;
                }
            }
        }

        private void chsolomisproyectos_CheckedChanged(object sender, EventArgs e)
        {
            consultarcheckverproyectosajenos();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if(chsolomisproyectos.Checked == true){
                SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;
            Reportes.Vista_Reportes.Reportes_sp repor = new Reportes.Vista_Reportes.Reportes_sp(1, sesion.OUsuario.Idusuario);
            repor.Show();

            }else{
                Reportes.Vista_Reportes.Reportes_sp repor = new Reportes.Vista_Reportes.Reportes_sp(2, "No");
                repor.Show();
            }
            
        }


       

        
    }
}
