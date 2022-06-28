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

namespace Docvid.GUI.Reportes.Vista_Reportes
{
    public partial class Reportes_sp : Form
    {
        string usuario;
        int num_reporte;
        string dia;
        string mes;
        string anio;
        
        DBManager.CLS.DBConexion uno = new DBManager.CLS.DBConexion();
        public Reportes_sp(int num,string id)
        {
            InitializeComponent();
            num_reporte = num;
            usuario = id;
        }
        public void fecha(string d,string m, string a){
            dia = d;
            mes = m;
            anio = a;
        }

        private void Reportes_sp_Load(object sender, EventArgs e)
        {
            
            if (uno.Conectar())
            {
                if (num_reporte == 1)
                {
                    string mysql = " select p.* , u.nombre as nombre_usuario from usuarios u, proyectos p where u.idusuario = p.idusuario and p.idusuario = '" + usuario + "';";
                    MySqlDataAdapter ada = new MySqlDataAdapter(mysql, uno.oConexion);
                    Resources.DataSets.DataSetProyectos1 ds = new Resources.DataSets.DataSetProyectos1();
                    ada.Fill(ds, "Proyectos");
                    Reportes.ReporteProyectos1 r = new Reportes.ReporteProyectos1();
                    r.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = r;
                    crystalReportViewer1.Refresh();
                    
                }
                else if (num_reporte == 2)
                {
                    string mysql = " select p.* , u.nombre as nombre_usuario from usuarios u, proyectos p where u.idusuario = p.idusuario;";
                    MySqlDataAdapter ada = new MySqlDataAdapter(mysql, uno.oConexion);
                    Resources.DataSets.DataSetProyectos2 ds = new Resources.DataSets.DataSetProyectos2();
                    ada.Fill(ds, "Proyectos");
                    Reportes.ReporteProyectos2 r = new Reportes.ReporteProyectos2();
                    r.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = r;
                    crystalReportViewer1.Refresh();
                    
                }
                else if (num_reporte == 3)
                {
                    
                    string mysql = "Select e.idevidencia, e.idproyecto,concat(e.dia,'/',e.mes,'/', e.anio,'-',e.hora,':',e.minutos) as Fecha_Hora, e.idusuario, e.hash, e.nota, e.ruta, te.tipo, e.hashactual, p.titulo as nombreproyecto from evidencias e, proyectos p, tiposdeevidencias te, usuarios u where e.idproyecto = p.idproyecto and te.idtipoevidencia = e.idtipoevidencia and u.idusuario = p.idusuario and  u.idusuario='"+usuario+"';";
                    MySqlDataAdapter ada = new MySqlDataAdapter(mysql, uno.oConexion);
                    Resources.DataSets.DataSetEvidencias1 ds = new Resources.DataSets.DataSetEvidencias1();
                    ada.Fill(ds, "Evidencias");
                    Reportes.ReporteEvidenciasp r = new Reportes.ReporteEvidenciasp();
                    r.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = r;
                    crystalReportViewer1.Refresh();
                    
                }
                else if (num_reporte == 4)
                {

                    string mysql = "Select e.idevidencia, e.idproyecto,concat(e.dia,'/',e.mes,'/', e.anio,'-',e.hora,':',e.minutos) as Fecha_Hora, e.idusuario, e.hash, e.nota, e.ruta, te.tipo, e.hashactual, p.titulo as nombreproyecto from evidencias e, proyectos p, tiposdeevidencias te, usuarios u where e.idproyecto = p.idproyecto and te.idtipoevidencia = e.idtipoevidencia and u.idusuario = p.idusuario and  u.idusuario= '" + usuario + "' and e.dia = '" + dia + "'and e.mes = '" + mes + "'and e.anio = '" + anio + "';";
                    MySqlDataAdapter ada = new MySqlDataAdapter(mysql, uno.oConexion);
                    Resources.DataSets.DataSetEvidencias1 ds = new Resources.DataSets.DataSetEvidencias1();
                    ada.Fill(ds, "Evidencias");
                    Reportes.ReporteEvidenciasp r = new Reportes.ReporteEvidenciasp();
                    r.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = r;
                    crystalReportViewer1.Refresh();

                }
                else if (num_reporte == 5)
                {

                    string mysql = "select pc.idproyectocompartido, p.idproyecto, p.titulo, p.descripcion, (select nombre from usuarios where idusuario = pc.idusuario) as usuario_compartido, u.nombre as usuario_propietario from usuarios u, proyectos p, proyectoscompartidos pc where u.idusuario = p.idusuario and pc.idproyecto = p.idproyecto and u.idusuario ='" + usuario + "';";
                    MySqlDataAdapter ada = new MySqlDataAdapter(mysql, uno.oConexion);
                    Resources.DataSets.DataSetProyectosCompa ds = new Resources.DataSets.DataSetProyectosCompa();
                    ada.Fill(ds, "Proyectos");
                    Reportes.ReporteProyectosCompartidos r = new Reportes.ReporteProyectosCompartidos();
                    r.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = r;
                    crystalReportViewer1.Refresh();

                }
                else if (num_reporte == 6)
                {

                    string mysql = "select pc.idproyectocompartido,pc.idproyecto, p.titulo, p.descripcion, (select nombre from usuarios where idusuario = p.idusuario) as nombre_usuario_propietario, u.nombre from proyectoscompartidos pc, proyectos p, usuarios u where pc.idproyecto = p.idproyecto and u.idusuario = pc.idusuario and u.idusuario = '" + usuario + "';";
                    MySqlDataAdapter ada = new MySqlDataAdapter(mysql, uno.oConexion);
                    Resources.DataSets.DataSetProyectosCompa2 ds = new Resources.DataSets.DataSetProyectosCompa2();
                    ada.Fill(ds, "Proyectos");
                    Reportes.ReporteProyectosComp2 r = new Reportes.ReporteProyectosComp2();
                    r.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = r;
                    crystalReportViewer1.Refresh();

                }
                else if (num_reporte == 7)
                {

                    string mysql = " select u.idusuario, u.nombre, u.idrol, r.descripcion, if(u.estado = 1, 'activo','suspendido') as estado, u.telefono as telefono  from usuarios u, roles r where u.idrol = r.idrol;";
                    MySqlDataAdapter ada = new MySqlDataAdapter(mysql, uno.oConexion);
                    Resources.DataSets.DataSetUsuarios ds = new Resources.DataSets.DataSetUsuarios();
                    ada.Fill(ds, "Usuarios");
                    Reportes.Usuarios r = new Reportes.Usuarios();
                    r.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = r;
                    crystalReportViewer1.Refresh();

                }
                else if (num_reporte == 8)
                {

                    string mysql = " select * from tiposdeevidencias;";
                    MySqlDataAdapter ada = new MySqlDataAdapter(mysql, uno.oConexion);
                    Resources.DataSets.DataSetEvidencias ds = new Resources.DataSets.DataSetEvidencias();
                    ada.Fill(ds, "tiposdeevidencias");
                    Reportes.ReportetipodeEvidencia r = new Reportes.ReportetipodeEvidencia();
                    r.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = r;
                    crystalReportViewer1.Refresh();

                }
                else if (num_reporte == 9)
                {

                    string mysql = "select * from roles;";
                    MySqlDataAdapter ada = new MySqlDataAdapter(mysql, uno.oConexion);
                    Resources.DataSets.DataSetRoles ds = new Resources.DataSets.DataSetRoles();
                    ada.Fill(ds, "Roles");
                    Reportes.ReporteRoles r = new Reportes.ReporteRoles();
                    r.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = r;
                    crystalReportViewer1.Refresh();

                }
            }
        }
    }
}
