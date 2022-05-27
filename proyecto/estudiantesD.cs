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
        public static List<Genero> Combo()
        {
            List<Genero> _lista = new List<Genero>();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id, nombre_genero FROM genero"), Datos.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Genero pGenero = new Genero();
                pGenero.Id = _reader.GetInt32(0);
                pGenero.nombre_genero = _reader.GetString(1);
                _lista.Add(pGenero);
            }
            return _lista;
        }
        //***************************************************************************************************
        public static int Agregar(estudiante pAlumno)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into estudiante (nombre, seccion, id_genero, foto,fecha_nacimiento) values('{0}', '{1}', '{2}', '{3}', '{4}')",

            pAlumno.Nombre, pAlumno.Seccion, pAlumno.Id_genero, pAlumno.Foto, pAlumno.Fecha), Datos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        //******************************************************************************************************
        public static List<estudiante2> Buscar(string pNombre)
        {
            List<estudiante2> _lista = new List<estudiante2>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT id_estudiante, nombre, seccion, genero.nombre_genero, Foto, fecha_nacimiento FROM estudiante, genero WHERE genero.Id = estudiante.Id_genero "), Datos.ObtenerConexion());


            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                estudiante2 pAlumno2 = new estudiante2();
                pAlumno2.Id = _reader.GetInt32(0);
                pAlumno2.Nombre = _reader.GetString(1);
                pAlumno2.Seccion = _reader.GetString(2);
                pAlumno2.Id_genero = _reader.GetString(3);
                pAlumno2.Foto = _reader.GetString(4);
                pAlumno2.Fecha = _reader.GetString(5);
                _lista.Add(pAlumno2);
            }
            return _lista;
        }
        //********************************************************************************************************
        public static int ObtenerAlumnoMax()
        {
            // Alumno pAlumno = new Alumno();
            MySqlConnection conexion = Datos.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT MAX(id_estudiante) FROM estudiante"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            _reader.Read();
            //{
            int variable = _reader.GetInt32(0);
            conexion.Close();
            MessageBox.Show("valor: " + variable);
            return variable;
        }
        //*********************************************************************************************************
        public static int Actualizar(estudiante pAlumno)
        {
            int retorno = 0;
            MySqlConnection conexion = Datos.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update estudiante set nombre = '{0}', Seccion = '{1}', Id_genero = '{2}', foto = '{3}', fecha_nacimiento = '{4}' where id_estudiante ={ 5 }",
            pAlumno.Nombre, pAlumno.Seccion, pAlumno.Id_genero, pAlumno.Foto, pAlumno.Fecha, pAlumno.Id), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }
    }
}
