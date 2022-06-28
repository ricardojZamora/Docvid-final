using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Auditores
    {
        String idauditor;
        String nombre;
        String direccion;
        String telefono;
        String correoelectronico;

        public String Correoelectronico
        {
            get { return correoelectronico; }
            set { correoelectronico = value; }
        }


        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
       

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
       

        public String Idauditor
        {
            get { return idauditor; }
            set { idauditor = value; }
        }
    

       

        // operaciones
        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO auditores(idauditor,nombre,direccion,telefono,correoelectronico) values ( null, ");
            Sentencia.Append("'" + nombre + "',");
            Sentencia.Append("'" + direccion + "',");
            Sentencia.Append("'" + telefono + "',");
            Sentencia.Append("'" + correoelectronico + "');");
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
            Sentencia.Append("update auditores set ");
            Sentencia.Append("nombre = '" + nombre + "',");
            Sentencia.Append("direccion = '" + direccion + "',");
            Sentencia.Append("telefono = '" + telefono + "',");
            Sentencia.Append("correoelectronico ='" + correoelectronico+ "' where idauditor = '" + idauditor + "';");
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
            Sentencia.Append("delete from auditores ");
            Sentencia.Append(" where idauditor= '" + idauditor + "';");


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



