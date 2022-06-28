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
    public partial class agregarcadena : Form
    {
        // ver el id del usuario para cargarlo
        SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;

        public agregarcadena()
        {
            InitializeComponent();
        }

        private Boolean Verificacion()///verificando que eñ campo nombre no este vacio
        {
            Boolean Verificado = true;
            Notificador.Clear();
            if (txtdescripcion.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtdescripcion, "Este campo no puede quedar vacio");
            }
            if (txtidusuario.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtidusuario, "Este campo no puede quedar vacio");
            }
            if (txtnombre.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtnombre, "Este campo no puede quedar vacio");
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
                General.CLS.Cadenasdecustodias oEmpleado = new General.CLS.Cadenasdecustodias();
                oEmpleado.Idcadenadecustodia = txtidcadena.Text;
                oEmpleado.Nombre = txtnombre.Text;
                oEmpleado.Idusuario = txtidusuario.Text;
                oEmpleado.Descripcion = txtdescripcion.Text;


                if (txtidcadena.TextLength == 0)
                {
                    ///Estoy insertando un nuevo registro
                    if (oEmpleado.Guardar())
                    {
                        MessageBox.Show("Registro guardado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
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
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser actualizado", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarcadena_Load(object sender, EventArgs e)
        {

            txtidusuario.Text = _SESION.OUsuario.Idusuario.ToString();
        }
    }
}
