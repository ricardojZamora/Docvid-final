using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
   public class tiposdeevidencias
    {
        String idtipoevidencia;
        String tipo;
        String caracteristica;
        String formato;
        String extension;

        public String Extension
        {
            get { return extension; }
            set { extension = value; }
        }

        public String Formato
        {
            get { return formato; }
            set { formato = value; }
        }

        public String Caracteristica
        {
            get { return caracteristica; }
            set { caracteristica = value; }
        }

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Idtipoevidencia
        {
            get { return idtipoevidencia; }
            set { idtipoevidencia = value; }
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO tiposdeevidencias(idtipoevidencia,tipo,caracteristica,formato,extension) values ( null, ");
            Sentencia.Append("'" + tipo + "',");
            Sentencia.Append("'" + caracteristica + "',");
            Sentencia.Append("'" + formato + "',");
            Sentencia.Append("'" + extension + "');");
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
            Sentencia.Append("update tiposdeevidencias set ");
            Sentencia.Append("extension = '" + extension + "',");
            Sentencia.Append("tipo = '" + tipo + "',");
            Sentencia.Append("caracteristica = '" + caracteristica + "',");
            Sentencia.Append("formato ='" + formato + "' where idtipoevidencia = '" + idtipoevidencia + "';");
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
            Sentencia.Append("delete from tiposdeevidencias ");
            Sentencia.Append(" where idtipoevidencia= '" + idtipoevidencia + "';");


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
