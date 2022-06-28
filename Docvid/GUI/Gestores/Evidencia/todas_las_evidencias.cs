using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Gestores.Evidencia
{
    public partial class todas_las_evidencias : Form
    {

        BindingSource __CLIENTES = new BindingSource();

        public static DataTable TODAS_LAS_EVIDENCIAS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;

            Sentencia.Append(@" Select e.idevidencia, e.idproyecto, e.idtipoevidencia, e.dia, e.mes, e.anio, e.hora, e.minutos, e.idusuario, e.hash, e.nota, e.ruta, te.tipo, e.hashactual, p.titulo as nombreproyecto
                from evidencias e, proyectos p, tiposdeevidencias te, usuarios u
                where e.idproyecto = p.idproyecto and te.idtipoevidencia = e.idtipoevidencia and u.idusuario = p.idusuario and  u.idusuario= '" + sesion.OUsuario.Idusuario + "';");
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
        public static DataTable TODAS_LAS_EVIDENCIAS_CON_FECHA(String dia, String mes, String anio)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;

            Sentencia.Append(@" Select e.idevidencia, e.idproyecto, e.idtipoevidencia, e.dia, e.mes, e.anio, e.hora, e.minutos, e.idusuario, e.hash, e.nota, e.ruta, te.tipo, e.hashactual, p.titulo as nombreproyecto
                from evidencias e, proyectos p, tiposdeevidencias te, usuarios u
                where e.idproyecto = p.idproyecto and te.idtipoevidencia = e.idtipoevidencia and u.idusuario = p.idusuario and  u.idusuario= '" + sesion.OUsuario.Idusuario + "' and e.dia = '" + dia + "'and e.mes = '" + mes + "'and e.anio = '" + anio + "';");
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



        private void CargarDatos()
        {
            try
            {
                if(chsinfecha.Checked == true)
                {
                    __CLIENTES.DataSource = TODAS_LAS_EVIDENCIAS();
                }
                else if (chsinfecha.Checked == false)
                {
                    __CLIENTES.DataSource = TODAS_LAS_EVIDENCIAS_CON_FECHA(datecalendario.Value.Date.Day.ToString(), datecalendario.Value.Date.Month.ToString(), datecalendario.Value.Date.Year.ToString());
                }

               
                dtgvdatos.DataSource = __CLIENTES;

                lblestado.Text = dtgvdatos.Rows.Count.ToString() + "Registors Encontrados"; 

           }
            catch
            {
            }

          

            compactarfechayhora();

        }

        public todas_las_evidencias()
        {
            InitializeComponent();
        }

        

        //cargando el form
        private void todas_las_evidencias_Load(object sender, EventArgs e)
        {

            StyleDatagridview();
            chsinfecha.Checked = true;
           //CargarDatos();
        }

        private void verificarchequeosinfecha()
        {
            if (chsinfecha.Checked == true)
            {
                datecalendario.Enabled = false;
            }
            else
            {
                datecalendario.Enabled = true;
            }
            CargarDatos();
        }

        private void chsinfecha_CheckedChanged(object sender, EventArgs e)
        {
            if(chsinfecha.Checked == true)
            {
                datecalendario.Enabled = false;
            }
            else
            {
                datecalendario.Enabled = true;
            }
            CargarDatos();
        }

        private void datecalendario_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Documentos.agregardocumento a = new Documentos.agregardocumento();
            a.ShowDialog();
            CargarDatos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado? ", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                General.CLS.evidencias oEmpleado = new General.CLS.evidencias();
                oEmpleado.Idevidencia = dtgvdatos.CurrentRow.Cells["idevidencia"].Value.ToString();
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

        private void dtgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void compactarfechayhora()
        {
            //int comprobante = 0;
            foreach (DataGridViewRow Row in this.dtgvdatos.Rows)
            {
                // comprobante = int.Parse(Row.Cells["minutos"].Value.ToString());
                // ESTE ES PARA PONER LOS MESES
                String[] meses = { "Enero", "Febrero", "Marzo", "Abri", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", };
                // Row.Cells["fechacorta"].Value = Row.Cells["dia"].Value + "/" + Row.Cells["mes"].Value + "/" + Row.Cells["anio"].Value;
                Row.Cells["fechacorta"].Value = Row.Cells["dia"].Value + "/" + meses[Int32.Parse(Row.Cells["mes"].Value.ToString()) - 1] + "/" + Row.Cells["anio"].Value;
                //if (comprobante<10)
                if (Row.Cells["minutos"].Value.ToString().Length == 1)
                {
                    int hora = Int32.Parse(Row.Cells["hora"].Value.ToString());
                    if (hora >= 13)
                    {
                        hora = hora - 12;
                        Row.Cells["horacorta"].Value = hora + ":0" + Row.Cells["minutos"].Value + " pm";
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

            } //MessageBox.Show("Ha entrado");
        }

        /*VERIFICAR EL HASH DEL ARCHIVO*/
        private void btnverificararchivo_Click(object sender, EventArgs e)
        {
            //pasamos la ruta al proceso
            if (dtgvdatos.CurrentRow.Cells["ruta"].Value.ToString() != "")
            {
                cargarhash(dtgvdatos.CurrentRow.Cells["ruta"].Value.ToString());
            }
            else { MessageBox.Show("Ruta invalida de archivo"); }
        }
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
            String hashactual = e.Result.ToString();
            DBManager.CLS.DBOperacion operacion = new DBManager.CLS.DBOperacion();
            operacion.Actualizar("update  evidencias set hashactual = '" + hashactual + "'  where idevidencia = '" + dtgvdatos.CurrentRow.Cells["idevidencia"].Value.ToString() + "';");
            verificarchequeosinfecha();
            compactarfechayhora();
            if (dtgvdatos.CurrentRow.Cells["hash"].Value.ToString() == dtgvdatos.CurrentRow.Cells["hashactual"].Value.ToString())
            {
                MessageBox.Show("El archivo no ha sido modificado");
            }
            else
            {
                MessageBox.Show("Archivo modificado");
                String nota = dtgvdatos.CurrentRow.Cells["nota"].Value.ToString();
                nota = nota + "\n Fecha de observacion de archivo modificado: " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                //                String nota = dtgvdatos.CurrentRow.Cells["hashactual"].Value.ToString()
                operacion.Actualizar("update  evidencias set nota =  '" + nota + "' where idevidencia = '" + dtgvdatos.CurrentRow.Cells["idevidencia"].Value.ToString() + "';");
            }
            verificarchequeosinfecha();
            compactarfechayhora();
        }

        private void FiltrarLocalmente()
        {
            try
            {
                if (txtfiltro.TextLength > 0)
                {
                    __CLIENTES.Filter = "nota LIKE '%" + txtfiltro.Text + "%' or nombreproyecto LIKE '%" + txtfiltro.Text + "%'";
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

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SessionManager.CLS.Sesion sesion = SessionManager.CLS.Sesion.Instancia;

            if(chsinfecha.Checked == true){
                Reportes.Vista_Reportes.Reportes_sp ni = new Reportes.Vista_Reportes.Reportes_sp(3, sesion.OUsuario.Idusuario);
                ni.Show();
            }
            else{
                Reportes.Vista_Reportes.Reportes_sp ni = new Reportes.Vista_Reportes.Reportes_sp(4, sesion.OUsuario.Idusuario);
                ni.fecha(datecalendario.Value.Date.Day.ToString(), datecalendario.Value.Date.Month.ToString(), datecalendario.Value.Date.Year.ToString());
                ni.Show();
            }
        }

        /*FIN DE LA INSPECCION DE ARCHIVOS CON HASH*/


    }
}
