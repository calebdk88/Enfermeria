using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Enfermeria
{
    class conexion
    {
        //metodo para la coneccion a la base de datos.
       public static MySqlConnection conectarme() 
       {
           MySqlConnection conectar = new MySqlConnection("server=localhost; database=roles; Uid=root; pwd='';");
           conectar.Open();
           return conectar;
       }
       //metodo para agregar elementos a la base de datos.
        public static void agregar()
       {
           conectarme();
           MySqlCommand cmd = new MySqlCommand ("INSERT INTO alumnos (matricula,nombre,apellido,grado,grupo,correo) VALUES(@MAT, @NOM, @APE, @GRA, @GRU, @COR)", conectarme());
       }
        //metodo para cerrar la coneccion a la base de datos.
        public static void desconectarme()
        {
            MySqlConnection conectar = new MySqlConnection();
            conectar.Close();
            
        }
        public static void  listar()
        {

            string cadena1 = "select nombre_subtipos from dessubtipos ORDER BY nombre_subtipos ASC";
            MySqlDataAdapter da1 = new MySqlDataAdapter(cadena1, xd);
           
        }


        public static string xd { get; set; }
    }
}
