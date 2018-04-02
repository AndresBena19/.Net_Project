using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static library.Models.DataAccess.Parameters;
using MySql.Data.MySqlClient;
using library.Models.DataAccess;

namespace library.Models
{
    public class SelectAllBooks
    {
        public Dictionary<string, Dictionary<string, string>> SelectAllBookLibrary()
        {

            List<Parametro> parametros = new List<Parametro>();
            MySqlDataReader reader = null;


            Dictionary<string, Dictionary<string, string>> Books;
            Books = new Dictionary<string, Dictionary<string, string>>();


            try
            {
                reader = ExecuteProcedure.executeStoreProcedure("SelectAllBooks" , parametros);


                Dictionary<string, string> DataBooks;

                while (reader.Read())
                {
                    DataBooks = new Dictionary<string, string>();
                    DataBooks.Add("nombre", reader["nombre"] + "");
                    DataBooks.Add("autor", reader["autor"] + "");
                    DataBooks.Add("isbn", reader["ISBN"] + "");
                    DataBooks.Add("year", reader["yearOfPublication"] + "");
                    DataBooks.Add("type", reader["idTypesOfBooks"] + "");

                    Books.Add(reader["id"]+"", DataBooks);

                }

            }
            catch (Exception e){}




            return Books ;

        }
    }
}
