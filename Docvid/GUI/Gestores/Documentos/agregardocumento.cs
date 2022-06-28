using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.Documentos
{
    public partial class agregardocumento : Form
    {
        String auxiliarruta;
       
        private Boolean Verificacion()///verificando que eñ campo nombre no este vacio
        {
            Boolean Verificado = true;
            Notificador.Clear();
            if (txtruta.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtruta, "Tiene que cargar el archivo");
            }
            if (txttipoevidencia.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txttipoevidencia, "Este campo no puede quedar vacio");
            }
            if (txtidproyecto.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txtidproyecto, "Este campo no puede quedar vacio");
            }
            
            
            return Verificado;

        }

        private int Procesar()
        {
            // 1 = hecho
            // 0 = no hecho
            // 2 = actualizar 
            int hecho = 0;

            if (Verificacion())
            {
                SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia; 
                General.CLS.evidencias oEmpleado = new General.CLS.evidencias();
                oEmpleado.Idevidencia = txtidevidencia.Text;
                oEmpleado.Idproyecto = txtidproyecto.Text;
                oEmpleado.Idtipoevidencia = txttipoevidencia.Text;
                oEmpleado.Idusuario = sesion.OUsuario.Idusuario;
                oEmpleado.Hash = txthash.Text;
                oEmpleado.Ruta = txtruta.Text;
                oEmpleado.Nota = txtnota.Text;
                //oEmpleado.Nota = txtnota.Text;
                //oEmpleado.Iddocumento = txtidevidencia.Text;
                //if (rddestacado.Checked)
                //{
                //    oEmpleado.Destacado = "1";
                //}
                //else
                //{
                //    oEmpleado.Destacado = "0";
                //}
                if (txtidevidencia.TextLength == 0)
                {
                    ///Estoy insertando un nuevo registro
                    if (oEmpleado.Guardar())
                    {
                        MessageBox.Show("Registro guardado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hecho = 1;
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser guardado", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ///estoy actualizando un registro
                    ///
                    oEmpleado.Ruta = txtruta.Text;
                    if (oEmpleado.Actualizar())
                    {
                        MessageBox.Show("Registro actualizado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hecho = 2;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser actualizado", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return hecho;
        }



       public static Boolean buscando = false;

        public Boolean estadobuscando()
        {
            return buscando;
        }

        public agregardocumento()
        {
            InitializeComponent();
        }


        //cargar la url del archivo
        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void cargarhash(String ruta)
        {
            //txtruta.Text = openFileDialog1.FileName;
            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
               // txtruta.Text = openFileDialog1.FileName;
            //}
            backgroundWorker1.RunWorkerAsync(ruta);
        }

        //funcion de guardado de archivo
        public void Guardar()
        {
            // filName;
            string filName;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png*)|*.png*|PDF (*.pdf)|*.pdf|DOC (*.doc)|*.doc|XLS (*.xls)|*.xls|DOCX (*.docx)|*.docx|TXT (*.txt)|*.txt";
            //Restaurar la ventana despues del open fileDialog
            ofd.RestoreDirectory = true;
            ofd.Title = "Selecciona Comprobante";
            //if (ofd.ShowDialog() == DialogResult.OK)
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               // filName = ofd.FileName;

                filName = openFileDialog1.FileName;
                cargarhash(filName);
                //extraemos la direccion del archivo


                String auxiliar1 = openFileDialog1.FileName;
                
                //conversion de \ a /
                auxiliar1 = auxiliar1.Replace(@"\","/");

                // algoritmo de reemplazo de \ a /
                String auxiliar = txtruta.Text.Replace(@"\", "/");
            
                 txtruta.Text = auxiliar1;
                 auxiliarruta = auxiliar1;
                 lblproyectoseleccionado.Text = auxiliar;
               // txtruta.Text = auxiliar;
                //if (guardar)
                //{
                    //Copia del archivo
                    string destino = Path.Combine(Application.StartupPath, String.Format(@"C:\Users\Kevin\Documents\Docvid\{0}", Path.GetFileName(ofd.FileName)));


                    String extension = Path.GetExtension(auxiliar1);
                    extension = Regex.Replace(extension, "[@,\\.\";'\\\\]", string.Empty);
                    //MessageBox.Show(extension);
                    buscartipodeevidencia(extension);
                
                //no queremos copiar
                //  File.Copy(ofd.FileName, destino);
        
                //}
            }
        }

        private void buscartipodeevidencia (String extension)
        {
            try { 
            DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
            DataTable consulta = operacion.Consultar("select * from tiposdeevidencias where extension = '"+extension+"';");
            txttipoevidencia.Text = consulta.Rows[0]["idtipoevidencia"].ToString();
            label8.Text = "Tipo de evidencia: "+ consulta.Rows[0]["tipo"].ToString();
            }
            catch { label8.Text = "No registrada"; txttipoevidencia.Text = ""; }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            buscando = false;
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnbuscarcadena_Click(object sender, EventArgs e)
        {
            buscando = true;
            //ver el rol que tiene 
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String rolactual = _SESION.OUsuario.Nombre.ToString();

            //if (rolactual == "1")
            //{
                Gestores.Cadenasdecustodias.gestioncadenas a = new Gestores.Cadenasdecustodias.gestioncadenas();
                MessageBox.Show("Haga doble click al registro que desea agregar");
                a.ShowDialog();
                txtidproyecto.Text = a.dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString();
                lblseleccion.Text = "Cadena de custodia seleccionada: " + a.dtgvdatos.CurrentRow.Cells["titulo"].Value.ToString();
                
            //}

            //else if (rolactual == "2")
            //{
            //    Rol2.cadenadecustodia.proyectos a = new Rol2.cadenadecustodia.proyectos();
            //    MessageBox.Show("Haga doble click al registro que desea agregar");
            //    a.ShowDialog();
            //    txtidproyecto.Text = a.dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString();
            //    lblseleccion.Text = "Cadena de custodia seleccionada: " + a.dtgvdatos.CurrentRow.Cells["nombre"].Value.ToString();
            //}
            //// por si se quiere agregar otro rol ...
            //else
            //{
            //    Rol2.cadenadecustodia.proyectos a = new Rol2.cadenadecustodia.proyectos();
            //    MessageBox.Show("Haga doble click al registro que desea agregar");
            //    a.ShowDialog();
               
            //    try
            //    {
            //        txtidproyecto.Text = a.dtgvdatos.CurrentRow.Cells["idcadena"].Value.ToString();
            //        lblseleccion.Text = "Cadena de custodia seleccionada: " + a.dtgvdatos.CurrentRow.Cells["nombre"].Value.ToString();

            //    }
            //    catch { }
                
            //}
            
           
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int decision = Procesar();

            if(decision == 1)
            {
                // pregunta si va agregar mas documentos
                if (MessageBox.Show("Desea agregar mas archivos?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtruta.Text = "";
                    txthash.Text = "";
                }
                else
                {
                    Close();
                }
            }
            else
            {
                
            }

           
        }

        private void agregardocumento_Load(object sender, EventArgs e)
        {
           
        }

        // boton para quitar texto
        private void button1_Click_1(object sender, EventArgs e)
        {
            txtruta.Text = "";
            txthash.Text = "";
        }

        private void agregardocumento_FormClosed(object sender, FormClosedEventArgs e)
        {
            buscando = false;
            Close();
        }

        //buscar carpeta
        private void button2_Click(object sender, EventArgs e)
        {  
            var resultado = fbd.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //extraemos la direccion del archivo
                txtruta.Text = fbd.SelectedPath;
                String auxiliar1 = fbd.SelectedPath;
                
                //conversion de \ a /
                auxiliar1 = auxiliar1.Replace(@"\", "/");

                // algoritmo de reemplazo de \ a /
                String auxiliar = txtruta.Text.Replace(@"\", "/");

                txtruta.Text = auxiliar1;
                auxiliarruta = auxiliar1;
                lblproyectoseleccionado.Text = auxiliar;

               // txtruta.Text = fbd.SelectedPath;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string fPath = e.Argument.ToString();
            byte[] buffer;
            int bytesRead;
            long size;
            long totalBytesRead = 0;
            using (Stream file = File.OpenRead(fPath)) // aqui me da el error 
            {
                size = file.Length;
                using (System.Security.Cryptography.HashAlgorithm hasher = MD5.Create())
                {
                    do
                    {
                        buffer = new byte[4096];
                        bytesRead = file.Read(buffer, 0, buffer.Length);
                        totalBytesRead += bytesRead;
                        hasher.TransformBlock(buffer, 0, bytesRead, null, 0);
                        //backgroundWorker1.ReportProgress((int)((double)totalBytesRead / size * 100));
                    }
                    while (bytesRead != 0);

                    hasher.TransformFinalBlock(buffer, 0, 0);
                    e.Result = MakeHashString(hasher.Hash);
                }
            }
        }

        private static string MakeHashString(byte[] hashBytes)
        {
            StringBuilder hash = new StringBuilder(32);
            foreach (byte b in hashBytes)
            {
                hash.Append(b.ToString("X2").ToLower());
            }
            return hash.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           // MessageBox.Show(e.Result.ToString());
            txthash.Text = e.Result.ToString();
        }

        private void btnbuscartipoevidencia_Click(object sender, EventArgs e)
        {
            selecciontipo a = new selecciontipo();
            a.ShowDialog();
            txttipoevidencia.Text = a.dtgvdatos.CurrentRow.Cells["idtipoevidencia"].Value.ToString();
            lbltipodeevidenciaseleccion.Text = a.dtgvdatos.CurrentRow.Cells["formato"].Value.ToString();
        }


    }
}
