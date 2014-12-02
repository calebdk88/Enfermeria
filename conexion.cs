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
       public static MySqlConnection conectarme() 
       {
           MySqlConnection conectar = new MySqlConnection("server=localhost; database=roles; Uid=root; pwd='';");
           conectar.Open();
           return conectar;
       }
    }
}
