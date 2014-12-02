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
           MySqlConnection conectar = new MySqlConnection();
           conectar.Open();
           MySqlCommand cmd = new MySqlCommand ("INSERT INTO alumnos (matricula,nombre,apellido,grado,grupo,correo) VALUES(@MAT, @NOM, @APE, @GRA, @GRU, @COR)", conectarme());
       }
        //metodo para cerrar la coneccion a la base de datos.
        public static void desconectarme()
        {
            MySqlConnection conectar = new MySqlConnection();
            conectar.Close();
            
        }
    }
}
