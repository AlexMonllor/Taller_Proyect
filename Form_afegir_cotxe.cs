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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenInterfaces
{
    public partial class Form_afegir_client : Form
    {
        public Form_afegir_client()
        {
            InitializeComponent();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            //Generme la conexió
            MySqlConnection conexionBD = Conexion.Conexio();
            //Obrim conexió
            conexionBD.Open();
            try
            {
                System.String marca = textBox1.Text.Trim();
                System.String model = textBox2.Text;
                int any = Int32.Parse(textBox3.Text);
                System.String chasis = textBox4.Text;

                if (string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(chasis))
                {
                    MessageBox.Show("Rellene todos los campos");
                    return;
                }

                string sql = "INSERT INTO cotxe(marca,modelo,any,chasis) VALUES('" + marca + "','" + model + "','" + any + "','"+chasis+"')";
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
            catch (FormatException ex)
            {
                MessageBox.Show("Ponga el formato correcto en Any " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
