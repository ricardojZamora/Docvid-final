using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
   public class Usuarios
    {
        String idusuario;
        String nombre;
        String credencial;
        String idrol;
        String estado;
        String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public String Idrol
        {
            get { return idrol; }
            set { idrol = value; }
        }


        public String Credencial
        {
            get { return credencial; }
            set { credencial = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }


        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO usuarios(idusuario,nombre,credencial,estado,idrol,telefono,llavepublica,llaveprivada) values ( null, ");
            Sentencia.Append("'" + nombre + "',");
            Sentencia.Append("sha1('" + credencial + "'),");
            Sentencia.Append("'" + estado + "',");
            Sentencia.Append("'" + idrol + "',");
            Sentencia.Append("'" + telefono + "',");
            Sentencia.Append("null,");

            Sentencia.Append("null);");
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
            Sentencia.Append("delete from usuarios ");
            Sentencia.Append(" where idusuario = '" + Idusuario + "';");


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
            Sentencia.Append("update usuarios set ");
            Sentencia.Append("nombre = '" + nombre + "',");
            Sentencia.Append("credencial = sha1('" + credencial + "'),");
            Sentencia.Append("estado = '" + estado + "',");
            Sentencia.Append("telefono = '" + telefono + "',");
            Sentencia.Append("idrol ='" + idrol + "' where idusuario = '" + idusuario + "';");
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


        public Boolean ActualizarContrasenia()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("update usuarios set ");
          //  Sentencia.Append("credencial = sha1('" + credencial + "'),");
            Sentencia.Append("credencial = sha1('" + credencial + "') where idusuario = '" + idusuario + "';");
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
