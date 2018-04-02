using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static library.Models.DataAccess.Parameters;
using MySql.Data.MySqlClient;
namespace library.Models.DataAccess
{
    public class ExecuteProcedure
    {

        static string ConnStr = "server=204.93.216.11;user=ivanbano_grupo7;database=ivanbano_grupo7;port=3306;password=grupo7";
        static MySqlConnection conn = null;

        static public MySqlDataReader executeStoreProcedure(string nombre, List<Parametro> parametros =null)
        {

            conn = new MySqlConnection(ConnStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(nombre, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (Parametro p in parametros)
            {
                cmd.Parameters.AddWithValue("@" + p.nombre, p.valor);
            }



            return cmd.ExecuteReader();


        }
        
    }
}
