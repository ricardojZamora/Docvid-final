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
    public partial class gestionpermisos : Form
    {

        BindingSource __CLIENTES = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                __CLIENTES.DataSource = PERMISOS();

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
        public static Boolean agregar = false;

        public static Boolean getagregar()
        {
            return agregar;
        }

        public static DataTable PERMISOS()
        {
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String idusuarioactual = _SESION.OUsuario.Idusuario.ToString();

            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select p.idpermiso, r.descripcion, p.idrol
            from permisos p, roles r
            where p.idrol = r.idrol;");
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

        public gestionpermisos()
        {
            InitializeComponent();
        }

        private void gestionpermisos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            listadepermisos f = new listadepermisos();
            f.txtidpermiso.Text = dtgvdatos.CurrentRow.Cells["idpermiso"].Value.ToString();
            f.ShowDialog();

            CargarDatos();
        }

        private void gestionpermisos_FormClosed(object sender, FormClosedEventArgs e)
        {
            agregar = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            agregar = true;
            listadepermisos a = new listadepermisos();
            a.ShowDialog();
            CargarDatos();
        }
    }
}
