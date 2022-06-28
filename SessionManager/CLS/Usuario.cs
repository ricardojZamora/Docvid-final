using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager.CLS
{
   public class Usuario
    {

        String idusuario;
        String credencial;
        String idrol;
        String nombre;
        String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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

        public String Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

    }
}
