using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.Auditores
{
    public partial class gestionauditores : Form
    {

        BindingSource __CLIENTES = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                __CLIENTES.DataSource = CacheManager.SystemCache.TODOS_LOS_AUDITORES();
              
                //pendiente
                //   FiltrarLocalmente();

                // Verifica que el form de gestion de usuarios este abierto
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Gestores.Usuarios.agregarusuario))
                    {
                        MessageBox.Show("Haga doble click en el registro que desea agregar");
                        break;
                    }
                }

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
                    __CLIENTES.Filter = "nombre LIKE '" + txtfiltro.Text + "%'" ;
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



        public gestionauditores()
        {
            InitializeComponent();
        }

        private void gestionauditores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        //boton agregar auditor
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            agregarauditor a = new agregarauditor();
            a.ShowDialog();
            CargarDatos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea editar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                agregarauditor f = new agregarauditor();
                f.txtid.Text = dtgvdatos.CurrentRow.Cells["idauditor"].Value.ToString();
                f.txtnombre.Text = dtgvdatos.CurrentRow.Cells["nombre"].Value.ToString();
                f.txttelefono.Text = dtgvdatos.CurrentRow.Cells["telefono"].Value.ToString();
                f.txtdireccion.Text = dtgvdatos.CurrentRow.Cells["direccion"].Value.ToString();
                f.txtcorreo.Text = dtgvdatos.CurrentRow.Cells["correo"].Value.ToString();
               

                f.ShowDialog();

                CargarDatos();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                General.CLS.Auditores oEmpleado = new General.CLS.Auditores();
                oEmpleado.Idauditor = dtgvdatos.CurrentRow.Cells["idauditor"].Value.ToString();
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

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgvdatos_DoubleClick(object sender, EventArgs e)
        {
            Gestores.Auditores.gestionauditores f = new Gestores.Auditores.gestionauditores();
            

            // Verifica que el form de gestion de usuarios este abierto

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Gestores.Usuarios.agregarusuario))
                {
                    Close();
                    break;
                }
            }

        }
    }
}
