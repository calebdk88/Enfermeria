using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Usando la referencia para conectarnos a MySQL

using MySql.Data.MySqlClient;

namespace Enfermeria
{
    public partial class ConsultarAlumnos : Form
    {
        public ConsultarAlumnos()
        {
            InitializeComponent();
            
            // Metodo para autocompletado iniciado al cargar la forma

            AutoCompletadoTextBox();

            // Metodo autofiltrado iniciado al cargar la forma
            AutoFiltradoDGV();
        }

        // Declare esta variable hasta arriba debido a que la utilizo 2 veces
        // para el autofiltrado en el dgv y en la filtracion con el textbox.

        DataTable Tabla;

        void AutoCompletadoTextBox()
        {
            /* David
             * 
             * Codigo para generar el autocompletado */

            // llamamos a la clase conexion y su metodo conectar para abrir la conexion
                conexion.conectarme();

            // Lo siguiente son propiedades de un textbox para el autocompletado

                txtConsultas.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtConsultas.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            /* el comando se utiliara para mostrar los nombres en la lista de sugerencias de 
             * autocompletado cuando se teclee algo */

                string consulta = "SELECT nombre FROM alumnos;";

            /* Establecemos la variable que utilizaremos para efectuar el comando,
             * y a su vez, se le dice hacia donde mandamos la orden (en la base de datos) */
                MySqlCommand comandoconsulta = new MySqlCommand(consulta, conexion.conectarme());

            /*el lector se utiliza para efectuar una lectura de datos*/
                MySqlDataReader lector;

                try 
                {
                    /*el lector tomara el comando SQL*/
                    lector = comandoconsulta.ExecuteReader();

                    while (lector.Read())
                    {
                        /*Mientras la lectura ocurra...que se obtiene el valor
                         * de la tabla del campo nombre*/
                        string Snombre = lector.GetString("nombre");                 
                        coll.Add(Snombre);
                    }

                }
                
                catch(Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                
                // Al final, se realiza el autocompletado de cadenas de la fuente que seleccionamos
                txtConsultas.AutoCompleteCustomSource = coll;
        }

        void AutoFiltradoDGV()
        {
        
        // Codigo para filtrado de informacion en el DGV con el textbox
            conexion.conectarme();

        // Le decimos el comando que queremos ejecutar

            MySqlCommand comandoDB = new MySqlCommand("SELECT matricula, nombre, apellido, idgrado, idgrupo, correo FROM alumnos ORDER BY nombre;", conexion.conectarme());

            try
            {

                MySqlDataAdapter lector = new MySqlDataAdapter();
                lector.SelectCommand = comandoDB;
                Tabla = new DataTable();
                lector.Fill(Tabla);
                BindingSource bFuente = new BindingSource();

                bFuente.DataSource = Tabla;
                dgvConsultas.DataSource = bFuente;
                lector.Update(Tabla);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void txtConsultas_TextChanged(object sender, EventArgs e)
        {

            // Establezco la variable DV utilizado la varible global Tabla

            DataView DV = new DataView(Tabla);

            // Aqui filtro mediante el texbox, lo que sea que escriba me lo muestra
            DV.RowFilter = string.Format("nombre LIKE '%{0}%'", txtConsultas.Text);
            // le pongo de donde obtendra la fuente de filtrado el dgv
            dgvConsultas.DataSource = DV;

        }
        
        
        }
}
