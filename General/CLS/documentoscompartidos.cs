using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class documentoscompartidos
    {
        String iddocumentocompartido;
        String iddocumento;
        String idusuario;

        public String Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        public String Iddocumento
        {
            get { return iddocumento; }
            set { iddocumento = value; }
        }

        public String Iddocumentocompartido
        {
            get { return iddocumentocompartido; }
            set { iddocumentocompartido = value; }
        }


        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO documentoscompartidos(iddocumentocompartido,idcadenadecustodia, idusuario) values ( null, ");
            Sentencia.Append("'" + iddocumentocompartido + "',");
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
            Sentencia.Append("update documentoscompartidos set ");
            Sentencia.Append("iddocumento = '" + iddocumento + "',");
            Sentencia.Append("idusuario ='" + idusuario + "' where iddocumentocompartido = '" + iddocumentocompartido + "';");
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
            Sentencia.Append("delete from iddocumentocompartido ");
            Sentencia.Append(" where iddocumento= '" + iddocumentocompartido + "';");


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
