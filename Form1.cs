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

namespace TaskList
{
    public partial class TaskForm : Form
    {
        private readonly string conexion = ;

        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            string consulta = "select * from cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
        }
    }
}
