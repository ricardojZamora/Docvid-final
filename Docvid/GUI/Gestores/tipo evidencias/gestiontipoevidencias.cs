using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.tipo_evidencias
{
    public partial class gestiontipoevidencias : Form
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
            lblestado.Text = " Registros encontrados: " + dtgvdatos.Rows.Count.ToString();

        }


        private Boolean Verificacion()///verificando que eñ campo nombre no este vacio
        {
            Boolean Verificado = true;
            Notificador.Clear();
            //if (txtcaracteristica.TextLength <= 0)
            //{
            //    Verificado = false;
            //    Notificador.SetError(txtcaracteristica, "Este campo no puede quedar vacio");
            //}
            if (txtextension.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtextension, "Este campo no puede quedar vacio");
            }
            if (txtformato.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtformato, "Este campo no puede quedar vacio");
            }

            if (txttipo.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txttipo, "Este campo no puede quedar vacio");
            }
            return Verificado;

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
                lblestado.Text = " Registros encontrados: " + dtgvdatos.Rows.Count.ToString();
            }
            catch
            {

            }
        }


        private void Procesar()
        {
            if (Verificacion())
            {
                General.CLS.tiposdeevidencias oEmpleado = new General.CLS.tiposdeevidencias();
                oEmpleado.Idtipoevidencia = txtid.Text;
                oEmpleado.Tipo = txttipo.Text;
                oEmpleado.Formato = txtformato.Text;
                oEmpleado.Caracteristica = txtcaracteristica.Text;
                oEmpleado.Extension = txtextension.Text;

                if (txtid.TextLength == 0)
                {
                    ///Estoy insertando un nuevo registro
                    if (oEmpleado.Guardar())
                    {
                        MessageBox.Show("Registro guardado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Close();
                        limpiarcajas();
                        CargarDatos();
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
                    if (oEmpleado.Actualizar())
                    {
                        MessageBox.Show("Registro actualizado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Close();
                        limpiarcajas();
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser actualizado", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void limpiarcajas()
        {
            txtid.Text = "";
            txttipo.Text = "";
            txtformato.Text = "";
            txtextension.Text = "";
            txtcaracteristica.Text = "";
            btnagregar.Text = "Agregar";
        }

        public gestiontipoevidencias()
        {
            InitializeComponent();
        }

        private void gestiontipoevidencias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro seleccionado? ", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                General.CLS.tiposdeevidencias oEmpleado = new General.CLS.tiposdeevidencias();
                oEmpleado.Idtipoevidencia = dtgvdatos.CurrentRow.Cells["idtipoevidencia"].Value.ToString();
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtid.Text = dtgvdatos.CurrentRow.Cells["idtipoevidencia"].Value.ToString();
            txttipo.Text = dtgvdatos.CurrentRow.Cells["tipo"].Value.ToString();
            txtformato.Text = dtgvdatos.CurrentRow.Cells["formato"].Value.ToString();
            txtextension.Text = dtgvdatos.CurrentRow.Cells["extension"].Value.ToString();
            txtcaracteristica.Text = dtgvdatos.CurrentRow.Cells["caracteristica"].Value.ToString();
            btnagregar.Text = "Modificar";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Vista_Reportes.Reportes_sp un = new Reportes.Vista_Reportes.Reportes_sp(8,"123");
            un.Show();

        }
    }
}
