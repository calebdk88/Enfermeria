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
            conexion.conectarme();
            string list = "select * from alumnos";
            MySqlDataAdapter ad = new MySqlDataAdapter(list, conexion.conectarme());
            DataTable dt = new DataTable();

            try
            {
                ad.Fill(dt);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("A ocurrido un Error: " + ex.ToString(), Application.ProductName + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stylos();

            dgvlista.DataSource = dt;

            ajustarDGV();
           

        }















        ///////////////////////////// Metodos///////////////////////////////////




      //metodo para auto ajustar los datos en el DGV
          private void ajustarDGV()
        {
            dgvlista.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        //metodo para limpiar las cajas de texto
        private void limpiar()
        {
            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtMatricula.Text = "";

            txtApellidos.Focus();
        }

        private void stylos()
        {
            dgvlista.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dgvlista.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgvlista.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvlista.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlista.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dgvlista.DefaultCellStyle.BackColor = Color.Empty;
            dgvlista.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            dgvlista.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvlista.GridColor = SystemColors.ControlDarkDark;
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
              try
              {
                  conexion.desconectarme();

              }
                catch(Exception){

                    MessageBox.Show("no me he desconectado");
                }
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
