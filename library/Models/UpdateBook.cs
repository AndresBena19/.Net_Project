using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static library.Models.DataAccess.Parameters;
using MySql.Data.MySqlClient;
using library.Models.DataAccess;
namespace library.Models
{
    public class UpdateBook
    {
        public string  UpdateBookLibrary(int id, string nombre, string ISBN, string autor, string yearpublished, string type)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_id", valor  = Convert.ToString(id) });
            parametros.Add(new Parametro() { nombre = "_Name", valor = nombre });
            parametros.Add(new Parametro() { nombre = "_isbn", valor = ISBN });
            parametros.Add(new Parametro() { nombre = "_autor", valor = autor });
            parametros.Add(new Parametro() { nombre = "_year", valor = yearpublished });
            parametros.Add(new Parametro() { nombre = "_type", valor = type });

            try
            {
                MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("UpdateBooks", parametros);

            }
            catch (Exception e)
            {
         
                return e.ToString();
            }

            return "All Good From procedure";

        }
    }
}
