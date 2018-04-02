using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static library.Models.DataAccess.Parameters;
using MySql.Data.MySqlClient;
using library.Models.DataAccess;

namespace library.Models
{
    public class SelectAllTypeBooks
    {


        public Dictionary<string,string> SelectAllTypeBookLibrary()
        {

            List<Parametro> parametros = new List<Parametro>();
            MySqlDataReader reader = null;


            Dictionary<string, string> DataBooks = new Dictionary<string, string>();


            try
            {
                reader = ExecuteProcedure.executeStoreProcedure("SelectAllTypeBooks",parametros);

                while (reader.Read())
                {

                    DataBooks.Add(reader["id"] + "", (string)reader["nombre"]);

                }



            }
            catch (Exception e) { }




            return DataBooks;
        }
    }
}
