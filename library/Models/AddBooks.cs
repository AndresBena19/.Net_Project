using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static library.Models.DataAccess.Parameters;
using MySql.Data.MySqlClient;
using library.Models.DataAccess;

namespace library.Models
{
    public class AddBooks
    {
        public string AddBookLibrary(string nombre, string ISBN, string autor, string yearpublished, string type)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_Name", valor = nombre });
            parametros.Add(new Parametro() { nombre = "_isbn", valor = ISBN });
            parametros.Add(new Parametro() { nombre = "_autor", valor = autor });
            parametros.Add(new Parametro() { nombre = "_year", valor = yearpublished });
            parametros.Add(new Parametro() { nombre = "_type", valor = type });

            try
            {
                MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("CreateBooks", parametros);

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
