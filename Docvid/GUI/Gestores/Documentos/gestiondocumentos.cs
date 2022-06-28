using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.Documentos
{
    public partial class gestiondocumentos : Form
    {

        

        //cache manager 
        //consultando los documentos de la cadena seleccionada
        public static DataTable DOCUMENTO_DE_CADENA_SELECCIONADA()
        {

            //ver el rol que tiene 
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String rolactual =  _SESION.OUsuario.Idrol.ToString();

            if (rolactual == "1" || rolactual == "2")
            {
                DataTable Resultado = new DataTable();
                StringBuilder Sentencia = new StringBuilder();
                DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

                Gestores.Cadenasdecustodias.gestioncadenas cadenaseleccionada = new Cadenasdecustodias.gestioncadenas();
                String seleccioncadena;
                
                seleccioncadena = cadenaseleccionada.getproyectoseleccion();

                
                Sentencia.Append(@"select *, if(destacado = 1,'destacado','no_destacado') as destacado2
 from documentos where idcadenadecustodia = '" + seleccioncadena + "';");
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

            //else if (rolactual == "2")
            //{
            //    DataTable Resultado = new DataTable();
            //    StringBuilder Sentencia = new StringBuilder();
            //    DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            //    Gestores.Cadenasdecustodias.gestioncadenas cadenaseleccionada = new Cadenasdecustodias.gestioncadenas();
            //    String seleccioncadena;
            //    seleccioncadena = cadenaseleccionada.cadenaseleccionada();

            //    //// sentencia anterior (funcional)
            //    Sentencia.Append(@"select  * from documentos where idcadenadecustodia = '" + seleccioncadena + "';");
               
            //   // Sentencia.Append(@"select *, if(destacado = 1,'destacado','no_destacado') as destacado2 from documentos where idcadenadecustodia = '" + seleccioncadena + "';");
            //    try
            //    {
            //        Resultado = oConsulta.Consultar(Sentencia.ToString());
            //    }
            //    catch
            //    {
            //        Resultado = new DataTable();
            //    }
            //    return Resultado;
            //}
                // por si se quiere agregar otro rol ...
            else
            {
                DataTable Resultado = new DataTable();

                //// aqui seria si se agregara otro rol (no es necesaria esta parte)

                //StringBuilder Sentencia = new StringBuilder();
                //DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

                //Rol2.cadenadecustodia.cadenadecustodia cadenaseleccionada = new Rol2.cadenadecustodia.cadenadecustodia();
                //String seleccioncadena;
                //seleccioncadena = cadenaseleccionada.cadenaseleccionada();

                //Sentencia.Append(@"select  * from documentos where idcadenadecustodia = '" + seleccioncadena + "';");
                //try
                //{
                //    Resultado = oConsulta.Consultar(Sentencia.ToString());
                //}
                //catch
                //{
                //    Resultado = new DataTable();
                //}

                MessageBox.Show("Cadena de custodia no existente, no hay documentos que mostrar");
                
                return Resultado;
            }


           
        }

        //fin de metodologia cache manager

        public static DataTable EVIDENCIA_DE_CADENA_SELECCIONADA(String dia ,String mes , String anio)
        {

            //ver el rol que tiene 
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String rolactual = _SESION.OUsuario.Idrol.ToString();


            if (rolactual == "1" || rolactual == "2" || rolactual == "3" )
            {
                DataTable Resultado = new DataTable();
                StringBuilder Sentencia = new StringBuilder();
                DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

                Gestores.Cadenasdecustodias.gestioncadenas cadenaseleccionada = new Cadenasdecustodias.gestioncadenas();
                String seleccioncadena;

                seleccioncadena = cadenaseleccionada.getproyectoseleccion();


                Sentencia.Append(@"Select e.idevidencia, e.idproyecto, e.idtipoevidencia, e.dia, e.mes, e.anio, e.hora, e.minutos, e.idusuario, e.hash, e.nota, e.ruta, te.tipo, e.hashactual
                from evidencias e, proyectos p, tiposdeevidencias te
                where e.idproyecto = p.idproyecto and e.idtipoevidencia = te.idtipoevidencia and  e.dia = '" + dia + "' and e.mes = '" + mes + "' and e.anio = '" + anio + "' and  p.idproyecto = '" + seleccioncadena + "';");
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

            else
            {
                DataTable Resultado = new DataTable();


                MessageBox.Show("Cadena de custodia no existente, no hay documentos que mostrar");

                return Resultado;
            }



        }

        /*CONSULTA SIN IMPORTAR EL TIEMPO*/
        //consultando los documentos de la cadena seleccionada
        

        //fin de metodologia cache manager

        public static DataTable EVIDENCIA_DE_CADENA_SELECCIONADA_SIN_FECHA()
        {

            //ver el rol que tiene 
            // aqui solicitamos el usaurio actual (el que inicia sesion)
            SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
            String rolactual = _SESION.OUsuario.Idrol.ToString();


            if (rolactual == "1" || rolactual == "2" || rolactual == "3")
            {
                DataTable Resultado = new DataTable();
                StringBuilder Sentencia = new StringBuilder();
                DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

                Gestores.Cadenasdecustodias.gestioncadenas cadenaseleccionada = new Cadenasdecustodias.gestioncadenas();
                String seleccioncadena;

                seleccioncadena = cadenaseleccionada.getproyectoseleccion();


                Sentencia.Append(@"Select e.idevidencia, e.idproyecto, e.idtipoevidencia, e.dia, e.mes, e.anio, e.hora, e.minutos, e.idusuario, e.hash, e.nota, e.ruta, te.tipo, e.hashactual
                from evidencias e, proyectos p, tiposdeevidencias te
                where e.idproyecto = p.idproyecto and e.idtipoevidencia = te.idtipoevidencia  and  p.idproyecto = '" + seleccioncadena + "';");
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

            else
            {
                DataTable Resultado = new DataTable();


                MessageBox.Show("Cadena de custodia no existente, no hay documentos que mostrar");

                return Resultado;
            }



        }



        BindingSource __CLIENTES = new BindingSource();
        private void CargarDatos()
        {
            permisos();
            try
            {
                __CLIENTES.DataSource = EVIDENCIA_DE_CADENA_SELECCIONADA(datecalendario.Value.Date.Day.ToString(), datecalendario.Value.Date.Month.ToString(), datecalendario.Value.Date.Year.ToString());

            }
            catch
            {

            }
            // dtgvdatos.AutoGenerateColumns = false;
            dtgvdatos.DataSource = __CLIENTES;
            lblestado.Text = " Registros encontrados: " + dtgvdatos.Rows.Count.ToString();

            compactarfechayhora();
        }

        private void CargarDatos_sin_fecha()
        {
            permisos();
            try
            {
                __CLIENTES.DataSource = EVIDENCIA_DE_CADENA_SELECCIONADA_SIN_FECHA();

            }
            catch
            {

            }
            // dtgvdatos.AutoGenerateColumns = false;
            dtgvdatos.DataSource = __CLIENTES;
            lblestado.Text = " Registros encontrados: " + dtgvdatos.Rows.Count.ToString();

            compactarfechayhora();
        }

        public gestiondocumentos()
        {
            InitializeComponent();
            CargarDatos();
        }

        void StyleDatagridview()
        {
            dtgvdatos.BorderStyle = BorderStyle.None;
            dtgvdatos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dtgvdatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvdatos.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dtgvdatos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgvdatos.BackgroundColor = Color.FromArgb(30, 30, 30);
            dtgvdatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dtgvdatos.EnableHeadersVisualStyles = false;
            dtgvdatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvdatos.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dtgvdatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dtgvdatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void gestiondocumentos_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            CargarDatos();
            chsinfecha.Checked = true;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea editar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                

                agregardocumento f = new agregardocumento();
                //f.txtidevidencia.Text = dtgvdatos.CurrentRow.Cells["iddocumento"].Value.ToString();
                //f.txtruta.Text = dtgvdatos.CurrentRow.Cells["url"].Value.ToString();
                //f.txtnota.Text = dtgvdatos.CurrentRow.Cells["comentarios"].Value.ToString();
                //f.txtidproyecto.Text = dtgvdatos.CurrentRow.Cells["idcadenadecustodia"].Value.ToString();

                f.txtidevidencia.Text = dtgvdatos.CurrentRow.Cells["idevidencia"].Value.ToString();
                f.txthash.Text = dtgvdatos.CurrentRow.Cells["hash"].Value.ToString();
                f.txtidproyecto.Text = dtgvdatos.CurrentRow.Cells["idproyecto"].Value.ToString();
                f.txtnota.Text = dtgvdatos.CurrentRow.Cells["nota"].Value.ToString();
                f.txtruta.Text = dtgvdatos.CurrentRow.Cells["ruta"].Value.ToString();
                f.txttipoevidencia.Text = dtgvdatos.CurrentRow.Cells["idtipoevidencia"].Value.ToString();

                
              
                ////comprobamos si es o no destacado para usar los radiobuttons
                //if (dtgvdatos.CurrentRow.Cells["destacado"].Value.ToString()=="1")
                //{
                //    f.rddestacado.Checked=true;
                //}
                //else
                //{
                //    f.rdnodestacado.Checked = true;
                //}
                f.ShowDialog();

                verificarchequeodefecha();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //ver la cadena seleccionada actual
            Gestores.Cadenasdecustodias.gestioncadenas cadenaseleccionada = new Cadenasdecustodias.gestioncadenas();
            String miproyecto = cadenaseleccionada.getproyectoseleccion();
            agregardocumento a = new agregardocumento();
            a.txtidproyecto.Text = miproyecto;
            a.ShowDialog();

            verificarchequeodefecha();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro seleccionado?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                General.CLS.documentos oEmpleado = new General.CLS.documentos();
                oEmpleado.Iddocumento = dtgvdatos.CurrentRow.Cells["iddocumento"].Value.ToString();
                if (oEmpleado.Eliminar())
                {
                    MessageBox.Show("Registro eliminado satisfactoriamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verificarchequeodefecha();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado ", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verificarchequeodefecha();
                }
            }
        }

        //abrimos los archivos con doble click
        private void dtgvdatos_DoubleClick(object sender, EventArgs e)
        {
            //OpenFileDialog abrir = new OpenFileDialog();

            //if (abrir.ShowDialog() == DialogResult.OK)
            //{
                

            try
            {
                //verificamos que el archivo tenga url
                General.CLS.documentos oEmpleado = new General.CLS.documentos();

                // en el caso que no tenga
                if (dtgvdatos.CurrentRow.Cells["url"].Value.ToString().Equals(""))
                {
                    MessageBox.Show("Este archivo no tiene url");
                }
                //en el caso que tenga url abrimos esa direccion
                else
                {
                    oEmpleado.Iddocumento = dtgvdatos.CurrentRow.Cells["url"].Value.ToString();

                    string direccion = oEmpleado.Iddocumento;
                    Process proceso = new Process();
                    proceso.StartInfo.FileName = direccion;

                    // Si falla la url muestra el mensaje de error
                    try
                    {
                        proceso.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Archivo movido o eliminado");

                    }

                }
            }

            catch
            {
                MessageBox.Show("Lista vacia");
            }

            

                
            //}

        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
            compactarfechayhora();
        }

        private void FiltrarLocalmente()
        {
            try
            {
                if (txtfiltro.TextLength > 0)
                {
                    __CLIENTES.Filter = "nota LIKE '%" + txtfiltro.Text + "%'";
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
            compactarfechayhora(); 
        }

        void permisos()
        {
            Rol2.principal a = new Rol2.principal();
            if(a.getcrearevidencias() == "0")
            {
                btnagregar.Visible = false;
            }
           
        }

        private void datecalendario_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void verificarchequeodefecha()
        {
            if (chsinfecha.Checked == true)
            {
                CargarDatos_sin_fecha();
                datecalendario.Enabled = false;
            }
            else
            {
                CargarDatos();
                datecalendario.Enabled = true;
            }
        }
        private void chsinfecha_CheckedChanged(object sender, EventArgs e)
        {
            if(chsinfecha.Checked == true)
            {
                CargarDatos_sin_fecha();
                datecalendario.Enabled = false;
            }
            else
            {
                CargarDatos();
                datecalendario.Enabled = true;
            }
        }

        private void compactarfechayhora()
        {
            //int comprobante = 0;
            foreach (DataGridViewRow Row in dtgvdatos.Rows)
            {
                // comprobante = int.Parse(Row.Cells["minutos"].Value.ToString());
                // ESTE ES PARA PONER LOS MESES
                String[] meses = { "Enero", "Febrero", "Marzo", "Abri", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", };
               // Row.Cells["fechacorta"].Value = Row.Cells["dia"].Value + "/" + Row.Cells["mes"].Value + "/" + Row.Cells["anio"].Value;
                Row.Cells["fechacorta"].Value = Row.Cells["dia"].Value + "/" + meses[Int32.Parse(Row.Cells["mes"].Value.ToString())-1] + "/" + Row.Cells["anio"].Value;
                //if (comprobante<10)
                if (Row.Cells["minutos"].Value.ToString().Length == 1)
                {
                    int hora = Int32.Parse(Row.Cells["hora"].Value.ToString());
                    if (hora>=13)
                    {
                        hora = hora - 12;
                        Row.Cells["horacorta"].Value = hora + ":0" + Row.Cells["minutos"].Value+" pm";
                    }
                    else
                    {
                        Row.Cells["horacorta"].Value = hora + ":0" + Row.Cells["minutos"].Value + " am";
                    }
                }
                else
                {
                   // Row.Cells["horacorta"].Value = Row.Cells["hora"].Value + ":" + Row.Cells["minutos"].Value;
                    int hora = Int32.Parse(Row.Cells["hora"].Value.ToString());
                    if (hora >= 13)
                    {
                        hora = hora - 12;
                        Row.Cells["horacorta"].Value = hora + ":" + Row.Cells["minutos"].Value + " pm";
                    }
                    else
                    {
                        Row.Cells["horacorta"].Value = hora + ":" + Row.Cells["minutos"].Value + " am";
                    }
                }

            } 
        }


        private void btnverificararchivo_Click(object sender, EventArgs e)
        {
            //pasamos la ruta al proceso
            if(dtgvdatos.CurrentRow.Cells["ruta"].Value.ToString()!= "" )
            {
                cargarhash(dtgvdatos.CurrentRow.Cells["ruta"].Value.ToString());
            }
            else  { MessageBox.Show("Ruta invalida de archivo"); }
        }

        /*PROCESOS PARA COMPROBAR QUE EL ARCHIVO NO ESTA MODIFICADO*/
        private void cargarhash(String ruta)
        {

            backgroundWorker1.RunWorkerAsync(ruta);
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
           String hashactual= e.Result.ToString();
           DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
           operacion.Actualizar("update  evidencias set hashactual = '"+hashactual+"'  where idevidencia = '"+dtgvdatos.CurrentRow.Cells["idevidencia"].Value.ToString()+"';");
           verificarchequeodefecha();
            if(dtgvdatos.CurrentRow.Cells["hash"].Value.ToString() ==dtgvdatos.CurrentRow.Cells["hashactual"].Value.ToString() )
           {
               MessageBox.Show("El archivo no ha sido modificado");
           }
           else
           {
               MessageBox.Show("Archivo modificado");
               String nota = dtgvdatos.CurrentRow.Cells["nota"].Value.ToString();
                nota = nota+ "\n Fecha de observacion de archivo modificado: " + DateTime.Now.Day + "/" + DateTime.Now.Month +"/"+ DateTime.Now.Year+" "+DateTime.Now.Hour+":"+DateTime.Now.Minute;
//                String nota = dtgvdatos.CurrentRow.Cells["hashactual"].Value.ToString()
               operacion.Actualizar("update  evidencias set nota =  '"+nota+"' where idevidencia = '"+dtgvdatos.CurrentRow.Cells["idevidencia"].Value.ToString()+"';");
           } verificarchequeodefecha();
        }


    }
}
