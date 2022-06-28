using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager.CLS
{
   public class Sesion
    {

        static volatile Sesion _Instancia = null;
        static Object locker = new Object();
        Usuario _oUsuario = new Usuario();

        public Usuario OUsuario
        {
            get { return _oUsuario; }
            set { _oUsuario = value; }
        }

        public static Sesion Instancia
        {
            get
            {
                if (_Instancia == null)
                {
                    lock (locker)
                    {
                        if (_Instancia == null)
                        {
                            _Instancia = new Sesion();
                        }
                    }
                }
                return _Instancia;
            }
        }

        private Sesion()
        {
            _oUsuario = new Usuario();
        }

    }
}
