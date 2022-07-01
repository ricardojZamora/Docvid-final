using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager.CLS
{
    public class DBOperacion
    {
        DBConexion nueva = DBConexion.Instancia;
        public DataTable Consultar(String pConsulta)
        {
            return EjecutarConsulta(pConsulta);
        }

        public Int32 Insertar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        public Int32 Actualizar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        public Int32 Eliminar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }

        private Int32 EjecutarSentencia(String pSentencia)
        {
            Int32 FilasAfectadas = 0;
            if (nueva.Conectar())
            {
                MySqlCommand Comando = new MySqlCommand();
                Comando.CommandText = pSentencia;
                Comando.Connection = nueva.getConexion();
                FilasAfectadas = Comando.ExecuteNonQuery();
                nueva.Desconectar();
            }
            return FilasAfectadas;
        }
        private DataTable EjecutarConsulta(String pConsulta)
        {
            DataTable Resultado = new DataTable();
            if (nueva.Conectar())
            {
                MySqlDataAdapter Adaptador = new MySqlDataAdapter();
                MySqlCommand Comando = new MySqlCommand();
                Comando.CommandText = pConsulta;
                Comando.Connection = nueva.getConexion();
                Adaptador.SelectCommand = Comando;
                Adaptador.Fill(Resultado);
                nueva.Desconectar();
            }
            return Resultado;
        }
    }
}
