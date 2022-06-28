using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.compartirproyectos
{
    public partial class gestionarcompartir : Form
    {
        DataTable Resultadopermisos = new DataTable();
        DataTable Resultadoexisteelproyectocompartir = new DataTable();
        

        public gestionarcompartir()
        {
            InitializeComponent();
        }
        BindingSource __CLIENTES = new BindingSource();

        // para encontrar proyectos sin abrirlos 
        public static Boolean buscandoproyecto = false;
        public static Boolean buscandousuario = false;


        public static Boolean estadobuscandoproyecto()
        {
            return buscandoproyecto;
        }
        public static Boolean estadobuscandousuario()
        {
            return buscandousuario;
        }


        public static DataTable PROYECTOS_COMPARTIDOS()
        {
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String idusuarioactual = _SESION.OUsuario.Idusuario.ToString();

            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

//            Sentencia.Append(@"select pc.idproyectocompartido,pc.idproyecto,p.titulo as nombre_del_proyecto,
// pc.idusuario as usuario_compartido,p.idusuario as usuario_original
// from proyectoscompartidos pc, proyectos p, usuarios u
// where pc.idproyecto = p.idproyecto and pc.idusuario = u.idusuario and p.idusuario =  '" + idusuarioactual + "';");

            Sentencia.Append(@" select pc.idproyectocompartido, p.idproyecto, p.titulo, p.descripcion, (select nombre from usuarios where idusuario = pc.idusuario) as usuario_compartido, u.nombre as usuario_propietario
 from usuarios u, proyectos p, proyectoscompartidos pc
 where u.idusuario = p.idusuario and pc.idproyecto = p.idproyecto and u.idusuario ='" + idusuarioactual + "';");

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
                __CLIENTES.DataSource = PROYECTOS_COMPARTIDOS();

            }
            catch
            {

            }
            // dtgvdatos.AutoGenerateColumns = false;
            dtgvdatos.DataSource = __CLIENTES;
            lblestado.Text = " Registros encontrados: " + dtgvdatos.Rows.Count.ToString();


        }


        private void gestionarcompartir_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtfiltro.TextLength > 0)
                {
                    __CLIENTES.Filter = "titulo LIKE '%" + txtfiltro.Text + "%' or descripcion LIKE '%" + txtfiltro.Text + "%'";
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


        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvdatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GUI.Gestores.Documentos.gestiondocumentos f = new GUI.Gestores.Documentos.gestiondocumentos();
                GUI.Gestores.Cadenasdecustodias.gestioncadenas a = new Cadenasdecustodias.gestioncadenas();
                a.cambiarproyectoseleccionado(dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString());
                f.ShowDialog();

                CargarDatos();
            }
            catch
            {
                MessageBox.Show("Error al abrir el proyecto");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscandousuario = true;
            Usuarios.gestionarusuario a = new Usuarios.gestionarusuario();
            a.ShowDialog();
            txtidusuario.Text =  a.dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString();
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            informaciondeusuarioactual();
            
            if(Resultadopermisos.Rows[0]["verproyectosajenos"].ToString() == "1")
            {
                buscandoproyecto = true;
                Gestores.Cadenasdecustodias.gestioncadenas a = new Cadenasdecustodias.gestioncadenas();
                a.ShowDialog();
                txtproyecto.Text = a.dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString();
                CargarDatos();
            }
            else
            {
                buscandoproyecto = true;
                Rol2.cadenadecustodia.proyectos a = new Rol2.cadenadecustodia.proyectos();
                a.ShowDialog();
                try
                {
                    txtproyecto.Text = a.dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString();

                }
                catch
                {

                }
                CargarDatos();
            }

           
        }

        void informaciondeusuarioactual()
        {
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String rolactual = _SESION.OUsuario.Idrol.ToString();
            

            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select verproyectosajenos from permisos where idrol ='" + rolactual + "';");
            try
            {
                Resultadopermisos = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultadopermisos = new DataTable();
            }
        }

        void informaciondeexisteelproyectocompartido()
        {
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            //SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            //String rolactual = _SESION.OUsuario.Idusuario.ToString();


            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select idproyecto, idusuario from proyectoscompartidos where idusuario ='" + txtidusuario.Text + "';");
            try
            {
                Resultadoexisteelproyectocompartir = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultadoexisteelproyectocompartir = new DataTable();
            }
        }

        private void gestionarcompartir_FormClosed(object sender, FormClosedEventArgs e)
        {
            buscandoproyecto = false;
            buscandousuario = false;
        }

        // METODOS PARA AGREGAR
        private Boolean Verificacion()///verificando que eñ campo nombre no este vacio
        {
            Boolean Verificado = true;
            Notificador.Clear();
            if (txtidusuario.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtidusuario, "Este campo no puede quedar vacio");
            }
            if (txtproyecto.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtproyecto, "Este campo no puede quedar vacio");
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
                General.CLS.proyectoscompartidos oEmpleado = new General.CLS.proyectoscompartidos();
                oEmpleado.Idproyecto = txtproyecto.Text;
                oEmpleado.Idusuario = txtidusuario.Text;

                
                if (txtidproyectocompartido.TextLength == 0)
                {
                    ///Estoy insertando un nuevo registro
                    if (oEmpleado.Guardar())
                    {
                        MessageBox.Show("Registro guardado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
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
                    oEmpleado.Idproyectocompartido = txtidproyectocompartido.Text;
                    if (oEmpleado.Actualizar())
                    {
                        MessageBox.Show("Registro actualizado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser actualizado", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        //clicl boton agregar
        private void button3_Click(object sender, EventArgs e)
        {
            //intentara ejecutar la consulta por si el archivo existe en el mismo usuario compartido, sino, guardara el registro
            // diciendo que no existe el documento con el mismo usuario compartido
            try
            {
                informaciondeexisteelproyectocompartido();
                if (Resultadoexisteelproyectocompartir.Rows[0]["idusuario"].ToString() == txtidusuario.Text && Resultadoexisteelproyectocompartir.Rows[0]["idproyecto"].ToString() == txtproyecto.Text)
                {
                    MessageBox.Show("El proyecto: " + txtproyecto.Text + " con el usuario: " + txtidusuario.Text + " ya esta compartido anteriormenre");
                }
                else
                {
                    Procesar();
                    CargarDatos();
                }
            }
            catch
            {
                Procesar();
                CargarDatos();
            }
            
            
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea editar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                txtidproyectocompartido.Text = dtgvdatos.CurrentRow.Cells["idproyectocompartido"].Value.ToString();
                txtidusuario.Text = dtgvdatos.CurrentRow.Cells["usuariocompartido"].Value.ToString();
                txtproyecto.Text = dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString();

                CargarDatos();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
           
                DialogResult result = MessageBox.Show("Realmente desea eliminar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    General.CLS.proyectoscompartidos oEmpleado = new General.CLS.proyectoscompartidos();
                    oEmpleado.Idproyectocompartido = dtgvdatos.CurrentRow.Cells["idproyectocompartido"].Value.ToString();
                    if (oEmpleado.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado satisfactoriamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el registro");
                        CargarDatos();
                    }
                }
            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String idusuarioactual = _SESION.OUsuario.Idusuario.ToString();
            Reportes.Vista_Reportes.Reportes_sp un = new Reportes.Vista_Reportes.Reportes_sp(5,idusuarioactual);
            un.Show();
        }
    }
}
