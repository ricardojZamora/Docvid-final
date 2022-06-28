using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager
{
    public class SystemCache
    {

        public static DataTable TODOS_LOS_PROYECTOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@" select p.* , u.nombre as nombre_usuario
 from usuarios u, proyectos p
 where u.idusuario = p.idusuario");
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



        //consultando los roles
        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select r.*, p.idpermiso
from permisos p, roles r
where p.idrol = r.idrol;");
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


        //consultando las cadenas
        public static DataTable TODAS_LAS_CADENAS_DE_CUSTODIA()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@" select  c.idcadenadecustodia, c.nombre, c.descripcion, c.idusuario, u.nombre, c.Cantidad_de_docs
 from cadenasdecustodias c, usuarios u
 where c.idusuario = u.idusuario;");
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

        //consultando los auditores
        public static DataTable TODOS_LOS_AUDITORES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select * from auditores;");
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

        // consultando todos los usuarios
        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select u.idusuario, u.estado, u.nombre, u.idrol, r.descripcion, if(u.estado = 1, 'activo','suspendido') as estado2, u.telefono as telefono  from usuarios u, roles r where u.idrol = r.idrol;");
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

        //validacion de usuario
        public static DataTable ValidarUsuario(String pUsuario, String pCredencial)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"

            select * from usuarios where credencial = sha1('" + pCredencial + @"') and nombre = '" + pUsuario + @"';");
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

        //validacion de solo nombre de usuario (para saber si esta registrado)
        public static DataTable Validarnombreusuario(String pUsuario)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"

            select * from usuarios where  nombre = '" + pUsuario + @"';");
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

    }
}
