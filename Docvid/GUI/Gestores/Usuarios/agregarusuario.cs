using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.Usuarios
{
    public partial class agregarusuario : Form
    {

        DataTable usuarioexistente = new DataTable();
        void usuarioexiste()
        {

            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select * from usuarios where nombre = '"+txtnombreusuario.Text+"';'");
            try
            {
                usuarioexistente = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                usuarioexistente = new DataTable();
            }
        }




        private Boolean Verificacion()///verificando que eñ campo nombre no este vacio
        {
            Boolean Verificado = true;
            Notificador.Clear();
          
            if (txtidrol.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtidrolss, "Este campo no puede quedar vacio");
            }
            if (txtnombreusuario.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtnombreusuario, "Este campo no puede quedar vacio");
            }
            if (txtcredencial.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtcredencial, "Este campo no puede quedar vacio");
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
                General.CLS.Usuarios oEmpleado = new General.CLS.Usuarios();
                oEmpleado.Nombre = txtnombreusuario.Text;
                oEmpleado.Credencial = txtcredencial.Text;
                oEmpleado.Idrol = txtidrol.Text; 
                oEmpleado.Idusuario = txtidusuarioo.Text;
                oEmpleado.Telefono = txttelefono.Text;

                if (rddsuspendido.Checked)
                {
                    oEmpleado.Estado = "0";
                }
                else
                {
                    oEmpleado.Estado = "1";
                }

                if (txtidusuarioo.TextLength == 0)
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

        public agregarusuario()
        {
            InitializeComponent();
        }

        private void btnagregarrol_Click(object sender, EventArgs e)
        {
            if(txtidusuarioo.Text == "1")
            {
                btnagregarrol.Visible = false;
                MessageBox.Show("El rol del usuario anfitrion, no puede modificarse");
            }
            else
            {
                Roles.gestionarol f = new Roles.gestionarol();
                f.ShowDialog();
                txtidrol.Text = f.dtgvdatos.CurrentRow.Cells["idrol"].Value.ToString();
                lbldescripcionrol.Text = f.dtgvdatos.CurrentRow.Cells["descripcion"].Value.ToString();
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            usuarioexiste();
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;
            if (txtidusuarioo.Text == "1" && sesion.OUsuario.Idusuario!= "1")
            {
                MessageBox.Show("No puede modificar al usuario anfitrion");
            }
            else if (txtidusuarioo.Text == "1" && rddsuspendido.Checked == true && sesion.OUsuario.Idusuario != "1")
            {
                MessageBox.Show("El administrador principal del programa, no puede quedar suspendido");
            }
            else if (txtidusuarioo.Text == "1" && rddactivo.Checked == false && sesion.OUsuario.Idusuario == "1")
            {
                Procesar();
            }
            else 
            {
                try
                {
                    if ( usuarioexistente.Rows[0]["nombre"].ToString() == txtnombreusuario.Text)
                    {
                        MessageBox.Show("Este nombre de usuario ya existe, porfavor ingrese otro");
                    }
                    else
                    {
                        Procesar();

                    }
                }
                catch
                {
                    Procesar();
                }

            }
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarusuario_Load(object sender, EventArgs e)
        {
           // cbb1
            cargarestilocomboboxestilo(); 
        }

        private void txtnombreusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cargarestilocomboboxestilo()
        {
            txtidrolss.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtidrolss.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtidrolss.DropDownStyle = ComboBoxStyle.DropDownList;
          
            MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=documentacionevidencia;Uid=root;Pwd=admin");
           // MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=Dulcesoft_xampp;Uid=root");
            MySqlCommand cm = new MySqlCommand("select * from roles", con);
            //cm.CommandType = CommandType.StoredProcedure; //solo prototipo (no es ideal para esta conexion)
            MySqlDataAdapter ada = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            txtidrolss.ValueMember = "idrol";
            txtidrolss.DisplayMember = "descripcion";
            txtidrolss.DataSource = dt;
        
        }

        private void txtidrol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
