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
        private static DBConexion _Instancia = null;
        private MySqlConnection oConexion;
        public Boolean Conectado = false;
        String CadenaConexion = "Server=localhost;Port=3306;Database=documentacionevidencia;Uid=root;Pwd=admin";
        public static DBConexion Instancia
        {
            get
            {
                if (_Instancia == null)

                    _Instancia = new DBConexion();
                return _Instancia;
            }
        }
        private DBConexion()
        {

            try
            {
                this.oConexion = new MySqlConnection();
                this.oConexion.ConnectionString = CadenaConexion;
                this.oConexion.Open();
                Conectado = true;
            }
            catch
            {
                Conectado = false;
            }
        }
        public Boolean Conectar()
        {
            try
            {
                if (this.oConexion.State == System.Data.ConnectionState.Closed)
                {
                    this.oConexion.Open();
                    Conectado = true;
                }
            }
            catch
            {

            }
            return Conectado;
        }
        public void Desconectar()
        {
            try
            {
                if (this.oConexion.State == System.Data.ConnectionState.Open)
                {
                    this.oConexion.Close();
                    Conectado = false;
                }
            }
            catch
            {

            }
        }
        public MySqlConnection getConexion()
        {
            return this.oConexion;
        }
    }
}
