using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Rol2.cuenta
{
    public partial class cambiocontrasenia : Form
    {

        BindingSource __CLIENTES = new BindingSource();
        SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;

        public cambiocontrasenia()
        {
            InitializeComponent();
        }

        void validar()
        {
            DataTable DatosUsuario = new DataTable();
            try
            {
                String usuarioactual = _SESION.OUsuario.Nombre.ToString();
                DatosUsuario = CacheManager.SystemCache.ValidarUsuario(usuarioactual, txtcontraseniaactual.Text);

                if (DatosUsuario.Rows.Count == 1)
                {
                    // mira si el estado del usuario es 0 (suspendido) o 1 (activo)
                    _SESION.OUsuario.Estado = DatosUsuario.Rows[0]["estado"].ToString();
                    if (txtnuevacontrasenia.Text == txtrepenuevacontra.Text)
                    {
                        //Actualizar datos de contrasenia
                        General.CLS.Usuarios oEmpleado = new General.CLS.Usuarios();

                        oEmpleado.Credencial = txtnuevacontrasenia.Text;
                        oEmpleado.Idusuario = _SESION.OUsuario.Idusuario.ToString();
                        oEmpleado.Idrol = _SESION.OUsuario.Idrol.ToString();

                        if (oEmpleado.ActualizarContrasenia())
                        {
                            MessageBox.Show("Registro actualizado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser actualizado", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Las contraseña nueva no la ha escrito igual en las dos cajas");
                    }

                }
                else //si no se encuentra el usuario en la base de datos
                {
                    MessageBox.Show("Contraseña actual incorrecta");

                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validar();
        }
    }
}
