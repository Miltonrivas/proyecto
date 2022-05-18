using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace proyecto
{
    internal class estudiantesD
    {
        public static int AgregarUsuario(string usuario, string encriptada)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into usuarios (Nombre_Usuario,Password) values('{0}', '{1}')",
            usuario, encriptada), Datos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            if (retorno != 0)
            {
                MessageBox.Show("Usuario ingresado exitosamente");
            }
            return retorno;
        }
        public static int Login(string usuario, string contra)
        {
            int valor = 0;
            MySqlConnection conexion = Datos.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT id_usuario FROM usuarios WHERE nombre_usuario = '" + usuario + "' AND password = '" + contra + "' ", conexion);
            valor = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return valor;
        }
    }
}
