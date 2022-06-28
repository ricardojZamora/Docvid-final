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
        public static String cadenadecustodiadocumentos;

        public void cambiarcadenaseleccionada(String a)
        {
            cadenadecustodiadocumentos = a;
        }

        public String cadenaseleccionada()
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

            return cadenadecustodiadocumentos;
        }

        BindingSource __CLIENTES = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                __CLIENTES.DataSource = CacheManager.SystemCache.TODAS_LAS_CADENAS_DE_CUSTODIA();

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
            CargarDatos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea editar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                agregarcadena f = new agregarcadena();
                f.txtidusuario.Text = dtgvdatos.CurrentRow.Cells["idusuario"].Value.ToString();
                f.txtnombre.Text = dtgvdatos.CurrentRow.Cells["Nombre"].Value.ToString();
                f.txtdescripcion.Text = dtgvdatos.CurrentRow.Cells["descripcion"].Value.ToString();
                f.txtidcadena.Text = dtgvdatos.CurrentRow.Cells["idcadena"].Value.ToString();


                f.ShowDialog();

                CargarDatos();
            }
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtgvdatos_DoubleClick(object sender, EventArgs e)
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

                        cadenadecustodiadocumentos = dtgvdatos.CurrentRow.Cells["idcadena"].Value.ToString();
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

                        cadenadecustodiadocumentos = dtgvdatos.CurrentRow.Cells["idcadena"].Value.ToString();
                        f.ShowDialog();

                        CargarDatos();
                        break;
                    }



                    Close();
                    break;
                }
            }
        }
    }
}
