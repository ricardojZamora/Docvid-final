using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.Roles
{
    public partial class gestionarol : Form
    {

        BindingSource __CLIENTES = new BindingSource();



        public gestionarol()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            agregarrol a = new agregarrol();
            a.ShowDialog();
            CargarDatos();
        }


        private void CargarDatos()
        {

            // Verifica que el form de gestion de usuarios este abierto
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Gestores.Usuarios.agregarusuario))
                {
                    MessageBox.Show("Haga doble click en el registro que desea agregar");
                    break;
                }
            }
            // fin del proceso de verificar datos

            try
            {
                __CLIENTES.DataSource = CacheManager.SystemCache.TODOS_LOS_ROLES();

                //pendiente
                //   FiltrarLocalmente();

                if (txtfiltro.TextLength > 0)
                {
                    __CLIENTES.Filter = "Nombre LIKE '%" + txtfiltro.Text;
                }
                else
                {
                    __CLIENTES.RemoveFilter();
                }
                dtgvdatos.AutoGenerateColumns = false;
                dtgvdatos.DataSource = __CLIENTES;
                lblestado.Text = dtgvdatos.Rows.Count.ToString() + "Registors Encontrados";
            }
            catch
            {

            }
            // dtgvdatos.AutoGenerateColumns = false;
            dtgvdatos.DataSource = __CLIENTES;
            // lblRegistros.Text = dtgvdatos.Rows.Count.ToString() + " Registors Encontrados";

        }


        private void FiltrarLocalmente()
        {
            try
            {
                if (txtfiltro.TextLength > 0)
                {
                    __CLIENTES.Filter = "descripcion LIKE '" + txtfiltro.Text + "%'";
                }
                else
                {
                    __CLIENTES.RemoveFilter();
                }
                dtgvdatos.AutoGenerateColumns = false;
                dtgvdatos.DataSource = __CLIENTES; 
                lblestado.Text = dtgvdatos.Rows.Count.ToString() + " Registros";
            }
            catch
            {

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            if (dtgvdatos.CurrentRow.Cells["idrol"].Value.ToString()=="1")
            {
                MessageBox.Show("No se puede gestionar este rol");
            }
            else
            {
                if (MessageBox.Show("Realmente desea editar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agregarrol f = new agregarrol();
                    f.txtid.Text = dtgvdatos.CurrentRow.Cells["idrol"].Value.ToString();
                    f.txtdescripcion.Text = dtgvdatos.CurrentRow.Cells["descripcion"].Value.ToString();
                    f.ShowDialog();

                    CargarDatos();
                }
            }

            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            if (dtgvdatos.CurrentRow.Cells["idrol"].Value.ToString() == "1")
            {
                MessageBox.Show("No se puede eliminar el rol administrador del programa, es parte esencial del mismo");
            }
            else
            {
                if (MessageBox.Show("Realmente desea eliminar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    General.CLS.Roles oEmpleado = new General.CLS.Roles();
                    oEmpleado.Idrol = dtgvdatos.CurrentRow.Cells["idrol"].Value.ToString();
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

        private void gestionarol_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgvdatos_DoubleClick(object sender, EventArgs e)
        {
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

        private void dtgvdatos_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnpermisos_Click(object sender, EventArgs e)
        {
            //permisos.gestionpermisos a = new permisos.gestionpermisos();
            //a.ShowDialog();
            Docvid.GUI.Gestores.permisos.listadepermisos f = new Docvid.GUI.Gestores.permisos.listadepermisos();
            f.txtidpermiso.Text = dtgvdatos.CurrentRow.Cells["idpermiso"].Value.ToString();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Vista_Reportes.Reportes_sp un = new Reportes.Vista_Reportes.Reportes_sp(9,"123");
            un.Show();

        }

    }
}
