using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager.CLS
{
    public class DBConexion
    {
        public MySqlConnection oConexion;
        String CadenaConexion = "Server=localhost;Port=3306;Database=documentacionevidencia;Uid=root;Pwd=admin";

        public Boolean Conectar()
        {
            Boolean Conectado = false;
            try
            {
                oConexion = new MySqlConnection();
                oConexion.ConnectionString = CadenaConexion;
                oConexion.Open();
                Conectado = true;
            }
            catch
            {
                Conectado = false;
            }
            return Conectado;
        }
        protected void Desconectar()
        {
            try
            {
                if (oConexion.State == System.Data.ConnectionState.Open)
                {
                    oConexion.Close();
                }
            }
            catch
            {

            }
        }
    }
}
