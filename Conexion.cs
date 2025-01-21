using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace C_Sharp_Con_Base_Datos
{
    internal class Conexion
    {
        public static MySqlConnection Conexio()
        {
            string servidor = "localhost";
            string bd = "taller_alex_monllor";
            string usuario = "root";
            string pass = "1234";

            // Corregir la cadena de conexión
            string cadenaConexion = $"Server={servidor}; Database={bd}; User ID={usuario}; Password={pass};";

            MySqlConnection conexionBD;

            try
            {
                conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error en la conexión: " + ex.Message);
            }
            return null;
        }
    }
}
