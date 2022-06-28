using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.proyectoscompartidos
{
    public partial class gestorproyectoscompartidos : Form
    {
        

        BindingSource __CLIENTES = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                __CLIENTES.DataSource = PROYECTOS_COMPARTIDOS_CONMIGO();

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

        public static DataTable PROYECTOS_COMPARTIDOS_CONMIGO()
        {
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String idusuarioactual = _SESION.OUsuario.Idusuario.ToString();

            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

//            Sentencia.Append(@"select pc.idproyectocompartido,pc.idproyecto,p.titulo as nombre_del_proyecto,
// pc         .idusuario as usuario_compartido,p.idusuario as usuario_original
//            from proyectoscompartidos pc, proyectos p, usuarios u
//            where pc.idproyecto = p.idproyecto and pc.idusuario = u.idusuario and u.idusuario = '" + idusuarioactual + "';");
            Sentencia.Append(@" select pc.idproyectocompartido,pc.idproyecto, p.titulo, p.descripcion, (select nombre from usuarios where idusuario = p.idusuario) as nombre_usuario_propietario, u.nombre
 from proyectoscompartidos pc, proyectos p, usuarios u
 where pc.idproyecto = p.idproyecto and u.idusuario = pc.idusuario and u.idusuario = '" + idusuarioactual + "';");

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

        private void FiltrarLocalmente()
        {
            try
            {
                if (txtfiltro.TextLength > 0)
                {
                    __CLIENTES.Filter = "nombre_del_proyecto LIKE '%" + txtfiltro.Text + "%'";
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

        public gestorproyectoscompartidos()
        {
            InitializeComponent();
        }

        private void gestorproyectoscompartidos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                       
                    }

        private void dtgvdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String idusuarioactual = _SESION.OUsuario.Idusuario.ToString();
            Reportes.Vista_Reportes.Reportes_sp un = new Reportes.Vista_Reportes.Reportes_sp(6, idusuarioactual);
            un.Show();
        }

                }
            }
        
    

