using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class evidencias
    {
        String idevidencia;
        String idproyecto;
        String idtipoevidencia;
        
        String hora;
        String idusuario;
        String nota;
        String dia;
        String mes;
        String anio;
        String minutos;
        String hash;
        String ruta;

        public String Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

        public String Hash
        {
            get { return hash; }
            set { hash = value; }
        }

        public String Minutos
        {
            get { return minutos; }
            set { minutos = value; }
        }

        public String Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public String Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public String Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public String Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public String Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        public String Hora
        {
            get { return hora; }
            set { hora = value; }
        }


        public String Idtipoevidencia
        {
            get { return idtipoevidencia; }
            set { idtipoevidencia = value; }
        }

        public String Idproyecto
        {
            get { return idproyecto; }
            set { idproyecto = value; }
        }

        public String Idevidencia
        {
            get { return idevidencia; }
            set { idevidencia = value; }
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO evidencias(idevidencia,idproyecto,idtipoevidencia,dia,mes,anio,hora,minutos,idusuario,nota,ruta,hash) values ( null, ");
            Sentencia.Append("'" + idproyecto + "',");
            Sentencia.Append("'" + idtipoevidencia + "',");
            Sentencia.Append("'" + DateTime.Now.Day.ToString() + "',");
            Sentencia.Append("'" + DateTime.Now.Month.ToString() + "',");
            Sentencia.Append("'" + DateTime.Now.Year.ToString() + "',");

            Sentencia.Append("'" + DateTime.Now.Hour.ToString() + "',");
            Sentencia.Append("'" + DateTime.Now.Minute.ToString() + "',");

            Sentencia.Append("'" + idusuario + "',");
            Sentencia.Append("'" + nota + "',");
            Sentencia.Append("'" + ruta + "',");


            Sentencia.Append("'" + hash + "');");
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
            Sentencia.Append("update evidencias set ");
            Sentencia.Append("idproyecto = '" + idproyecto + "',");
            Sentencia.Append("idtipoevidencia = '" + idtipoevidencia + "',");
            Sentencia.Append("dia = '" + DateTime.Now.Day.ToString() + "',");
            Sentencia.Append("mes = '" + DateTime.Now.Month.ToString() + "',");
            Sentencia.Append("anio = '" + DateTime.Now.Year.ToString() + "',");

            Sentencia.Append("hora = '" + DateTime.Now.Hour.ToString() + "',");
            Sentencia.Append("minutos = '" + DateTime.Now.Minute.ToString() + "',");
            Sentencia.Append("hash = '" + hash + "',");
            Sentencia.Append("ruta = '" + ruta + "',");


            Sentencia.Append("nota = '" + nota + "',");
            Sentencia.Append("idusuario ='" + idusuario + "' where idevidencia = '" + idevidencia + "';");
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
            Sentencia.Append("delete from evidencias ");
            Sentencia.Append(" where idevidencia= '" + idevidencia + "';");


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
