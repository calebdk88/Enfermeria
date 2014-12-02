using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregamos la referencia de mysql
using MySql.Data.MySqlClient;



namespace Enfermeria
{
    
    public partial class agregarAlumnos : Form
    {
           public agregarAlumnos()
        {
            InitializeComponent();
            this.ControlBox = false;
            //posicionamos el cursor en la caja de texto de apellidos
            txtApellidos.Focus();
        }
        //cadena de conexion a mysql
        //MySql.Data.MySqlClient.MySqlConnection coon;
        //string myConexion = "server=localhost;uid=root;pwd='';database=roles;";
      
        private void agregarAlumnos_Load(object sender, EventArgs e)
        {

        }

      
        //metodo para limpiar las cajas de texto
        private void limpiar()
        {
            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtMatricula.Text = "";

            txtApellidos.Focus();
        }

        private void Conectarme()
        {

            try
            {
                //coon = new MySql.Data.MySqlClient.MySqlConnection(myConexion);
                //coon.Open();

                conexion conneccion = new conexion();
                conexion.conectarme();


                MessageBox.Show("Conexion correcta!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error!\n" + ex.Message, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //metodo para cerrar ventanas
        private void Salir()
    {
        this.Close();
    }

        private void button3_Click(object sender, EventArgs e)
        {
            Conectarme();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        
    }
}
