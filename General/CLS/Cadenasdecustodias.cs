using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
   public class Cadenasdecustodias
    {
        String idcadenadecustodia;
        String nombre;
        String descripcion;
        String idusuario;

        public String Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Idcadenadecustodia
        {
            get { return idcadenadecustodia; }
            set { idcadenadecustodia = value; }
        }


        // operaciones
        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO cadenasdecustodias(idcadenadecustodia,nombre,descripcion,idusuario) values ( null, ");
            Sentencia.Append("'" + nombre + "',");
            Sentencia.Append("'" + descripcion + "',");
            Sentencia.Append("'" + idusuario + "');");
            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();

            try
            {
                if (oOperacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }
            }
            catch
            {
                Guardado = false;
            }

            return Guardado;

        }


        public Boolean Actualizar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("update cadenasdecustodias set ");
            Sentencia.Append("descripcion = '" + descripcion + "',");
            Sentencia.Append("nombre = '" + nombre + "',");
            Sentencia.Append("idusuario ='" + idusuario + "' where idcadenadecustodia = '" + idcadenadecustodia + "';");
            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();

            try
            {
                if (oOperacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }
            }
            catch
            {
                Guardado = false;
            }

            return Guardado;
        }


        public Boolean Eliminar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            //eliminamos los documentos de esa cadena de custodia y despues la cadena de custodia
            Sentencia.Append("delete from documentos");
            Sentencia.Append(" where idcadenadecustodia= '" + idcadenadecustodia + "';");
            Sentencia.Append("delete from cadenasdecustodias");
            Sentencia.Append(" where idcadenadecustodia= '" + idcadenadecustodia + "';");


            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();

            try
            {
                if (oOperacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }
            }
            catch
            {
                Guardado = false;
            }

            return Guardado;
        }


    }
}
