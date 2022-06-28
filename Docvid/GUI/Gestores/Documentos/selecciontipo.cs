using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.Documentos
{
    public partial class selecciontipo : Form
    {


        public static DataTable TODOS_LOS_PROYECTOS_PERSONALES()
        {

            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;

            Sentencia.Append(@" select * from tiposdeevidencias;");
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

            __CLIENTES.DataSource = TODOS_LOS_PROYECTOS_PERSONALES();

            // dtgvdatos.AutoGenerateColumns = false;
            dtgvdatos.DataSource = __CLIENTES;

        }

        private void FiltrarLocalmente()
        {
            try
            {
                if (txtfiltro.TextLength > 0)
                {
                    __CLIENTES.Filter = "tipo LIKE '%" + txtfiltro.Text + "%' or caracteristica LIKE '%" + txtfiltro.Text + "%'";
                }
                else
                {
                    __CLIENTES.RemoveFilter();
                }
                dtgvdatos.AutoGenerateColumns = false;
                dtgvdatos.DataSource = __CLIENTES;
            }
            catch
            {

            }
        }
        public selecciontipo()
        {
            InitializeComponent();
        }

        private void dtgvdatos_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void selecciontipo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
