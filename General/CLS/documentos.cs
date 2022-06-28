using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
   public class documentos
    {
        String iddocumento;
        String destacado;
        String comentarios;
        String url;

        public String Url
        {
            get { return url; }
            set { url = value; }
        }

        

        public String Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }

        public String Destacado
        {
            get { return destacado; }
            set { destacado = value; }
        }


        public String Iddocumento
        {
            get { return iddocumento; }
            set { iddocumento = value; }
        }

        private String idcadenadecustodia;

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
            Sentencia.Append("INSERT INTO documentos(iddocumento,destacado,comentarios,idcadenadecustodia,direccion) values ( null, ");
            Sentencia.Append("'" + destacado + "',");
            Sentencia.Append("'" + comentarios + "',");
            Sentencia.Append("'" + idcadenadecustodia + "',");
            Sentencia.Append("'" + url + "');");
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
            Sentencia.Append("update documentos set ");
            Sentencia.Append("destacado = '" + destacado + "',");
            Sentencia.Append("comentarios = '" + comentarios + "',");
            Sentencia.Append("idcadenadecustodia = '" + idcadenadecustodia + "',");
            Sentencia.Append("direccion ='" + url + "' where iddocumento = '" + iddocumento + "';");
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
            Sentencia.Append("delete from documentos ");
            Sentencia.Append(" where iddocumento= '" + iddocumento + "';");


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
