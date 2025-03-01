using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareasApp;

namespace TaskList
{
    public partial class TaskForm : Form
    {

        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {

            // Obtener la conexión usando el método estático.
            using (SqlConnection conexion = DatabaseHelper.GetConnection())
            {
                conexion.Open(); // Abrimos la conexion.

                string consulta = "SELECT * FROM Tareas";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].ReadOnly = true;
            }
        }
    }
}
