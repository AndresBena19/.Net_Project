using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static library.Models.DataAccess.Parameters;
using MySql.Data.MySqlClient;
using library.Models.DataAccess;

namespace library.Models
{
    public class DeleteBook
    {

        public string DeleteBookLibrary(string nombre)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_Name", valor = nombre });
            
   
            try
            {
                MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("DeleteBook", parametros);

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return e.ToString();
            }

            return "All Good";

        }

    }
}
