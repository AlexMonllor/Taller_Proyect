using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Sharp_Con_Base_Datos;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenInterfaces
{
    public partial class Form_afegir_cotxe : Form
    {
        public Form_afegir_cotxe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generme la conexió
            MySqlConnection conexionBD = Conexion.Conexio();
            //Obrim conexió
            conexionBD.Open();
            try
            {
                String nombre = textBox1.Text;
                String apellidos = textBox2.Text;
                if (nombre == null || apellidos == null)
                {
                    MessageBox.Show("Añade registro");
                    return;
                }

                string sql = "INSERT INTO cliente(Nom,Cognoms) VALUES('" + nombre + "','" + apellidos + "')";
                //MySqlComman permitix realitzar operacions sobre la base de dades una vegada está
                //establerta la conexió
                //https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                //ExecuteNonQuery permitix insertar, actualizar y eliminar dades de la base de dades.
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al mostrar los clientes: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
