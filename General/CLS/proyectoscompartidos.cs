using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class proyectoscompartidos
    {
        String idproyectocompartido;
        String idusuario;
        String idproyecto;

        public String Idproyecto
        {
            get { return idproyecto; }
            set { idproyecto = value; }
        }

        public String Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        public String Idproyectocompartido
        {
            get { return idproyectocompartido; }
            set { idproyectocompartido = value; }
        }


        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO proyectoscompartidos(idproyectocompartido,idproyecto,idusuario) values ( null, ");
            Sentencia.Append("'" + idproyecto + "',");
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
            Sentencia.Append("update proyectoscompartidos set ");
            Sentencia.Append("idproyecto = '" + idproyecto + "',");
            Sentencia.Append("idusuario ='" + idusuario + "' where idproyectocompartido = '" + idproyectocompartido + "';");
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
            Sentencia.Append("delete from proyectoscompartidos ");
            Sentencia.Append(" where idproyectocompartido = '" + idproyectocompartido + "';");


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
