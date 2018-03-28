using library.Models.DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static library.Models.DataAccess.Parameters;

namespace library.Models
{
    public class AddBooks
    {
        public string AddBookLibrary(string nombre, string ISBN, string autor, string yearpublished, int type)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_nombre", valor = nombre });
            parametros.Add(new Parametro() { nombre = "_ISBN", valor = ISBN });
            parametros.Add(new Parametro() { nombre = "_autor", valor = autor });
            parametros.Add(new Parametro() { nombre = "_yearpublished", valor = yearpublished });
            parametros.Add(new Parametro() { nombre = "_type", Type = type });

            try
            {
                ExecuteProcedure.executeStoreProcedure("CreateBooks", parametros);

            }catch (Exception e) {
                return "Something BAD";
            }

            return "All Good";

        }
    }
}
