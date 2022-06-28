using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Rol2.cadenadecustodia
{
    public partial class cadenadecustodia : Form
    {

        BindingSource __CLIENTES = new BindingSource();

       

        //variable para consultar que documentos de que cadena de custodia abrir

       // public static String cadenadecustodiadocumentos;

        public void cadenaseleccionada()
        {
            GUI.Gestores.Cadenasdecustodias.gestioncadenas variable = new GUI.Gestores.Cadenasdecustodias.gestioncadenas();
            variable.cambiarcadenaseleccionada(dtgvdatos.CurrentRow.Cells["idcadena"].Value.ToString()); 

        }


        //consultando las cadenas
        public static DataTable MI_CADENA_DE_CUSTODIA()
        {
            //mi id para saber las cadenas de custodias que tengo
            // accedemos al id del usuario actual
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String idusuarioactual = _SESION.OUsuario.Idusuario.ToString();

            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@" select  c.idcadenadecustodia, c.nombre, c.descripcion, c.idusuario, u.nombre, c.Cantidad_de_docs
 from cadenasdecustodias c, usuarios u
 where c.idusuario = u.idusuario and u.idusuario = '" + idusuarioactual + "';");
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
                __CLIENTES.DataSource = MI_CADENA_DE_CUSTODIA();

            }
            catch
            {

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

        public cadenadecustodia()
        {
            InitializeComponent();
        }

        private void cadenadecustodia_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Gestores.Cadenasdecustodias.agregarcadena a = new Gestores.Cadenasdecustodias.agregarcadena();
            a.ShowDialog();
            CargarDatos();
        }

        private void dtgvdatos_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvdatos.Rows.Count > 0 && dtgvdatos.Rows != null)
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

                            cadenaseleccionada();
                            f.ShowDialog();

                            CargarDatos();
                            break;
                        }



                        Close();
                        break;
                    }
                }

                //la siguiente es llave del if
            }
            else { MessageBox.Show("La lista esta vacia"); }

           
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Gestores.Cadenasdecustodias.agregarcadena f = new Gestores.Cadenasdecustodias.agregarcadena();

            f.txtidusuario.Text = dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString();
            f.txtnombre.Text = dtgvdatos.CurrentRow.Cells["Nombre"].Value.ToString();
            f.txtdescripcion.Text = dtgvdatos.CurrentRow.Cells["descripcion"].Value.ToString();
            f.txtidcadena.Text = dtgvdatos.CurrentRow.Cells["idcadena"].Value.ToString();


            f.ShowDialog();

            f.ShowDialog();
            CargarDatos();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro seleccionado? se eliminaran los archivos relacionados a esa cadena de custodia", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                General.CLS.Cadenasdecustodias oEmpleado = new General.CLS.Cadenasdecustodias();
                oEmpleado.Idcadenadecustodia = dtgvdatos.CurrentRow.Cells["idcadena"].Value.ToString();
                if (oEmpleado.Eliminar())
                {
                    MessageBox.Show("Registro eliminado satisfactoriamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado ", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
            }
        }
    }
}
