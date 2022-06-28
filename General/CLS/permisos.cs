using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class permisos
    {
        String idpermiso;
        String soloverproyectos;
        String verproyectosajenos;
        String suspendercuenta;
        String cambiarcredencial;
        String crearevidencias;
        String gestionarusuarios;
        String gestionarroles;
        String crearproyectos;
        String compartirproyectos;
        String compartirevidencias;
        String idrol;


        //metodo para la descripcion y agregar
        String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        


        public String Idrol
        {
            get { return idrol; }
            set { idrol = value; }
        }

        public String Compartirevidencias
        {
            get { return compartirevidencias; }
            set { compartirevidencias = value; }
        }

        public String Compartirproyectos
        {
            get { return compartirproyectos; }
            set { compartirproyectos = value; }
        }

        public String Crearproyectos
        {
            get { return crearproyectos; }
            set { crearproyectos = value; }
        }

        public String Gestionarroles
        {
            get { return gestionarroles; }
            set { gestionarroles = value; }
        }

        public String Gestionarusuarios
        {
            get { return gestionarusuarios; }
            set { gestionarusuarios = value; }
        }

        public String Crearevidencias
        {
            get { return crearevidencias; }
            set { crearevidencias = value; }
        }

        public String Cambiarcredencial
        {
            get { return cambiarcredencial; }
            set { cambiarcredencial = value; }
        }

        public String Suspendercuenta
        {
            get { return suspendercuenta; }
            set { suspendercuenta = value; }
        }

        public String Verproyectosajenos
        {
            get { return verproyectosajenos; }
            set { verproyectosajenos = value; }
        }

        public String Soloverproyectos
        {
            get { return soloverproyectos; }
            set { soloverproyectos = value; }
        }

        public String Idpermiso
        {
            get { return idpermiso; }
            set { idpermiso = value; }
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO permisos(idpermiso,soloverproyectos,verproyectosajenos,suspendercuenta,cambiarcredencial,crearevidencias,gestionarusuarios,gestionarroles,crearproyectos,compartirproyectos,compartirevidencias,idrol) values ( null, ");
            Sentencia.Append("'" + soloverproyectos + "',");
            Sentencia.Append("'" + verproyectosajenos + "',");
            Sentencia.Append("'" + suspendercuenta + "',");
            Sentencia.Append("'" + cambiarcredencial + "',");
            Sentencia.Append("'" + crearevidencias + "',");
            Sentencia.Append("'" + gestionarusuarios + "',");
            Sentencia.Append("'" + gestionarroles + "',");
            Sentencia.Append("'" + crearproyectos + "',");
            Sentencia.Append("'" + compartirproyectos + "',");
            Sentencia.Append("'1',");
            Sentencia.Append(" (select idrol from roles where descripcion = '"+descripcion+"' ));");
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

        //por el numero de rol se eliminara 
        public Boolean Eliminar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("delete from permisos ");
            Sentencia.Append(" where idrol = '" + idrol + "';");


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
            Sentencia.Append("update permisos set ");
            Sentencia.Append("soloverproyectos = '" + soloverproyectos + "',");
            Sentencia.Append("verproyectosajenos = '" + verproyectosajenos + "',");
            Sentencia.Append("suspendercuenta = '" + suspendercuenta + "',");
            Sentencia.Append("cambiarcredencial = '" + cambiarcredencial + "',");
            Sentencia.Append("crearevidencias = '" + crearevidencias + "',");
            Sentencia.Append("gestionarusuarios = '" + gestionarusuarios + "',");
            Sentencia.Append("gestionarroles = '" + gestionarroles + "',");
            Sentencia.Append("crearproyectos = '" + crearproyectos + "',");
            Sentencia.Append("compartirproyectos = '" + compartirproyectos + "',");
            Sentencia.Append("compartirevidencias = 1 where idpermiso = '" + idpermiso + "';");
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
