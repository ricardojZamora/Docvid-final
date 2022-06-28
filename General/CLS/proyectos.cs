using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
   public class proyectos
    {
        String idproyecto;
        String titulo;
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

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public String Idproyecto
        {
            get { return idproyecto; }
            set { idproyecto = value; }
        }

        //metodos 
        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO proyectos(idproyecto,titulo,descripcion,idusuario) values ( null, ");
            Sentencia.Append("'" + titulo + "',");
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
            Sentencia.Append("update proyectos set ");
            Sentencia.Append("titulo = '" + titulo + "',");
            Sentencia.Append("idusuario = '" + idusuario + "',");
            Sentencia.Append("descripcion ='" + descripcion + "' where idproyecto = '" + idproyecto + "';");
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
            Sentencia.Append("delete from proyectos ");
            Sentencia.Append(" where idproyecto= '" + idproyecto + "';");


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
