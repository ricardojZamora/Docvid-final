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
            if (txttitulo.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txttitulo, "Este campo no puede quedar vacio");
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
                General.CLS.proyectos oEmpleado = new General.CLS.proyectos();
                oEmpleado.Idproyecto = txtidproyecto.Text;
                oEmpleado.Titulo = txttitulo.Text;
                oEmpleado.Idusuario = txtidusuario.Text;
                oEmpleado.Descripcion = txtdescripcion.Text;


                if (txtidproyecto.TextLength == 0)
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
            //// para dar la fecha y hora
            //String hora = "Fecha:"+ DateTime.Today.ToString("dd-MM-yyyy")+ " \nHora:";
            // hora = hora +   DateTime.Now.ToString("HH:mm:ss");

            // MessageBox.Show(hora);
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
