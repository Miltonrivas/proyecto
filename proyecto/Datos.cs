using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace proyecto
{
    internal class Datos
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=rivasdb; Uid=root; pwd =;");



            conectar.Open();
            return conectar;
        }
    }
}
