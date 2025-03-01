using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskList; //Se importa TaskList despues de añadirlo como referencia (Click derecho, en Referencias en login > Añadir referencia > Proyectos)
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (Usertxt.Text=="usuario1"&& Passtxt.Text=="12345")
            {
                MessageBox.Show("ok");
                TaskForm taskForm = new TaskForm();
                taskForm.ShowDialog();

               
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectas");
                Usertxt.Clear();
                Passtxt.Clear();
            }
        }
    }
}
