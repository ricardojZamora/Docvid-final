using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class cadenascompartidas
    {
        String idcadenacompartida;
        String idcadenadecustodia;
        String idusuario;

        public String Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        public String Idcadenadecustodia
        {
            get { return idcadenadecustodia; }
            set { idcadenadecustodia = value; }
        }


        public String Idcadenacompartida
        {
            get { return idcadenacompartida; }
            set { idcadenacompartida = value; }
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO cadenascompartidas(idcadenacompartida,idcadenadecustodia, idusuario) values ( null, ");
            Sentencia.Append("'" + idcadenadecustodia + "',");
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
            Sentencia.Append("update cadenascompartidas set ");
            Sentencia.Append("idcadenadecustodia = '" + idcadenadecustodia + "',");
            Sentencia.Append("idusuario ='" + idusuario + "' where idcadenacompartida = '" + idcadenacompartida + "';");
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
            Sentencia.Append("delete from idcadenacompartida ");
            Sentencia.Append(" where iddocumento= '" + idcadenacompartida + "';");


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
