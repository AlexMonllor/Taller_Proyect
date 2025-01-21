using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using C_Sharp_Con_Base_Datos;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ExamenInterfaces
{
    public partial class Mostrar_dades : Form
    {
        public Mostrar_dades()
        {
            InitializeComponent();
            MostrarTablasEnComboBox();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = comboBox1.Text;
                String consulta = "DELETE FROM " + tabla + " WHERE ID =" + dataGridView1.SelectedRows[0].Cells["Id"].Value;
                //Serveix com a pont entre un conjunt de dades i MySQL, permitint recuperar i desar dades.
                //https://dev.mysql.com/doc/dev/connectornet/latest/api/data_api/MySql.Data.MySqlClient.MySqlDataAdapter.html
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, Conexion.Conexio());
                //Representa una tabla de dades en memoria
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione un registro "+ex);
            }
        }
        private void MostrarTablasEnComboBox()
        {
            try
            {
                //limpia
                comboBox1.Items.Clear();

                List<string> list = new List<string>
        {
            "cotxe",
            "cliente"
        };

                foreach (string item in list)
                {
                    comboBox1.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar las tablas en el ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            try
            {
                //La tabla ha de ser pillada desde el combo box
                string tabla = comboBox1.Text;
                string consulta = "SELECT * FROM " + tabla;
                //Serveix com a pont entre un conjunt de dades i MySQL, permitint recuperar i desar dades.
                //https://dev.mysql.com/doc/dev/connectornet/latest/api/data_api/MySql.Data.MySqlClient.MySqlDataAdapter.html
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, Conexion.Conexio());
                //Representa una tabla de dades en memoria
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            } catch(Exception e)
            {
                MessageBox.Show("Seleciona una tabla");
            }
        }
    }
}
