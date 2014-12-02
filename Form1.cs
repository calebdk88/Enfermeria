using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enfermeria
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            //para que no salga el maximizar ni minimizar
            this.WindowState = FormWindowState.Maximized;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            agregarAlumnos Ventana =  new agregarAlumnos();
            Ventana.WindowState = FormWindowState.Normal;
            Ventana.MdiParent = this;
            Ventana.Show();
        }

       
    }
}
