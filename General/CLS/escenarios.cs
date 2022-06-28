using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class escenarios
    {
        String idescenario;
        String titulo;
        String notas;
        String pasoactual;
        String idusuario;

        public String Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        public String Pasoactual
        {
            get { return pasoactual; }
            set { pasoactual = value; }
        }

        public String Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public String Idescenario
        {
            get { return idescenario; }
            set { idescenario = value; }
        }
        // operaciones
        public Boolean Guardar()
        {
            //Boolean Guardado = false;
            //StringBuilder Sentencia = new StringBuilder();
            //Sentencia.Append("INSERT INTO escenarios(idescenario,titulo,notas,pasoactual,idusuario) values ( null, ");
            //Sentencia.Append("'" + titulo + "',");
            //Sentencia.Append("'" + notas+ "',");
            //Sentencia.Append("'" + pasoactual+ "',");
            //Sentencia.Append("'" + idusuario+ "');");
            //DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO proyectos(idproyecto,titulo,descripcion,idusuario) values ( null, ");
            Sentencia.Append("'" + titulo + "',");
            Sentencia.Append("'" + notas + "',");
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
            Sentencia.Append("descripcion = '" + notas + "',");
            Sentencia.Append("cantidad_de_evidencias = '1',");
            Sentencia.Append("idusuario ='" + idusuario + "' where idproyecto = '" + idescenario + "';");
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
            Sentencia.Append("delete from escenarios ");
            Sentencia.Append(" where idescenario= '" + idescenario + "';");


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
