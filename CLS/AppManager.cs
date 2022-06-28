using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.CLS
{
   public class AppManager:ApplicationContext
    {

        Int32 usuario = 0;
       public static Boolean _Reiniciar = false;

        public Boolean Reiniciar
        {
            get { return _Reiniciar; }
            set { _Reiniciar = value; }
        }

       private int login()
        {
            int Autorizado = 0;
            login f = new login();
            f.ShowDialog();
            usuario = f.Autorizado;
            return Autorizado;
        }


       public AppManager()
       {
           //GUI.Splash a = new GUI.Splash();
           //a.ShowDialog();
           
           do
           {
               login();
               if (usuario == 0)
               {
                   Application.Exit();
               }
               if (usuario == 1)
               {
                   //CUANDO EL USUARIO INGRESA CORRECTAMENTE SUS CREDENCIALES Y ES ADMINISTRADOR
                   GUI.nuevaprincipal f = new GUI.nuevaprincipal();
                   f.ShowDialog();
                   _Reiniciar = f.Reiniciar;
               }
               if (usuario == 2)
               {
                   //CUANDO EL USUARIO INGRESA CORRECTAMENTE SUS CREDENCIALES Y ES ADMINISTRADOR
                  // GUI.Rol2.principal f = new GUI.Rol2.principal();
                   GUI.nuevaprincipal f = new GUI.nuevaprincipal();

                   f.ShowDialog();
                   _Reiniciar = f.Reiniciar;

               }
               else
               {

                   GUI.nuevaprincipal f = new GUI.nuevaprincipal();
                   f.ShowDialog();
                   _Reiniciar = f.Reiniciar;
                   ////CUANDO EL USUARIO INGRESA CORRECTAMENTE SUS CREDENCIALES Y ES EMPLEADO
                  // Application.Exit();
                   
               }

           } while (_Reiniciar == true);

           //Login();
           //if (usuario == 1)
           //{
           //    //CUANDO EL USUARIO INGRESA CORRECTAMENTE SUS CREDENCIALES Y ES ADMINISTRADOR
           //    GUI.Administrador f = new GUI.Administrador();
           //    f.ShowDialog();
           //}
           //if (usuario == 2)
           //{
           //    //CUANDO EL USUARIO INGRESA CORRECTAMENTE SUS CREDENCIALES Y ES EMPLEADO
           //    GUI.Empleado f = new GUI.Empleado();
           //    f.ShowDialog();
           //}
           //if (usuario == 3)
           //{
           //    //CUANDO EL USUARIO INGRESA CORRECTAMENTE SUS CREDENCIALES Y ES EMPLEADO
           //    GUI.login a = new GUI.login();
           //    a.ShowDialog();
           //}


           //else
           //{
           //    //CUANDO EL USUARIO DECIDE SALIRSE


           //}
       }

    }
}
