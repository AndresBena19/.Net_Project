using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static library.Models.DataAccess.Parameters;
using MySql.Data.MySqlClient;
using library.Models.DataAccess;

namespace library.Models
{
    public class AddTypeBook
    {
        public string AddTypeBookLibrary(string type)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_type", valor = type});
 

            try
            {
                MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("AddTypeBook", parametros);

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
